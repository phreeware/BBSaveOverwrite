//using System.Diagnostics;
using System;
using System.IO;
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
            // Ensure that UI updates are performed on the UI thread
            if (InvokeRequired)
            {
                // Use Invoke to marshal the call to the UI thread
                this.Invoke(new Action(() => HotKeyManager_HotKeyPressed(sender, e)));
                return;
            }

            if ((loadmodifier3combobox.SelectedItem != "-") && (loadmodifier1combobox.SelectedItem != "-" || loadmodifier2combobox.SelectedItem != "-"))
            {
                if (loadmodifier1combobox.SelectedItem != "-" && loadmodifier2combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)loadmodifier1combobox.SelectedItem | (KeyModifiers)loadmodifier2combobox.SelectedItem)) && (e.Key == (Keys)loadmodifier3combobox.SelectedItem)) CopyToDest();
                }
                else if (loadmodifier1combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)loadmodifier1combobox.SelectedItem)) && (e.Key == (Keys)loadmodifier3combobox.SelectedItem)) CopyToDest();
                }
                else if (loadmodifier2combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)loadmodifier2combobox.SelectedItem)) && (e.Key == (Keys)loadmodifier3combobox.SelectedItem)) CopyToDest();
                }
            }

            if ((backupmodifier3combobox.SelectedItem != "-") && (backupmodifier1combobox.SelectedItem != "-" || backupmodifier2combobox.SelectedItem != "-"))
            {
                if (backupmodifier1combobox.SelectedItem != "-" && backupmodifier2combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)backupmodifier1combobox.SelectedItem | (KeyModifiers)backupmodifier2combobox.SelectedItem)) && (e.Key == (Keys)backupmodifier3combobox.SelectedItem)) CopyToSource();
                }
                else if (backupmodifier1combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)backupmodifier1combobox.SelectedItem)) && (e.Key == (Keys)backupmodifier3combobox.SelectedItem)) CopyToSource();
                }
                else if (backupmodifier2combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)backupmodifier2combobox.SelectedItem)) && (e.Key == (Keys)backupmodifier3combobox.SelectedItem)) CopyToSource();
                }
            }

            if ((archivemodifier3combobox.SelectedItem != "-") && (archivemodifier1combobox.SelectedItem != "-" || archivemodifier2combobox.SelectedItem != "-"))
            {
                if (archivemodifier1combobox.SelectedItem != "-" && archivemodifier2combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)archivemodifier1combobox.SelectedItem | (KeyModifiers)archivemodifier2combobox.SelectedItem)) && (e.Key == (Keys)archivemodifier3combobox.SelectedItem)) CopyToArchive();
                }
                else if (archivemodifier1combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)archivemodifier1combobox.SelectedItem)) && (e.Key == (Keys)archivemodifier3combobox.SelectedItem)) CopyToArchive();
                }
                else if (archivemodifier2combobox.SelectedItem != "-")
                {
                    if ((e.Modifiers == ((KeyModifiers)archivemodifier2combobox.SelectedItem)) && (e.Key == (Keys)archivemodifier3combobox.SelectedItem)) CopyToArchive();
                }
            }
        }

        private void PopulateHotKeyComboBoxes()
        {
            loadmodifier1combobox.Items.Add("-");
            backupmodifier1combobox.Items.Add("-");
            archivemodifier1combobox.Items.Add("-");
            loadmodifier2combobox.Items.Add("-");
            backupmodifier2combobox.Items.Add("-");
            archivemodifier2combobox.Items.Add("-");
            loadmodifier3combobox.Items.Add("-");
            backupmodifier3combobox.Items.Add("-");
            archivemodifier3combobox.Items.Add("-");

            // Loop through the Modifiers enum and add Modifier keys
            foreach (KeyModifiers modifiers in Enum.GetValues(typeof(KeyModifiers)))
            {
                // Only add normal Modifiers
                if (modifiers != KeyModifiers.NoRepeat)
                {
                    loadmodifier1combobox.Items.Add(modifiers);
                    backupmodifier1combobox.Items.Add(modifiers);
                    archivemodifier1combobox.Items.Add(modifiers);
                    loadmodifier2combobox.Items.Add(modifiers);
                    backupmodifier2combobox.Items.Add(modifiers);
                    archivemodifier2combobox.Items.Add(modifiers);
                }
            }

            // Loop through the Keys enum and only add alphabetic keys (A-Z)
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                // Only add keys from A to Z
                if (key >= Keys.A && key <= Keys.Z)
                {
                    loadmodifier3combobox.Items.Add(key);
                    backupmodifier3combobox.Items.Add(key);
                    archivemodifier3combobox.Items.Add(key);
                }
            }
        }
        private void loadhotkeysavebutton_Click(object sender, EventArgs e)
        {
            if ((loadmodifier3combobox.SelectedItem != "-") && (loadmodifier1combobox.SelectedItem != "-" || loadmodifier2combobox.SelectedItem != "-"))
            {
                if (loadmodifier1combobox.SelectedItem != "-" && loadmodifier2combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)loadmodifier3combobox.SelectedItem, (KeyModifiers)loadmodifier1combobox.SelectedItem | (KeyModifiers)loadmodifier2combobox.SelectedItem);
                    MessageBox.Show("Load save hotkey registered: " + loadmodifier1combobox.SelectedItem.ToString() + " " + loadmodifier2combobox.SelectedItem.ToString() + " " + loadmodifier3combobox.SelectedItem.ToString());
                }
                else if (loadmodifier1combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)loadmodifier3combobox.SelectedItem, (KeyModifiers)loadmodifier1combobox.SelectedItem);
                    MessageBox.Show("Load save hotkey registered: " + loadmodifier1combobox.SelectedItem.ToString() + " " + loadmodifier3combobox.SelectedItem.ToString());
                }
                else if (loadmodifier2combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)loadmodifier3combobox.SelectedItem, (KeyModifiers)loadmodifier2combobox.SelectedItem);
                    MessageBox.Show("Load save hotkey registered: " + loadmodifier2combobox.SelectedItem.ToString() + " " + loadmodifier3combobox.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select at least one modifier and a key");
                return;
            }
        }
        private void backuphotkeysavebutton_Click(object sender, EventArgs e)
        {
            if ((backupmodifier3combobox.SelectedItem != "-") && (backupmodifier1combobox.SelectedItem != "-" || backupmodifier2combobox.SelectedItem != "-"))
            {
                if (backupmodifier1combobox.SelectedItem != "-" && backupmodifier2combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)backupmodifier3combobox.SelectedItem, (KeyModifiers)backupmodifier1combobox.SelectedItem | (KeyModifiers)backupmodifier2combobox.SelectedItem);
                    MessageBox.Show("Backup save hotkey registered: " + backupmodifier1combobox.SelectedItem.ToString() + " " + backupmodifier2combobox.SelectedItem.ToString() + " " + backupmodifier3combobox.SelectedItem.ToString());
                }
                else if (backupmodifier1combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)backupmodifier3combobox.SelectedItem, (KeyModifiers)backupmodifier1combobox.SelectedItem);
                    MessageBox.Show("Backup save hotkey registered: " + backupmodifier1combobox.SelectedItem.ToString() + " " + backupmodifier3combobox.SelectedItem.ToString());
                }
                else if (backupmodifier2combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)backupmodifier3combobox.SelectedItem, (KeyModifiers)backupmodifier2combobox.SelectedItem);
                    MessageBox.Show("Backup save hotkey registered: " + backupmodifier2combobox.SelectedItem.ToString() + " " + backupmodifier3combobox.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select at least one modifier and a key");
                return;
            }
        }
        private void archivehotkeysavebutton_Click(object sender, EventArgs e)
        {
            if ((archivemodifier3combobox.SelectedItem != "-") && (archivemodifier1combobox.SelectedItem != "-" || archivemodifier2combobox.SelectedItem != "-"))
            {
                if (archivemodifier1combobox.SelectedItem != "-" && archivemodifier2combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)archivemodifier3combobox.SelectedItem, (KeyModifiers)archivemodifier1combobox.SelectedItem | (KeyModifiers)archivemodifier2combobox.SelectedItem);
                    MessageBox.Show("Archive backup hotkey registered: " + archivemodifier1combobox.SelectedItem.ToString() + " " + archivemodifier2combobox.SelectedItem.ToString() + " " + archivemodifier3combobox.SelectedItem.ToString());
                }
                else if (archivemodifier1combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)archivemodifier3combobox.SelectedItem, (KeyModifiers)archivemodifier1combobox.SelectedItem);
                    MessageBox.Show("Archive backup hotkey registered: " + archivemodifier1combobox.SelectedItem.ToString() + " " + archivemodifier3combobox.SelectedItem.ToString());
                }
                else if (archivemodifier2combobox.SelectedItem != "-")
                {
                    HotKeyManager.RegisterHotKey((Keys)archivemodifier3combobox.SelectedItem, (KeyModifiers)archivemodifier2combobox.SelectedItem);
                    MessageBox.Show("Archive backup hotkey registered: " + archivemodifier2combobox.SelectedItem.ToString() + " " + archivemodifier3combobox.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select at least one modifier and a key");
                return;
            }
        }

        //COPY DEFINITIONS-----------------------------------------------------------------------------------------------------------------
        public void CopyToDest()
        {
            try
            {
                //CopyDirectory(@sourcefoldertextbox.Text, (@destfoldertextbox.Text + "\\1"), true);
                CopyDirectory(@sourcefoldertextbox.Text, (@destfoldertextbox.Text + "\\1"), "load");
                playaudioloaded();
            }
            catch (Exception)
            {
                //MessageBox.Show("nuh-uh Load");
            }
        }

        public void CopyToSource()
        {
            try
            {
                //CopyDirectory((@destfoldertextbox.Text + "\\1"), @sourcefoldertextbox.Text, true);
                CopyDirectory((@destfoldertextbox.Text + "\\1"), @sourcefoldertextbox.Text, "backup");
                playaudiobacked();
            }
            catch (Exception)
            {
                //MessageBox.Show("nuh-uh Backup");
            }
        }

        public void CopyToArchive()
        {
            try
            {
                //CopyDirectory(@sourcefoldertextbox.Text, @archivefoldertextbox.Text + "\\1 - " + DateTime.Now.ToString("yyyy.MM.dd hh.mm.ss tt"), true);
                CopyDirectory(@sourcefoldertextbox.Text, @archivefoldertextbox.Text + "\\1 - " + DateTime.Now.ToString("yyyy.MM.dd hh.mm.ss tt") + "\\1", "archive");
                playaudioarchived();
            }
            catch (Exception)
            {
                //MessageBox.Show("nuh-uh Archive");
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
            sourcefolder.Description = "Select a '1' folder (name doesn't matter) from a shadPS4 'user/savedata' save backup";
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
            destfolder.Description = "Select your shadPS4 user/'savedata' folder";
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
            archivefolder.Description = "Select an archive folder to archive/backup the save backup folder to";
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

        private bool _isUpdatingComboBoxes = false; // Flag to prevent event loops

        private void loadmodifier1combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdatingComboBoxes) UpdateComboBoxOptions(loadmodifier1combobox, loadmodifier2combobox);
        }
        private void loadmodifier2combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdatingComboBoxes) UpdateComboBoxOptions(loadmodifier2combobox, loadmodifier1combobox);
        }

        private void backupmodifier1combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdatingComboBoxes) UpdateComboBoxOptions(backupmodifier1combobox, backupmodifier2combobox);
        }

        private void backupmodifier2combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdatingComboBoxes) UpdateComboBoxOptions(backupmodifier2combobox, backupmodifier1combobox);
        }

        private void archivemodifier1combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdatingComboBoxes) UpdateComboBoxOptions(archivemodifier1combobox, archivemodifier2combobox);
        }

        private void archivemodifier2combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isUpdatingComboBoxes) UpdateComboBoxOptions(archivemodifier2combobox, archivemodifier1combobox);
        }

        // Updates the options in the targetComboBox based on the selection in the sourceComboBox
        private void UpdateComboBoxOptions(ComboBox sourceComboBox, ComboBox targetComboBox)
        {
            try
            {
                _isUpdatingComboBoxes = true; // Disable event handling during updates

                // Store the currently selected item in the targetComboBox (if any)
                var selectedInTarget = targetComboBox.SelectedItem;

                // Clear all items in the targetComboBox
                targetComboBox.Items.Clear();

                targetComboBox.Items.Add("-");

                // Repopulate the targetComboBox, excluding the item selected in the sourceComboBox
                foreach (KeyModifiers modifiers in Enum.GetValues(typeof(KeyModifiers)))
                {
                    if (modifiers != KeyModifiers.NoRepeat)
                    {
                        if (!modifiers.Equals(sourceComboBox.SelectedItem)) // Do not add the selected item from source
                        {
                            targetComboBox.Items.Add(modifiers);
                        }
                    }
                }

                // Re-select the previously selected item if it still exists in the targetComboBox
                if (selectedInTarget != null && targetComboBox.Items.Contains(selectedInTarget))
                {
                    targetComboBox.SelectedItem = selectedInTarget;
                }
                else
                {
                    // Optionally: Clear the selection if the previously selected item was removed
                    targetComboBox.SelectedIndex = -1;
                }
            }
            finally
            {
                _isUpdatingComboBoxes = false; // Re-enable event handling after update
            }
        }

        //COPY-----------------------------------------------------------------------------------------------------------------
        public void CopyDirectory(string sourceDir, string destinationDir, string mode)
        {
            // Check if selected save and archive folders are the same
            if (sourcefoldertextbox.Text == archivefoldertextbox.Text)
            {
                MessageBox.Show("Aborting. Please select different folders for save and archive backup.");
                return;
            }
            
            switch (mode)
            {
                case "load":
                    // Backup existing destination directory if it exists
                    BackupDestination(destinationDir);
                    break;
                case "backup":
                    // Backup existing destination directory if it exists
                    BackupDestination(destinationDir);
                    break;
                case "archive":

                    break;
            }

            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Get the files in the source directory and copy to the destination directory
            foreach (string dirPath in Directory.GetDirectories(sourceDir, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourceDir, destinationDir));
            }

            foreach (string filePath in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
            {
                string destFilePath = filePath.Replace(sourceDir, destinationDir);
                File.Copy(filePath, destFilePath, true);
            }

        }

        //public void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        //{
        //    // Check if selected save and archive folders are the same
        //    if (sourcefoldertextbox.Text == archivefoldertextbox.Text)
        //    {
        //        MessageBox.Show("Aborting. Please select different folders for save and archive backup.");
        //        return;
        //    }

        //    // Backup existing destination directory if it exists
        //    BackupDestination(destinationDir);

        //    // Get information about the source directory
        //    var dir = new DirectoryInfo(sourceDir);

        //    // Check if the source directory exists
        //    if (!dir.Exists)
        //        throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

        //    // Cache directories before we start copying
        //    DirectoryInfo[] dirs = dir.GetDirectories();

        //    // Create the destination directory
        //    Directory.CreateDirectory(destinationDir);

        //    // Get the files in the source directory and copy to the destination directory
        //    foreach (FileInfo file in dir.GetFiles())
        //    {
        //        string targetFilePath = Path.Combine(destinationDir, file.Name);
        //        file.CopyTo(targetFilePath, true);
        //    }

        //    // If recursive and copying subdirectories, recursively call this method
        //    if (recursive)
        //    {
        //        foreach (DirectoryInfo subDir in dirs)
        //        {
        //            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
        //            CopyDirectory(subDir.FullName, newDestinationDir, true);
        //        }
        //    }
        //}

        // Method to back up existing contents in the destination directory
        public void BackupDestination(string destinationDir)
        {
            // Only back up if the directory exists
            if (Directory.Exists(destinationDir))
            {
                // Create the "BBSaveOverwrite_autobackup" folder inside the destination directory
                string backupDir = Path.Combine(new DirectoryInfo(destinationDir).Parent.FullName, "BBSaveOverwrite_autobackup");
                //Directory.CreateDirectory(backupDir);

                // Copy all existing files and directories from the destination directory to the backup
                foreach (string dirPath in Directory.GetDirectories(destinationDir, "*", SearchOption.AllDirectories))
                {
                    if (dirPath.Contains("BBSaveOverwrite_autobackup") == false)
                    {
                        Directory.CreateDirectory(dirPath.Replace(destinationDir, backupDir));
                    }
                }

                foreach (string filePath in Directory.GetFiles(destinationDir, "*.*", SearchOption.AllDirectories))
                {
                    string destFilePath = filePath.Replace(destinationDir, backupDir);
                    File.Copy(filePath, destFilePath, true);
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

        private bool LoadComboTriggered = false;
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

                    // Detect when both R3 and Sel are pressed
                    if (R3 && Sel && !LoadComboTriggered)
                    {
                        LoadComboTriggered = true;
                        CopyToDest();
                    }
                    else if (!R3 || !Sel)
                    {
                        LoadComboTriggered = false;
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
        ALT = 1,
        CTRL = 2,
        SHIFT = 4,
        WIN = 8,
        NoRepeat = 0x4000
    }


}
