
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
            loadedtestbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            backedtestbutton = new Button();
            dualsensecheckbox = new CheckBox();
            SuspendLayout();
            // 
            // sourcefoldertextbox
            // 
            sourcefoldertextbox.Location = new Point(456, 198);
            sourcefoldertextbox.Name = "sourcefoldertextbox";
            sourcefoldertextbox.Size = new Size(1365, 55);
            sourcefoldertextbox.TabIndex = 0;
            // 
            // sourcefolderbutton
            // 
            sourcefolderbutton.Location = new Point(123, 191);
            sourcefolderbutton.Name = "sourcefolderbutton";
            sourcefolderbutton.Size = new Size(312, 69);
            sourcefolderbutton.TabIndex = 1;
            sourcefolderbutton.Text = "Source Folder";
            sourcefolderbutton.UseVisualStyleBackColor = true;
            sourcefolderbutton.Click += sourcefolderbutton_Click;
            // 
            // destfolderbutton
            // 
            destfolderbutton.Location = new Point(123, 322);
            destfolderbutton.Name = "destfolderbutton";
            destfolderbutton.Size = new Size(312, 69);
            destfolderbutton.TabIndex = 2;
            destfolderbutton.Text = "Dest. Folder";
            destfolderbutton.UseVisualStyleBackColor = true;
            destfolderbutton.Click += destfolderbutton_Click;
            // 
            // destfoldertextbox
            // 
            destfoldertextbox.Location = new Point(456, 329);
            destfoldertextbox.Name = "destfoldertextbox";
            destfoldertextbox.Size = new Size(1365, 55);
            destfoldertextbox.TabIndex = 3;
            // 
            // desthotkeylabel
            // 
            desthotkeylabel.AutoSize = true;
            desthotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            desthotkeylabel.Location = new Point(606, 655);
            desthotkeylabel.Name = "desthotkeylabel";
            desthotkeylabel.Size = new Size(268, 48);
            desthotkeylabel.TabIndex = 4;
            desthotkeylabel.Text = "Hotkey: ALT+S";
            // 
            // overwritedestbutton
            // 
            overwritedestbutton.Location = new Point(123, 645);
            overwritedestbutton.Name = "overwritedestbutton";
            overwritedestbutton.Size = new Size(435, 69);
            overwritedestbutton.TabIndex = 5;
            overwritedestbutton.Text = "Overwrite Dest. Folder";
            overwritedestbutton.UseVisualStyleBackColor = true;
            overwritedestbutton.Click += overwritedestbutton_Click;
            // 
            // overwritesourcebutton
            // 
            overwritesourcebutton.Location = new Point(123, 775);
            overwritesourcebutton.Name = "overwritesourcebutton";
            overwritesourcebutton.Size = new Size(435, 69);
            overwritesourcebutton.TabIndex = 6;
            overwritesourcebutton.Text = "Overwrite Source Folder";
            overwritesourcebutton.UseVisualStyleBackColor = true;
            overwritesourcebutton.Click += overwritesourcebutton_Click;
            // 
            // sourcehotkeylabel
            // 
            sourcehotkeylabel.AutoSize = true;
            sourcehotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sourcehotkeylabel.Location = new Point(606, 785);
            sourcehotkeylabel.Name = "sourcehotkeylabel";
            sourcehotkeylabel.Size = new Size(392, 48);
            sourcehotkeylabel.TabIndex = 7;
            sourcehotkeylabel.Text = "Hotkey: ALT+SHIFT+S";
            // 
            // sourcefolderqlabel
            // 
            sourcefolderqlabel.AutoSize = true;
            sourcefolderqlabel.BackColor = Color.Red;
            sourcefolderqlabel.ForeColor = SystemColors.Info;
            sourcefolderqlabel.Location = new Point(1854, 201);
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
            destfolderqlabel.Location = new Point(1854, 332);
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
            overwritedestfolderqlabel.Location = new Point(1854, 655);
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
            overwritesourcefolderqlabel.Location = new Point(1854, 785);
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
            toolTip1.SetToolTip(dualsensehkqlabel, "Enable PS5 DualSense controller hotkeys");
            // 
            // loadedtestbutton
            // 
            loadedtestbutton.Location = new Point(1371, 654);
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
            label1.Location = new Point(1154, 655);
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
            label2.Location = new Point(1154, 785);
            label2.Name = "label2";
            label2.Size = new Size(201, 48);
            label2.TabIndex = 14;
            label2.Text = "Soundtest:";
            // 
            // backedtestbutton
            // 
            backedtestbutton.Location = new Point(1371, 783);
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
            // bbsaveoverwriteform
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1943, 1012);
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
            dualsensecheckbox.Checked = Properties.Settings.Default.DualSenseHotkeysSetting;

            HotKeyManager.RegisterHotKey(Keys.S, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.S, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        private void bbsaveoverwriteform_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourceFolderSetting = sourcefoldertextbox.Text;
            Properties.Settings.Default.DestFolderSetting = destfoldertextbox.Text;
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
    }
}
