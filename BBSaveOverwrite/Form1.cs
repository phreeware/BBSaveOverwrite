//using System.Diagnostics;
using System;
using System.Media;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BBSaveOverwrite
{
    public partial class bbsaveoverwriteform : Form
    {

        public bbsaveoverwriteform()
        {
            InitializeComponent();
            RegisterForRawInput();
        }

        //HOTKEY HANDLERS-----------------------------------------------------------------------------------------------------------------
        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {

            if ((e.Modifiers == KeyModifiers.Alt) && (e.Key == Keys.S))
            {
                CopyToDest();
            }
            else if ((e.Modifiers == (KeyModifiers.Alt | KeyModifiers.Shift)) && (e.Key == Keys.S))
            {
                CopyToSource();
            }

        }

        //COPY DEFINITIONS-----------------------------------------------------------------------------------------------------------------
        public void CopyToDest()
        {
            try
            {
                CopyDirectory(@sourcefoldertextbox.Text, (@destfoldertextbox.Text + "\\1"), true);
                playaudioloaded();
            }
            catch (Exception)
            {
                MessageBox.Show("nuh-uh Load");
            }
        }

        public void CopyToSource()
        {
            try
            {
                CopyDirectory((@destfoldertextbox.Text + "\\1"), @sourcefoldertextbox.Text, true);
                playaudiobacked();
            }
            catch (Exception)
            {
                MessageBox.Show("nuh-uh Backup");
            }
        }

        public void CopyToArchive()
        {
            try
            {
                CopyDirectory(@sourcefoldertextbox.Text, @archivefoldertextbox.Text, true);
                playaudioarchived();
            }
            catch (Exception)
            {
                MessageBox.Show("nuh-uh Archive");
            }
        }

        //AUDIO-----------------------------------------------------------------------------------------------------------------
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
        public void playaudioarchived()
        {
            using (var audioStream = new MemoryStream(Properties.Resource1.archived))
            {
                using (var player = new SoundPlayer(audioStream))
                {
                    player.Play();
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
        private void archivedtestbutton_Click(object sender, EventArgs e)
        {
            playaudioarchived();
        }

        //UI ELEMENTS/BUTTONS-----------------------------------------------------------------------------------------------------------------
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
        private void archivefolderbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog archivefolder = new FolderBrowserDialog();
            archivefolder.Description = "Select an archive folder, to backup the current save folder to";
            if (archivefolder.ShowDialog() == DialogResult.OK)
            {
                archivefoldertextbox.Text = archivefolder.SelectedPath;
                Properties.Settings.Default.ArchiveFolderSetting = archivefolder.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        private void overwritedestbutton_Click(object sender, EventArgs e)
        {
            CopyToDest();
        }
        private void overwritesourcebutton_Click(object sender, EventArgs e)
        {
            CopyToSource();
        }
        private void archivesavebutton_Click(object sender, EventArgs e)
        {
            CopyToArchive();
        }

        //COPY-----------------------------------------------------------------------------------------------------------------
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

        //GAMEPAD-----------------------------------------------------------------------------------------------------------------
        // Constants for raw input
        private const int RID_INPUT = 0x10000003;
        private const int RIM_TYPEHID = 2;

        // Structs for raw input handling
        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUTDEVICE
        {
            public ushort UsagePage;
            public ushort Usage;
            public uint Flags;
            public IntPtr Target;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUTHEADER
        {
            public uint Type;
            public uint Size;
            public IntPtr Device;
            public IntPtr wParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUTHID
        {
            public uint Size;
            public uint Count;
            // Flexible array member (size depends on Size * Count)
            public byte RawData; // Placeholder for the actual data array (handled later)
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUT
        {
            public RAWINPUTHEADER Header;
            public RAWINPUTHID Hid;
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterRawInputDevices(RAWINPUTDEVICE[] pRawInputDevice, uint uiNumDevices, uint cbSize);

        private bool SelPressed = false;
        private bool BackupComboTriggered = false;
        private bool ArchiveComboTriggered = false;

        // Register to receive raw input for HID devices (PS5 controller)
        private void RegisterForRawInput()
        {
            RAWINPUTDEVICE[] rid = new RAWINPUTDEVICE[1];
            rid[0].UsagePage = 0x01; // Generic Desktop Controls
            rid[0].Usage = 0x05;     // Gamepad
            rid[0].Flags = 0x100;    // Receive all inputs even if focus is not on the app
            rid[0].Target = Handle;

            if (!RegisterRawInputDevices(rid, (uint)rid.Length, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICE))))
            {
                return;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0x00FF;

            if (m.Msg == WM_INPUT)
            {
                if (dualsensecheckbox.Checked)
                {
                    uint dwSize = 0;
                    // Get the size of the raw input buffer
                    GetRawInputData(m.LParam, RID_INPUT, IntPtr.Zero, ref dwSize, (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER)));

                    if (dwSize > 0)
                    {
                        IntPtr rawDataBuffer = Marshal.AllocHGlobal((int)dwSize);
                        try
                        {
                            // Get the raw input data
                            if (GetRawInputData(m.LParam, RID_INPUT, rawDataBuffer, ref dwSize, (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER))) == dwSize)
                            {
                                ProcessRawInput(rawDataBuffer, dwSize);
                            }
                        }
                        finally
                        {
                            Marshal.FreeHGlobal(rawDataBuffer);
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void ProcessRawInput(IntPtr rawDataBuffer, uint size)
        {
            RAWINPUTHEADER header = Marshal.PtrToStructure<RAWINPUTHEADER>(rawDataBuffer);

            // If the raw input type is HID (i.e., controller input)
            if (header.Type == RIM_TYPEHID)
            {
                IntPtr rawInputDataPtr = IntPtr.Add(rawDataBuffer, Marshal.SizeOf(typeof(RAWINPUTHEADER)));
                RAWINPUTHID hidInput = Marshal.PtrToStructure<RAWINPUTHID>(rawInputDataPtr);

                // HID report size is in hidInput.Size, and Count tells us how many reports are received
                uint totalHidDataSize = hidInput.Size * hidInput.Count;

                // Allocate buffer to store the HID data
                byte[] hidData = new byte[totalHidDataSize];

                // Copy the HID data from the raw buffer
                IntPtr hidDataStart = IntPtr.Add(rawInputDataPtr, Marshal.SizeOf(typeof(RAWINPUTHID)));
                Marshal.Copy(hidDataStart, hidData, 0, (int)totalHidDataSize);

                // Log the raw HID data to see its structure
                //Debug.WriteLine("HID Data: " + BitConverter.ToString(hidData));

                // Check the third byte for L3 and R3
                if (hidData.Length > 2)
                {
                    bool L3 = (hidData[2] & 0x40) != 0; // L3 is represented by bit 6 (0x40)
                    bool R3 = (hidData[2] & 0x80) != 0; // R3 is represented by bit 7 (0x80)
                    bool Sel = (hidData[2] & 0x10) != 0; // Sel is represented by (0x10)
                    bool Start = (hidData[2] & 0x20) != 0; // Start is represented by (0x20)

                    // Detect when both L3 and Start are pressed
                    if (L3 && Start && !BackupComboTriggered)
                    {
                        BackupComboTriggered = true;
                        CopyToSource();
                    }
                    else if (!L3 || !Start)
                    {
                        BackupComboTriggered = false;
                    }

                    // Detect when both R3 and Start are pressed
                    if (R3 && Start && !ArchiveComboTriggered)
                    {
                        ArchiveComboTriggered = true;
                        CopyToArchive();
                    }
                    else if (!R3 || !Start)
                    {
                        ArchiveComboTriggered = false;
                    }

                    // Check for single Select button press
                    if (Sel && !SelPressed)
                    {
                        SelPressed = true;
                        CopyToDest();
                    }
                    else if (!Sel)
                    {
                        SelPressed = false;
                    }
                }
            }
        }
    }

    //HOTKEY-----------------------------------------------------------------------------------------------------------------
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
