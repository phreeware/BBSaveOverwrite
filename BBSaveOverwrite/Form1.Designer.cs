
using System.Linq.Expressions;

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
            loadmodifier1combobox = new ComboBox();
            loadmodifier2combobox = new ComboBox();
            loadmodifier3combobox = new ComboBox();
            loadhotkeysavebutton = new Button();
            backuphotkeysavebutton = new Button();
            backupmodifier3combobox = new ComboBox();
            backupmodifier2combobox = new ComboBox();
            backupmodifier1combobox = new ComboBox();
            archivehotkeysavebutton = new Button();
            archivemodifier3combobox = new ComboBox();
            archivemodifier2combobox = new ComboBox();
            archivemodifier1combobox = new ComboBox();
            SuspendLayout();
            // 
            // sourcefoldertextbox
            // 
            sourcefoldertextbox.Location = new Point(160, 34);
            sourcefoldertextbox.Margin = new Padding(1);
            sourcefoldertextbox.Name = "sourcefoldertextbox";
            sourcefoldertextbox.Size = new Size(480, 23);
            sourcefoldertextbox.TabIndex = 0;
            // 
            // sourcefolderbutton
            // 
            sourcefolderbutton.Location = new Point(22, 34);
            sourcefolderbutton.Margin = new Padding(1);
            sourcefolderbutton.Name = "sourcefolderbutton";
            sourcefolderbutton.Size = new Size(130, 23);
            sourcefolderbutton.TabIndex = 1;
            sourcefolderbutton.Text = "Save backup folder";
            sourcefolderbutton.UseVisualStyleBackColor = true;
            sourcefolderbutton.Click += sourcefolderbutton_Click;
            // 
            // destfolderbutton
            // 
            destfolderbutton.Location = new Point(22, 75);
            destfolderbutton.Margin = new Padding(1);
            destfolderbutton.Name = "destfolderbutton";
            destfolderbutton.Size = new Size(130, 23);
            destfolderbutton.TabIndex = 2;
            destfolderbutton.Text = "user/savedata folder";
            destfolderbutton.UseVisualStyleBackColor = true;
            destfolderbutton.Click += destfolderbutton_Click;
            // 
            // destfoldertextbox
            // 
            destfoldertextbox.Location = new Point(160, 75);
            destfoldertextbox.Margin = new Padding(1);
            destfoldertextbox.Name = "destfoldertextbox";
            destfoldertextbox.Size = new Size(480, 23);
            destfoldertextbox.TabIndex = 3;
            // 
            // desthotkeylabel
            // 
            desthotkeylabel.AutoSize = true;
            desthotkeylabel.BackColor = Color.Transparent;
            desthotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            desthotkeylabel.ForeColor = Color.White;
            desthotkeylabel.Location = new Point(160, 158);
            desthotkeylabel.Margin = new Padding(1, 0, 1, 0);
            desthotkeylabel.Name = "desthotkeylabel";
            desthotkeylabel.Size = new Size(51, 15);
            desthotkeylabel.TabIndex = 4;
            desthotkeylabel.Text = "Hotkey:";
            // 
            // overwritedestbutton
            // 
            overwritedestbutton.BackColor = Color.DarkTurquoise;
            overwritedestbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            overwritedestbutton.Location = new Point(22, 156);
            overwritedestbutton.Margin = new Padding(1);
            overwritedestbutton.Name = "overwritedestbutton";
            overwritedestbutton.Size = new Size(130, 22);
            overwritedestbutton.TabIndex = 5;
            overwritedestbutton.Text = "Load save";
            overwritedestbutton.UseVisualStyleBackColor = false;
            overwritedestbutton.Click += overwritedestbutton_Click;
            // 
            // overwritesourcebutton
            // 
            overwritesourcebutton.BackColor = Color.Coral;
            overwritesourcebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            overwritesourcebutton.Location = new Point(22, 196);
            overwritesourcebutton.Margin = new Padding(1);
            overwritesourcebutton.Name = "overwritesourcebutton";
            overwritesourcebutton.Size = new Size(130, 22);
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
            sourcehotkeylabel.Location = new Point(160, 198);
            sourcehotkeylabel.Margin = new Padding(1, 0, 1, 0);
            sourcehotkeylabel.Name = "sourcehotkeylabel";
            sourcehotkeylabel.Size = new Size(51, 15);
            sourcehotkeylabel.TabIndex = 7;
            sourcehotkeylabel.Text = "Hotkey:";
            // 
            // sourcefolderqlabel
            // 
            sourcefolderqlabel.AutoSize = true;
            sourcefolderqlabel.BackColor = Color.Red;
            sourcefolderqlabel.ForeColor = SystemColors.Info;
            sourcefolderqlabel.Location = new Point(649, 38);
            sourcefolderqlabel.Margin = new Padding(1, 0, 1, 0);
            sourcefolderqlabel.Name = "sourcefolderqlabel";
            sourcefolderqlabel.Size = new Size(12, 15);
            sourcefolderqlabel.TabIndex = 8;
            sourcefolderqlabel.Text = "?";
            toolTip1.SetToolTip(sourcefolderqlabel, "Select a '1' folder (name doesn't matter) from a shadPS4 'user/savedata' save");
            // 
            // destfolderqlabel
            // 
            destfolderqlabel.AutoSize = true;
            destfolderqlabel.BackColor = Color.Red;
            destfolderqlabel.ForeColor = SystemColors.Info;
            destfolderqlabel.Location = new Point(649, 78);
            destfolderqlabel.Margin = new Padding(1, 0, 1, 0);
            destfolderqlabel.Name = "destfolderqlabel";
            destfolderqlabel.Size = new Size(12, 15);
            destfolderqlabel.TabIndex = 9;
            destfolderqlabel.Text = "?";
            toolTip1.SetToolTip(destfolderqlabel, "Select your shadPS4 user/'savedata' destination folder");
            // 
            // overwritedestfolderqlabel
            // 
            overwritedestfolderqlabel.AutoSize = true;
            overwritedestfolderqlabel.BackColor = Color.Red;
            overwritedestfolderqlabel.ForeColor = SystemColors.Info;
            overwritedestfolderqlabel.Location = new Point(649, 158);
            overwritedestfolderqlabel.Margin = new Padding(1, 0, 1, 0);
            overwritedestfolderqlabel.Name = "overwritedestfolderqlabel";
            overwritedestfolderqlabel.Size = new Size(12, 15);
            overwritedestfolderqlabel.TabIndex = 10;
            overwritedestfolderqlabel.Text = "?";
            toolTip1.SetToolTip(overwritedestfolderqlabel, "Overwrites the Source Folder over the Destination Folder without asking.");
            // 
            // overwritesourcefolderqlabel
            // 
            overwritesourcefolderqlabel.AutoSize = true;
            overwritesourcefolderqlabel.BackColor = Color.Red;
            overwritesourcefolderqlabel.ForeColor = SystemColors.Info;
            overwritesourcefolderqlabel.Location = new Point(649, 198);
            overwritesourcefolderqlabel.Margin = new Padding(1, 0, 1, 0);
            overwritesourcefolderqlabel.Name = "overwritesourcefolderqlabel";
            overwritesourcefolderqlabel.Size = new Size(12, 15);
            overwritesourcefolderqlabel.TabIndex = 11;
            overwritesourcefolderqlabel.Text = "?";
            toolTip1.SetToolTip(overwritesourcefolderqlabel, "Reverse Overwrites the current shadPS4 savestate to the selected Source Folder.");
            // 
            // dualsensehkqlabel
            // 
            dualsensehkqlabel.AutoSize = true;
            dualsensehkqlabel.BackColor = Color.Red;
            dualsensehkqlabel.ForeColor = SystemColors.Info;
            dualsensehkqlabel.Location = new Point(649, 280);
            dualsensehkqlabel.Margin = new Padding(1, 0, 1, 0);
            dualsensehkqlabel.Name = "dualsensehkqlabel";
            dualsensehkqlabel.Size = new Size(12, 15);
            dualsensehkqlabel.TabIndex = 17;
            dualsensehkqlabel.Text = "?";
            toolTip1.SetToolTip(dualsensehkqlabel, "Enable PS5 DualSense controller hotkeys:\r\nCreate (Select) = Load save\r\nL3 + Option (Start) = Backup save\r\nR3 + Option (Start) = Archive backup");
            // 
            // archivefolderqlabel
            // 
            archivefolderqlabel.AutoSize = true;
            archivefolderqlabel.BackColor = Color.Red;
            archivefolderqlabel.ForeColor = SystemColors.Info;
            archivefolderqlabel.Location = new Point(649, 118);
            archivefolderqlabel.Margin = new Padding(1, 0, 1, 0);
            archivefolderqlabel.Name = "archivefolderqlabel";
            archivefolderqlabel.Size = new Size(12, 15);
            archivefolderqlabel.TabIndex = 20;
            archivefolderqlabel.Text = "?";
            toolTip1.SetToolTip(archivefolderqlabel, "Select an archive folder, to backup the current save folder to");
            // 
            // archivesaveqlabel
            // 
            archivesaveqlabel.AutoSize = true;
            archivesaveqlabel.BackColor = Color.Red;
            archivesaveqlabel.ForeColor = SystemColors.Info;
            archivesaveqlabel.Location = new Point(649, 238);
            archivesaveqlabel.Margin = new Padding(1, 0, 1, 0);
            archivesaveqlabel.Name = "archivesaveqlabel";
            archivesaveqlabel.Size = new Size(12, 15);
            archivesaveqlabel.TabIndex = 23;
            archivesaveqlabel.Text = "?";
            toolTip1.SetToolTip(archivesaveqlabel, "This is meant to \"archive\" a good save backup, that can't get overwritten by the tool");
            // 
            // loadedtestbutton
            // 
            loadedtestbutton.FlatStyle = FlatStyle.System;
            loadedtestbutton.Location = new Point(556, 158);
            loadedtestbutton.Margin = new Padding(1);
            loadedtestbutton.Name = "loadedtestbutton";
            loadedtestbutton.Size = new Size(18, 16);
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
            label1.Location = new Point(480, 158);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 13;
            label1.Text = "Soundtest:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(480, 198);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 14;
            label2.Text = "Soundtest:";
            // 
            // backedtestbutton
            // 
            backedtestbutton.FlatStyle = FlatStyle.System;
            backedtestbutton.Location = new Point(556, 198);
            backedtestbutton.Margin = new Padding(1);
            backedtestbutton.Name = "backedtestbutton";
            backedtestbutton.Size = new Size(18, 16);
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
            dualsensecheckbox.Location = new Point(480, 279);
            dualsensecheckbox.Margin = new Padding(1);
            dualsensecheckbox.Name = "dualsensecheckbox";
            dualsensecheckbox.Size = new Size(146, 19);
            dualsensecheckbox.TabIndex = 16;
            dualsensecheckbox.Text = "PS5 DualSense hotkeys";
            dualsensecheckbox.UseVisualStyleBackColor = false;
            // 
            // archivefoldertextbox
            // 
            archivefoldertextbox.Location = new Point(160, 114);
            archivefoldertextbox.Margin = new Padding(1);
            archivefoldertextbox.Name = "archivefoldertextbox";
            archivefoldertextbox.Size = new Size(480, 23);
            archivefoldertextbox.TabIndex = 19;
            // 
            // archivefolderbutton
            // 
            archivefolderbutton.Location = new Point(22, 114);
            archivefolderbutton.Margin = new Padding(1);
            archivefolderbutton.Name = "archivefolderbutton";
            archivefolderbutton.Size = new Size(130, 23);
            archivefolderbutton.TabIndex = 18;
            archivefolderbutton.Text = "Save archive folder";
            archivefolderbutton.UseVisualStyleBackColor = true;
            archivefolderbutton.Click += archivefolderbutton_Click;
            // 
            // archivedtestbutton
            // 
            archivedtestbutton.FlatStyle = FlatStyle.System;
            archivedtestbutton.Location = new Point(556, 238);
            archivedtestbutton.Margin = new Padding(1);
            archivedtestbutton.Name = "archivedtestbutton";
            archivedtestbutton.Size = new Size(18, 16);
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
            label3.Location = new Point(480, 238);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 24;
            label3.Text = "Soundtest:";
            // 
            // archivehotkeylabel
            // 
            archivehotkeylabel.AutoSize = true;
            archivehotkeylabel.BackColor = Color.Transparent;
            archivehotkeylabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            archivehotkeylabel.ForeColor = Color.White;
            archivehotkeylabel.Location = new Point(160, 238);
            archivehotkeylabel.Margin = new Padding(1, 0, 1, 0);
            archivehotkeylabel.Name = "archivehotkeylabel";
            archivehotkeylabel.Size = new Size(51, 15);
            archivehotkeylabel.TabIndex = 22;
            archivehotkeylabel.Text = "Hotkey:";
            // 
            // archivesavebutton
            // 
            archivesavebutton.BackColor = Color.Plum;
            archivesavebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            archivesavebutton.Location = new Point(22, 236);
            archivesavebutton.Margin = new Padding(1);
            archivesavebutton.Name = "archivesavebutton";
            archivesavebutton.Size = new Size(130, 22);
            archivesavebutton.TabIndex = 21;
            archivesavebutton.Text = "Archive backup";
            archivesavebutton.UseVisualStyleBackColor = false;
            archivesavebutton.Click += archivesavebutton_Click;
            // 
            // loadmodifier1combobox
            // 
            loadmodifier1combobox.FormattingEnabled = true;
            loadmodifier1combobox.Location = new Point(215, 156);
            loadmodifier1combobox.Name = "loadmodifier1combobox";
            loadmodifier1combobox.Size = new Size(61, 23);
            loadmodifier1combobox.TabIndex = 26;
            loadmodifier1combobox.SelectedIndexChanged += loadmodifier1combobox_SelectedIndexChanged;
            // 
            // loadmodifier2combobox
            // 
            loadmodifier2combobox.FormattingEnabled = true;
            loadmodifier2combobox.Location = new Point(282, 156);
            loadmodifier2combobox.Name = "loadmodifier2combobox";
            loadmodifier2combobox.Size = new Size(61, 23);
            loadmodifier2combobox.TabIndex = 27;
            loadmodifier2combobox.SelectedIndexChanged += loadmodifier2combobox_SelectedIndexChanged;
            // 
            // loadmodifier3combobox
            // 
            loadmodifier3combobox.FormattingEnabled = true;
            loadmodifier3combobox.Location = new Point(349, 156);
            loadmodifier3combobox.Name = "loadmodifier3combobox";
            loadmodifier3combobox.Size = new Size(61, 23);
            loadmodifier3combobox.TabIndex = 28;
            // 
            // loadhotkeysavebutton
            // 
            loadhotkeysavebutton.FlatStyle = FlatStyle.System;
            loadhotkeysavebutton.Location = new Point(416, 156);
            loadhotkeysavebutton.Name = "loadhotkeysavebutton";
            loadhotkeysavebutton.Size = new Size(23, 23);
            loadhotkeysavebutton.TabIndex = 29;
            loadhotkeysavebutton.Text = "OK";
            loadhotkeysavebutton.UseVisualStyleBackColor = true;
            loadhotkeysavebutton.Click += loadhotkeysavebutton_Click;
            // 
            // backuphotkeysavebutton
            // 
            backuphotkeysavebutton.FlatStyle = FlatStyle.System;
            backuphotkeysavebutton.Location = new Point(416, 196);
            backuphotkeysavebutton.Name = "backuphotkeysavebutton";
            backuphotkeysavebutton.Size = new Size(23, 23);
            backuphotkeysavebutton.TabIndex = 33;
            backuphotkeysavebutton.Text = "OK";
            backuphotkeysavebutton.UseVisualStyleBackColor = true;
            // 
            // backupmodifier3combobox
            // 
            backupmodifier3combobox.FormattingEnabled = true;
            backupmodifier3combobox.Location = new Point(349, 196);
            backupmodifier3combobox.Name = "backupmodifier3combobox";
            backupmodifier3combobox.Size = new Size(61, 23);
            backupmodifier3combobox.TabIndex = 32;
            // 
            // backupmodifier2combobox
            // 
            backupmodifier2combobox.FormattingEnabled = true;
            backupmodifier2combobox.Location = new Point(282, 196);
            backupmodifier2combobox.Name = "backupmodifier2combobox";
            backupmodifier2combobox.Size = new Size(61, 23);
            backupmodifier2combobox.TabIndex = 31;
            backupmodifier2combobox.SelectedIndexChanged += backupmodifier2combobox_SelectedIndexChanged;
            // 
            // backupmodifier1combobox
            // 
            backupmodifier1combobox.FormattingEnabled = true;
            backupmodifier1combobox.Location = new Point(215, 196);
            backupmodifier1combobox.Name = "backupmodifier1combobox";
            backupmodifier1combobox.Size = new Size(61, 23);
            backupmodifier1combobox.TabIndex = 30;
            backupmodifier1combobox.SelectedIndexChanged += backupmodifier1combobox_SelectedIndexChanged;
            // 
            // archivehotkeysavebutton
            // 
            archivehotkeysavebutton.FlatStyle = FlatStyle.System;
            archivehotkeysavebutton.Location = new Point(416, 236);
            archivehotkeysavebutton.Name = "archivehotkeysavebutton";
            archivehotkeysavebutton.Size = new Size(23, 23);
            archivehotkeysavebutton.TabIndex = 37;
            archivehotkeysavebutton.Text = "OK";
            archivehotkeysavebutton.UseVisualStyleBackColor = true;
            // 
            // archivemodifier3combobox
            // 
            archivemodifier3combobox.FormattingEnabled = true;
            archivemodifier3combobox.Location = new Point(349, 236);
            archivemodifier3combobox.Name = "archivemodifier3combobox";
            archivemodifier3combobox.Size = new Size(61, 23);
            archivemodifier3combobox.TabIndex = 36;
            // 
            // archivemodifier2combobox
            // 
            archivemodifier2combobox.FormattingEnabled = true;
            archivemodifier2combobox.Location = new Point(282, 236);
            archivemodifier2combobox.Name = "archivemodifier2combobox";
            archivemodifier2combobox.Size = new Size(61, 23);
            archivemodifier2combobox.TabIndex = 35;
            archivemodifier2combobox.SelectedIndexChanged += archivemodifier2combobox_SelectedIndexChanged;
            // 
            // archivemodifier1combobox
            // 
            archivemodifier1combobox.FormattingEnabled = true;
            archivemodifier1combobox.Location = new Point(215, 236);
            archivemodifier1combobox.Name = "archivemodifier1combobox";
            archivemodifier1combobox.Size = new Size(61, 23);
            archivemodifier1combobox.TabIndex = 34;
            archivemodifier1combobox.SelectedIndexChanged += archivemodifier1combobox_SelectedIndexChanged;
            // 
            // bbsaveoverwriteform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 316);
            Controls.Add(archivehotkeysavebutton);
            Controls.Add(archivemodifier3combobox);
            Controls.Add(archivemodifier2combobox);
            Controls.Add(archivemodifier1combobox);
            Controls.Add(backuphotkeysavebutton);
            Controls.Add(backupmodifier3combobox);
            Controls.Add(backupmodifier2combobox);
            Controls.Add(backupmodifier1combobox);
            Controls.Add(loadhotkeysavebutton);
            Controls.Add(loadmodifier3combobox);
            Controls.Add(loadmodifier2combobox);
            Controls.Add(loadmodifier1combobox);
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
            Margin = new Padding(1);
            MaximizeBox = false;
            Name = "bbsaveoverwriteform";
            Text = "BBSaveOverwrite";
            FormClosing += bbsaveoverwriteform_FormClosing;
            Load += bbsaveoverwriteform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        public void bbsaveoverwriteform_Load(object sender, EventArgs e)
        {
            PopulateHotKeyComboBoxes();

            sourcefoldertextbox.Text = Properties.Settings.Default.SourceFolderSetting;
            destfoldertextbox.Text = Properties.Settings.Default.DestFolderSetting;
            archivefoldertextbox.Text = Properties.Settings.Default.ArchiveFolderSetting;
            dualsensecheckbox.Checked = Properties.Settings.Default.DualSenseHotkeysSetting;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LoadHKMod1)) loadmodifier1combobox.SelectedItem = Enum.Parse(typeof(KeyModifiers), Properties.Settings.Default.LoadHKMod1);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LoadHKMod2)) loadmodifier2combobox.SelectedItem = Enum.Parse(typeof(KeyModifiers), Properties.Settings.Default.LoadHKMod2);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LoadHKMod3)) loadmodifier3combobox.SelectedItem = Enum.Parse(typeof(Keys), Properties.Settings.Default.LoadHKMod3);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackupHKMod1)) backupmodifier1combobox.SelectedItem = Enum.Parse(typeof(KeyModifiers), Properties.Settings.Default.BackupHKMod1);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackupHKMod2)) backupmodifier2combobox.SelectedItem = Enum.Parse(typeof(KeyModifiers), Properties.Settings.Default.BackupHKMod2);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackupHKMod3)) backupmodifier3combobox.SelectedItem = Enum.Parse(typeof(Keys), Properties.Settings.Default.BackupHKMod3);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ArchiveHKMod1)) archivemodifier1combobox.SelectedItem = Enum.Parse(typeof(KeyModifiers), Properties.Settings.Default.ArchiveHKMod1);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ArchiveHKMod2)) archivemodifier2combobox.SelectedItem = Enum.Parse(typeof(KeyModifiers), Properties.Settings.Default.ArchiveHKMod2);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ArchiveHKMod3)) archivemodifier3combobox.SelectedItem = Enum.Parse(typeof(Keys), Properties.Settings.Default.ArchiveHKMod3);
            //HotKeyManager.RegisterHotKey(Keys.S, KeyModifiers.Alt);
            //HotKeyManager.RegisterHotKey(Keys.S, KeyModifiers.Alt | KeyModifiers.Shift);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        private void bbsaveoverwriteform_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourceFolderSetting = sourcefoldertextbox.Text;
            Properties.Settings.Default.DestFolderSetting = destfoldertextbox.Text;
            Properties.Settings.Default.ArchiveFolderSetting = archivefoldertextbox.Text;
            Properties.Settings.Default.DualSenseHotkeysSetting = dualsensecheckbox.Checked;

            if (loadmodifier1combobox.SelectedItem != null) { Properties.Settings.Default.LoadHKMod1 = loadmodifier1combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.LoadHKMod1 = string.Empty; }
            if (loadmodifier2combobox.SelectedItem != null) { Properties.Settings.Default.LoadHKMod2 = loadmodifier2combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.LoadHKMod2 = string.Empty; }
            if (loadmodifier3combobox.SelectedItem != null) { Properties.Settings.Default.LoadHKMod3 = loadmodifier3combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.LoadHKMod3 = string.Empty; }
            if (backupmodifier1combobox.SelectedItem != null) { Properties.Settings.Default.BackupHKMod1 = backupmodifier1combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.BackupHKMod1 = string.Empty; }
            if (backupmodifier2combobox.SelectedItem != null) { Properties.Settings.Default.BackupHKMod2 = backupmodifier2combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.BackupHKMod2 = string.Empty; }
            if (backupmodifier3combobox.SelectedItem != null) { Properties.Settings.Default.BackupHKMod3 = backupmodifier3combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.BackupHKMod3 = string.Empty; }
            if (archivemodifier1combobox.SelectedItem != null) { Properties.Settings.Default.ArchiveHKMod1 = archivemodifier1combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.ArchiveHKMod1 = string.Empty; }
            if (archivemodifier2combobox.SelectedItem != null) { Properties.Settings.Default.ArchiveHKMod2 = archivemodifier2combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.ArchiveHKMod2 = string.Empty; }
            if (archivemodifier3combobox.SelectedItem != null) { Properties.Settings.Default.ArchiveHKMod3 = archivemodifier3combobox.SelectedItem.ToString(); } else { Properties.Settings.Default.ArchiveHKMod3 = string.Empty; }

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
        private ComboBox loadmodifier1combobox;
        private ComboBox loadmodifier2combobox;
        private ComboBox loadmodifier3combobox;
        private Button loadhotkeysavebutton;
        private Button backuphotkeysavebutton;
        private ComboBox backupmodifier3combobox;
        private ComboBox backupmodifier2combobox;
        private ComboBox backupmodifier1combobox;
        private Button archivehotkeysavebutton;
        private ComboBox archivemodifier3combobox;
        private ComboBox archivemodifier2combobox;
        private ComboBox archivemodifier1combobox;
    }
}
