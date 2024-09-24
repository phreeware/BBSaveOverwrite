
namespace BBSaveOverwrite
{
    partial class bbsaveoverwriteform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bbsaveoverwriteform));
            sourcefoldertextbox = new TextBox();
            sourcefolderbutton = new Button();
            destfolderbutton = new Button();
            destfoldertextbox = new TextBox();
            desthotkeylabel = new Label();
            overwritedestbutton = new Button();
            overwritesourcebutton = new Button();
            sourcehotkeylabel = new Label();
            toolTip1 = new ToolTip(components);
            sourcefolderqlabel = new Label();
            destfolderqlabel = new Label();
            overwritedestfolderqlabel = new Label();
            overwritesourcefolderqlabel = new Label();
            dualsensehkqlabel = new Label();
            archivefolderqlabel = new Label();
            archivesaveqlabel = new Label();
            loadedtestbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            backedtestbutton = new Button();
            dualsensecheckbox = new CheckBox();
            archivefoldertextbox = new TextBox();
            archivefolderbutton = new Button();
            archivedtestbutton = new Button();
            label3 = new Label();
            archivehotkeylabel = new Label();
            archivesavebutton = new Button();
            SuspendLayout();
            // 
            // sourcefoldertextbox
            // 
            sourcefoldertextbox.Location = new Point(456, 117);
            sourcefoldertextbox.Name = "sourcefoldertextbox";
            sourcefoldertextbox.Size = new Size(1365, 55);
            sourcefoldertextbox.TabIndex = 0;
            // 
            // sourcefolderbutton
            // 
            sourcefolderbutton.Location = new Point(63, 110);
            sourcefolderbutton.Name = "sourcefolderbutton";
            sourcefolderbutton.Size = new Size(372, 69);
            sourcefolderbutton.TabIndex = 1;
            sourcefolderbutton.Text = "Save backup folder";
            sourcefolderbutton.UseVisualStyleBackColor = true;
            sourcefolderbutton.Click += sourcefolderbutton_Click;
            // 
            // destfolderbutton
            // 
            destfolderbutton.Location = new Point(63, 241);
            destfolderbutton.Name = "destfolderbutton";
            destfolderbutton.Size = new Size(372, 69);
            destfolderbutton.TabIndex = 2;
            destfolderbutton.Text = "user/savedata folder";
            destfolderbutton.UseVisualStyleBackColor = true;
            destfolderbutton.Click += destfolderbutton_Click;
            // 
            // destfoldertextbox
            // 
            destfoldertextbox.Location = new Point(456, 248);
            destfoldertextbox.Name = "destfoldertextbox";
            destfoldertextbox.Size = new Size(1365, 55);
            destfoldertextbox.TabIndex = 3;
            // 
            // desthotkeylabel
            // 
            desthotkeylabel.AutoSize = true;
            desthotkeylabel.BackColor = Color.Transparent;
            desthotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            desthotkeylabel.ForeColor = Color.White;
            desthotkeylabel.Location = new Point(456, 505);
            desthotkeylabel.Name = "desthotkeylabel";
            desthotkeylabel.Size = new Size(151, 48);
            desthotkeylabel.TabIndex = 4;
            desthotkeylabel.Text = "Hotkey:";
            // 
            // overwritedestbutton
            // 
            overwritedestbutton.BackColor = Color.DarkTurquoise;
            overwritedestbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            overwritedestbutton.Location = new Point(63, 495);
            overwritedestbutton.Name = "overwritedestbutton";
            overwritedestbutton.Size = new Size(372, 69);
            overwritedestbutton.TabIndex = 5;
            overwritedestbutton.Text = "Load save";
            overwritedestbutton.UseVisualStyleBackColor = false;
            overwritedestbutton.Click += overwritedestbutton_Click;
            // 
            // overwritesourcebutton
            // 
            overwritesourcebutton.BackColor = Color.Coral;
            overwritesourcebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            overwritesourcebutton.Location = new Point(63, 625);
            overwritesourcebutton.Name = "overwritesourcebutton";
            overwritesourcebutton.Size = new Size(372, 69);
            overwritesourcebutton.TabIndex = 6;
            overwritesourcebutton.Text = "Backup save";
            overwritesourcebutton.UseVisualStyleBackColor = false;
            overwritesourcebutton.Click += overwritesourcebutton_Click;
            // 
            // sourcehotkeylabel
            // 
            sourcehotkeylabel.AutoSize = true;
            sourcehotkeylabel.BackColor = Color.Transparent;
            sourcehotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sourcehotkeylabel.ForeColor = Color.White;
            sourcehotkeylabel.Location = new Point(456, 635);
            sourcehotkeylabel.Name = "sourcehotkeylabel";
            sourcehotkeylabel.Size = new Size(151, 48);
            sourcehotkeylabel.TabIndex = 7;
            sourcehotkeylabel.Text = "Hotkey:";
            // 
            // sourcefolderqlabel
            // 
            sourcefolderqlabel.AutoSize = true;
            sourcefolderqlabel.BackColor = Color.Red;
            sourcefolderqlabel.ForeColor = SystemColors.Info;
            sourcefolderqlabel.Location = new Point(1854, 120);
            sourcefolderqlabel.Name = "sourcefolderqlabel";
            sourcefolderqlabel.Size = new Size(36, 48);
            sourcefolderqlabel.TabIndex = 8;
            sourcefolderqlabel.Text = "?";
            toolTip1.SetToolTip(sourcefolderqlabel, "Select a '1' folder (name doesn't matter) from a shadPS4 'user/savedata' save");
            // 
            // destfolderqlabel
            // 
            destfolderqlabel.AutoSize = true;
            destfolderqlabel.BackColor = Color.Red;
            destfolderqlabel.ForeColor = SystemColors.Info;
            destfolderqlabel.Location = new Point(1854, 251);
            destfolderqlabel.Name = "destfolderqlabel";
            destfolderqlabel.Size = new Size(36, 48);
            destfolderqlabel.TabIndex = 9;
            destfolderqlabel.Text = "?";
            toolTip1.SetToolTip(destfolderqlabel, "Select your shadPS4 user/'savedata' destination folder");
            // 
            // overwritedestfolderqlabel
            // 
            overwritedestfolderqlabel.AutoSize = true;
            overwritedestfolderqlabel.BackColor = Color.Red;
            overwritedestfolderqlabel.ForeColor = SystemColors.Info;
            overwritedestfolderqlabel.Location = new Point(1854, 505);
            overwritedestfolderqlabel.Name = "overwritedestfolderqlabel";
            overwritedestfolderqlabel.Size = new Size(36, 48);
            overwritedestfolderqlabel.TabIndex = 10;
            overwritedestfolderqlabel.Text = "?";
            toolTip1.SetToolTip(overwritedestfolderqlabel, "Overwrites the Source Folder over the Destination Folder without asking.");
            // 
            // overwritesourcefolderqlabel
            // 
            overwritesourcefolderqlabel.AutoSize = true;
            overwritesourcefolderqlabel.BackColor = Color.Red;
            overwritesourcefolderqlabel.ForeColor = SystemColors.Info;
            overwritesourcefolderqlabel.Location = new Point(1854, 635);
            overwritesourcefolderqlabel.Name = "overwritesourcefolderqlabel";
            overwritesourcefolderqlabel.Size = new Size(36, 48);
            overwritesourcefolderqlabel.TabIndex = 11;
            overwritesourcefolderqlabel.Text = "?";
            toolTip1.SetToolTip(overwritesourcefolderqlabel, "Reverse Overwrites the current shadPS4 savestate to the selected Source Folder.");
            // 
            // dualsensehkqlabel
            // 
            dualsensehkqlabel.AutoSize = true;
            dualsensehkqlabel.BackColor = Color.Red;
            dualsensehkqlabel.ForeColor = SystemColors.Info;
            dualsensehkqlabel.Location = new Point(1854, 896);
            dualsensehkqlabel.Name = "dualsensehkqlabel";
            dualsensehkqlabel.Size = new Size(36, 48);
            dualsensehkqlabel.TabIndex = 17;
            dualsensehkqlabel.Text = "?";
            toolTip1.SetToolTip(dualsensehkqlabel, "Enable PS5 DualSense controller hotkeys:\r\nCreate (Select) = Load save\r\nL3 + Option (Start) = Backup save\r\nR3 + Option (Start) = Archive backup");
            // 
            // archivefolderqlabel
            // 
            archivefolderqlabel.AutoSize = true;
            archivefolderqlabel.BackColor = Color.Red;
            archivefolderqlabel.ForeColor = SystemColors.Info;
            archivefolderqlabel.Location = new Point(1854, 375);
            archivefolderqlabel.Name = "archivefolderqlabel";
            archivefolderqlabel.Size = new Size(36, 48);
            archivefolderqlabel.TabIndex = 20;
            archivefolderqlabel.Text = "?";
            toolTip1.SetToolTip(archivefolderqlabel, "Select an archive folder, to backup the current save folder to");
            // 
            // archivesaveqlabel
            // 
            archivesaveqlabel.AutoSize = true;
            archivesaveqlabel.BackColor = Color.Red;
            archivesaveqlabel.ForeColor = SystemColors.Info;
            archivesaveqlabel.Location = new Point(1854, 761);
            archivesaveqlabel.Name = "archivesaveqlabel";
            archivesaveqlabel.Size = new Size(36, 48);
            archivesaveqlabel.TabIndex = 23;
            archivesaveqlabel.Text = "?";
            toolTip1.SetToolTip(archivesaveqlabel, "This is meant to \"archive\" a good save backup, that can't get overwritten by the tool");
            // 
            // loadedtestbutton
            // 
            loadedtestbutton.Location = new Point(1588, 504);
            loadedtestbutton.Name = "loadedtestbutton";
            loadedtestbutton.Size = new Size(50, 50);
            loadedtestbutton.TabIndex = 12;
            loadedtestbutton.Text = "L";
            loadedtestbutton.UseVisualStyleBackColor = true;
            loadedtestbutton.Click += loadedtestbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1371, 505);
            label1.Name = "label1";
            label1.Size = new Size(201, 48);
            label1.TabIndex = 13;
            label1.Text = "Soundtest:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1371, 635);
            label2.Name = "label2";
            label2.Size = new Size(201, 48);
            label2.TabIndex = 14;
            label2.Text = "Soundtest:";
            // 
            // backedtestbutton
            // 
            backedtestbutton.Location = new Point(1588, 633);
            backedtestbutton.Name = "backedtestbutton";
            backedtestbutton.Size = new Size(50, 50);
            backedtestbutton.TabIndex = 15;
            backedtestbutton.Text = "B";
            backedtestbutton.UseVisualStyleBackColor = true;
            backedtestbutton.Click += backedtestbutton_Click;
            // 
            // dualsensecheckbox
            // 
            dualsensecheckbox.AutoSize = true;
            dualsensecheckbox.BackColor = Color.Transparent;
            dualsensecheckbox.ForeColor = Color.White;
            dualsensecheckbox.Location = new Point(1371, 892);
            dualsensecheckbox.Name = "dualsensecheckbox";
            dualsensecheckbox.Size = new Size(430, 52);
            dualsensecheckbox.TabIndex = 16;
            dualsensecheckbox.Text = "PS5 DualSense hotkeys";
            dualsensecheckbox.UseVisualStyleBackColor = false;
            // 
            // archivefoldertextbox
            // 
            archivefoldertextbox.Location = new Point(456, 372);
            archivefoldertextbox.Name = "archivefoldertextbox";
            archivefoldertextbox.Size = new Size(1365, 55);
            archivefoldertextbox.TabIndex = 19;
            // 
            // archivefolderbutton
            // 
            archivefolderbutton.Location = new Point(63, 365);
            archivefolderbutton.Name = "archivefolderbutton";
            archivefolderbutton.Size = new Size(372, 69);
            archivefolderbutton.TabIndex = 18;
            archivefolderbutton.Text = "Save archive folder";
            archivefolderbutton.UseVisualStyleBackColor = true;
            archivefolderbutton.Click += archivefolderbutton_Click;
            // 
            // archivedtestbutton
            // 
            archivedtestbutton.Location = new Point(1588, 759);
            archivedtestbutton.Name = "archivedtestbutton";
            archivedtestbutton.Size = new Size(50, 50);
            archivedtestbutton.TabIndex = 25;
            archivedtestbutton.Text = "A";
            archivedtestbutton.UseVisualStyleBackColor = true;
            archivedtestbutton.Click += archivedtestbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1371, 761);
            label3.Name = "label3";
            label3.Size = new Size(201, 48);
            label3.TabIndex = 24;
            label3.Text = "Soundtest:";
            // 
            // archivehotkeylabel
            // 
            archivehotkeylabel.AutoSize = true;
            archivehotkeylabel.BackColor = Color.Transparent;
            archivehotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            archivehotkeylabel.ForeColor = Color.White;
            archivehotkeylabel.Location = new Point(456, 761);
            archivehotkeylabel.Name = "archivehotkeylabel";
            archivehotkeylabel.Size = new Size(151, 48);
            archivehotkeylabel.TabIndex = 22;
            archivehotkeylabel.Text = "Hotkey:";
            // 
            // archivesavebutton
            // 
            archivesavebutton.BackColor = Color.Plum;
            archivesavebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            archivesavebutton.Location = new Point(63, 751);
            archivesavebutton.Name = "archivesavebutton";
            archivesavebutton.Size = new Size(372, 69);
            archivesavebutton.TabIndex = 21;
            archivesavebutton.Text = "Archive backup";
            archivesavebutton.UseVisualStyleBackColor = false;
            archivesavebutton.Click += archivesavebutton_Click;
            // 
            // bbsaveoverwriteform
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1943, 1012);
            Controls.Add(archivedtestbutton);
            Controls.Add(label3);
            Controls.Add(archivesaveqlabel);
            Controls.Add(archivehotkeylabel);
            Controls.Add(archivesavebutton);
            Controls.Add(archivefolderqlabel);
            Controls.Add(archivefoldertextbox);
            Controls.Add(archivefolderbutton);
            Controls.Add(dualsensehkqlabel);
            Controls.Add(dualsensecheckbox);
            Controls.Add(backedtestbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loadedtestbutton);
            Controls.Add(overwritesourcefolderqlabel);
            Controls.Add(overwritedestfolderqlabel);
            Controls.Add(destfolderqlabel);
            Controls.Add(sourcefolderqlabel);
            Controls.Add(sourcehotkeylabel);
            Controls.Add(overwritesourcebutton);
            Controls.Add(overwritedestbutton);
            Controls.Add(desthotkeylabel);
            Controls.Add(destfoldertextbox);
            Controls.Add(destfolderbutton);
            Controls.Add(sourcefolderbutton);
            Controls.Add(sourcefoldertextbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "bbsaveoverwriteform";
            Text = "BBSaveOverwrite";
            FormClosing += bbsaveoverwriteform_FormClosing;
            Load += bbsaveoverwriteform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        public void bbsaveoverwriteform_Load(object sender, EventArgs e)
        {
            sourcefoldertextbox.Text = Properties.Settings.Default.SourceFolderSetting;
            destfoldertextbox.Text = Properties.Settings.Default.DestFolderSetting;
            archivefoldertextbox.Text = Properties.Settings.Default.ArchiveFolderSetting;
            dualsensecheckbox.Checked = Properties.Settings.Default.DualSenseHotkeysSetting;

            HotKeyManager.RegisterHotKey(Keys.S, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.S, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        private void bbsaveoverwriteform_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourceFolderSetting = sourcefoldertextbox.Text;
            Properties.Settings.Default.DestFolderSetting = destfoldertextbox.Text;
            Properties.Settings.Default.ArchiveFolderSetting = archivefoldertextbox.Text;
            Properties.Settings.Default.DualSenseHotkeysSetting = dualsensecheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion

        public TextBox sourcefoldertextbox;
        private Button sourcefolderbutton;
        private Button destfolderbutton;
        private Label desthotkeylabel;
        private Button overwritedestbutton;
        public TextBox destfoldertextbox;
        private Button overwritesourcebutton;
        private Label sourcehotkeylabel;
        private ToolTip toolTip1;
        private Label sourcefolderqlabel;
        private Label destfolderqlabel;
        private Label overwritedestfolderqlabel;
        private Label overwritesourcefolderqlabel;
        private Button loadedtestbutton;
        private Label label1;
        private Label label2;
        private Button backedtestbutton;
        private CheckBox dualsensecheckbox;
        private Label dualsensehkqlabel;
        private Label archivefolderqlabel;
        public TextBox archivefoldertextbox;
        private Button archivefolderbutton;
        private Button archivedtestbutton;
        private Label label3;
        private Label archivesaveqlabel;
        private Label archivehotkeylabel;
        private Button archivesavebutton;
    }
}
