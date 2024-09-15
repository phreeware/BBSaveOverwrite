using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BBSaveOverwrite
{
    public partial class bbsaveoverwriteform : Form
    {
        public bbsaveoverwriteform()
        {
            InitializeComponent();

        }

        public void playaudioloaded()
        {
            using (var audioStream = new MemoryStream(Properties.Resource1.loaded))
            {
                using (var player = new SoundPlayer(audioStream))
                {
                    player.Play();
                }
            }
        }

        public void playaudiobacked()
        {
            using (var audioStream = new MemoryStream(Properties.Resource1.backed))
            {
                using (var player = new SoundPlayer(audioStream))
                {
                    player.Play();
                }
            }
        }

        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {

            if ((e.Modifiers == KeyModifiers.Alt) && (e.Key == Keys.S))
            {
                try
                {
                    CopyDirectory(@sourcefoldertextbox.Text, (@destfoldertextbox.Text + "\\1"), true);
                    playaudioloaded();
                }
                catch (Exception)
                {
                }
            }
            else if ((e.Modifiers == (KeyModifiers.Alt | KeyModifiers.Shift)) && (e.Key == Keys.S))
            {
                try
                {
                    CopyDirectory((@destfoldertextbox.Text + "\\1"), @sourcefoldertextbox.Text, true);
                    playaudiobacked();
                }
                catch (Exception)
                {
                }
            }

        }

        private void sourcefolderbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourcefolder = new FolderBrowserDialog();
            sourcefolder.Description = "Select a '1' folder (name doesn't matter) from a shadPS4 'user/savedata' save";
            if (sourcefolder.ShowDialog() == DialogResult.OK)
            {
                sourcefoldertextbox.Text = sourcefolder.SelectedPath;
                Properties.Settings.Default.SourceFolderSetting = sourcefolder.SelectedPath;
                Properties.Settings.Default.Save();
            }

        }

        private void destfolderbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destfolder = new FolderBrowserDialog();
            destfolder.Description = "Select your shadPS4 user/'savedata' destination folder";
            if (destfolder.ShowDialog() == DialogResult.OK)
            {
                destfoldertextbox.Text = destfolder.SelectedPath;
                Properties.Settings.Default.DestFolderSetting = destfolder.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void overwritedestbutton_Click(object sender, EventArgs e)
        {
            try
            {
                CopyDirectory(@sourcefoldertextbox.Text, (@destfoldertextbox.Text + "\\1"), true);
                playaudioloaded();
            }
            catch (Exception)
            {
            }

        }

        private void overwritesourcebutton_Click(object sender, EventArgs e)
        {

            try
            {
                CopyDirectory((@destfoldertextbox.Text + "\\1"), @sourcefoldertextbox.Text, true);
                playaudiobacked();
            }
            catch (Exception)
            {
            }

        }

        static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // czech if BB save


            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory

            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath, true);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        private void loadedtestbutton_Click(object sender, EventArgs e)
        {
            playaudioloaded();
        }

        private void backedtestbutton_Click(object sender, EventArgs e)
        {
            playaudiobacked();
        }

    }

    public static class HotKeyManager
    {
        public static event EventHandler<HotKeyEventArgs> HotKeyPressed;

        public static int RegisterHotKey(Keys key, KeyModifiers modifiers)
        {
            _windowReadyEvent.WaitOne();
            int id = System.Threading.Interlocked.Increment(ref _id);
            _wnd.Invoke(new RegisterHotKeyDelegate(RegisterHotKeyInternal), _hwnd, id, (uint)modifiers, (uint)key);
            return id;
        }

        public static void UnregisterHotKey(int id)
        {
            _wnd.Invoke(new UnRegisterHotKeyDelegate(UnRegisterHotKeyInternal), _hwnd, id);
        }

        delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);
        delegate void UnRegisterHotKeyDelegate(IntPtr hwnd, int id);

        private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
        {
            RegisterHotKey(hwnd, id, modifiers, key);
        }

        private static void UnRegisterHotKeyInternal(IntPtr hwnd, int id)
        {
            UnregisterHotKey(_hwnd, id);
        }

        private static void OnHotKeyPressed(HotKeyEventArgs e)
        {
            if (HotKeyManager.HotKeyPressed != null)
            {
                HotKeyManager.HotKeyPressed(null, e);
            }
        }

        private static volatile MessageWindow _wnd;
        private static volatile IntPtr _hwnd;
        private static ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);
        static HotKeyManager()
        {
            Thread messageLoop = new Thread(delegate ()
            {
                Application.Run(new MessageWindow());
            });
            messageLoop.Name = "MessageLoopThread";
            messageLoop.IsBackground = true;
            messageLoop.Start();
        }

        private class MessageWindow : Form
        {
            public MessageWindow()
            {
                _wnd = this;
                _hwnd = this.Handle;
                _windowReadyEvent.Set();
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WM_HOTKEY)
                {
                    HotKeyEventArgs e = new HotKeyEventArgs(m.LParam);
                    HotKeyManager.OnHotKeyPressed(e);
                }

                base.WndProc(ref m);
            }

            protected override void SetVisibleCore(bool value)
            {
                // Ensure the window never becomes visible
                base.SetVisibleCore(false);
            }

            private const int WM_HOTKEY = 0x312;
        }

        [DllImport("user32", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static int _id = 0;
    }

    public class HotKeyEventArgs : EventArgs
    {
        public readonly Keys Key;
        public readonly KeyModifiers Modifiers;

        public HotKeyEventArgs(Keys key, KeyModifiers modifiers)
        {
            this.Key = key;
            this.Modifiers = modifiers;
        }

        public HotKeyEventArgs(IntPtr hotKeyParam)
        {
            uint param = (uint)hotKeyParam.ToInt64();
            Key = (Keys)((param & 0xffff0000) >> 16);
            Modifiers = (KeyModifiers)(param & 0x0000ffff);
        }
    }

    [Flags]
    public enum KeyModifiers
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        NoRepeat = 0x4000
    }

}
