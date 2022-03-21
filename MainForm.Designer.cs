namespace Minecraft_Bootcode_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.TabWin = new System.Windows.Forms.TabPage();
            this.Generate_Win = new Guna.UI2.WinForms.Guna2Button();
            this.GroupOptional_Win = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ShowGUI_Win = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AutomaticReboot_Win = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GroupServerFile_Win = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ServerRAMTitle_Win = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ServerRAM_Win = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ServerFileName_Win = new Guna.UI2.WinForms.Guna2TextBox();
            this.TabListIcons = new System.Windows.Forms.ImageList(this.components);
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.AboutTitle = new System.Windows.Forms.Label();
            this.AboutText = new System.Windows.Forms.Label();
            this.HSeperator0 = new Guna.UI2.WinForms.Guna2Separator();
            this.MainTabControl.SuspendLayout();
            this.TabWin.SuspendLayout();
            this.GroupOptional_Win.SuspendLayout();
            this.GroupServerFile_Win.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerRAM_Win)).BeginInit();
            this.TabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainTabControl.Controls.Add(this.TabWin);
            this.MainTabControl.Controls.Add(this.TabInfo);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ImageList = this.TabListIcons;
            this.MainTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(744, 304);
            this.MainTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonHoverState.FillColor = System.Drawing.SystemColors.ControlDark;
            this.MainTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonIdleState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.MainTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.MainTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MainTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.MainTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.MainTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.MainTabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.TabMenuBackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // TabWin
            // 
            this.TabWin.BackColor = System.Drawing.SystemColors.Control;
            this.TabWin.Controls.Add(this.Generate_Win);
            this.TabWin.Controls.Add(this.GroupOptional_Win);
            this.TabWin.Controls.Add(this.GroupServerFile_Win);
            this.TabWin.ImageIndex = 0;
            this.TabWin.Location = new System.Drawing.Point(184, 4);
            this.TabWin.Margin = new System.Windows.Forms.Padding(4);
            this.TabWin.Name = "TabWin";
            this.TabWin.Padding = new System.Windows.Forms.Padding(4);
            this.TabWin.Size = new System.Drawing.Size(556, 296);
            this.TabWin.TabIndex = 0;
            this.TabWin.Text = "Windows";
            // 
            // Generate_Win
            // 
            this.Generate_Win.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate_Win.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate_Win.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Generate_Win.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Generate_Win.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Generate_Win.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Generate_Win.FillColor = System.Drawing.SystemColors.Highlight;
            this.Generate_Win.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Win.ForeColor = System.Drawing.Color.White;
            this.Generate_Win.Location = new System.Drawing.Point(60, 252);
            this.Generate_Win.Name = "Generate_Win";
            this.Generate_Win.Size = new System.Drawing.Size(436, 36);
            this.Generate_Win.TabIndex = 5;
            this.Generate_Win.Text = "Generieren && Speichern";
            this.Generate_Win.Click += new System.EventHandler(this.Generate_Win_Click);
            // 
            // GroupOptional_Win
            // 
            this.GroupOptional_Win.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupOptional_Win.Controls.Add(this.ShowGUI_Win);
            this.GroupOptional_Win.Controls.Add(this.AutomaticReboot_Win);
            this.GroupOptional_Win.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOptional_Win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupOptional_Win.Location = new System.Drawing.Point(8, 139);
            this.GroupOptional_Win.Margin = new System.Windows.Forms.Padding(4);
            this.GroupOptional_Win.Name = "GroupOptional_Win";
            this.GroupOptional_Win.Size = new System.Drawing.Size(539, 89);
            this.GroupOptional_Win.TabIndex = 4;
            this.GroupOptional_Win.Text = "Zusätzliche Funktionen";
            // 
            // ShowGUI_Win
            // 
            this.ShowGUI_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowGUI_Win.Animated = true;
            this.ShowGUI_Win.AutoSize = true;
            this.ShowGUI_Win.BackColor = System.Drawing.Color.Transparent;
            this.ShowGUI_Win.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ShowGUI_Win.CheckedState.BorderRadius = 0;
            this.ShowGUI_Win.CheckedState.BorderThickness = 0;
            this.ShowGUI_Win.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ShowGUI_Win.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowGUI_Win.Location = new System.Drawing.Point(222, 55);
            this.ShowGUI_Win.Name = "ShowGUI_Win";
            this.ShowGUI_Win.Size = new System.Drawing.Size(299, 21);
            this.ShowGUI_Win.TabIndex = 1;
            this.ShowGUI_Win.Text = "Zusätzlich Grafische Oberfläche anzeigen";
            this.ShowGUI_Win.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ShowGUI_Win.UncheckedState.BorderRadius = 0;
            this.ShowGUI_Win.UncheckedState.BorderThickness = 0;
            this.ShowGUI_Win.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ShowGUI_Win.UseVisualStyleBackColor = false;
            // 
            // AutomaticReboot_Win
            // 
            this.AutomaticReboot_Win.Animated = true;
            this.AutomaticReboot_Win.AutoSize = true;
            this.AutomaticReboot_Win.BackColor = System.Drawing.Color.Transparent;
            this.AutomaticReboot_Win.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.AutomaticReboot_Win.CheckedState.BorderRadius = 0;
            this.AutomaticReboot_Win.CheckedState.BorderThickness = 0;
            this.AutomaticReboot_Win.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.AutomaticReboot_Win.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutomaticReboot_Win.Location = new System.Drawing.Point(18, 55);
            this.AutomaticReboot_Win.Name = "AutomaticReboot_Win";
            this.AutomaticReboot_Win.Size = new System.Drawing.Size(180, 21);
            this.AutomaticReboot_Win.TabIndex = 0;
            this.AutomaticReboot_Win.Text = "Automatischer Neustart";
            this.AutomaticReboot_Win.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.AutomaticReboot_Win.UncheckedState.BorderRadius = 0;
            this.AutomaticReboot_Win.UncheckedState.BorderThickness = 0;
            this.AutomaticReboot_Win.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.AutomaticReboot_Win.UseVisualStyleBackColor = false;
            // 
            // GroupServerFile_Win
            // 
            this.GroupServerFile_Win.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupServerFile_Win.Controls.Add(this.ServerRAMTitle_Win);
            this.GroupServerFile_Win.Controls.Add(this.ServerRAM_Win);
            this.GroupServerFile_Win.Controls.Add(this.ServerFileName_Win);
            this.GroupServerFile_Win.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupServerFile_Win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupServerFile_Win.Location = new System.Drawing.Point(8, 9);
            this.GroupServerFile_Win.Margin = new System.Windows.Forms.Padding(4);
            this.GroupServerFile_Win.Name = "GroupServerFile_Win";
            this.GroupServerFile_Win.Size = new System.Drawing.Size(539, 122);
            this.GroupServerFile_Win.TabIndex = 0;
            this.GroupServerFile_Win.Text = "Server-Datei & Einstellungen";
            // 
            // ServerRAMTitle_Win
            // 
            this.ServerRAMTitle_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerRAMTitle_Win.BackColor = System.Drawing.Color.Transparent;
            this.ServerRAMTitle_Win.Location = new System.Drawing.Point(263, 70);
            this.ServerRAMTitle_Win.Name = "ServerRAMTitle_Win";
            this.ServerRAMTitle_Win.Size = new System.Drawing.Size(128, 15);
            this.ServerRAMTitle_Win.TabIndex = 3;
            this.ServerRAMTitle_Win.Text = "Max. Arbeitsspeicher (GB):";
            // 
            // ServerRAM_Win
            // 
            this.ServerRAM_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerRAM_Win.BackColor = System.Drawing.Color.Transparent;
            this.ServerRAM_Win.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerRAM_Win.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerRAM_Win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ServerRAM_Win.Location = new System.Drawing.Point(446, 55);
            this.ServerRAM_Win.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.ServerRAM_Win.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ServerRAM_Win.Name = "ServerRAM_Win";
            this.ServerRAM_Win.Size = new System.Drawing.Size(73, 48);
            this.ServerRAM_Win.TabIndex = 2;
            this.ServerRAM_Win.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ServerRAM_Win.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ServerFileName_Win
            // 
            this.ServerFileName_Win.Animated = true;
            this.ServerFileName_Win.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerFileName_Win.DefaultText = "";
            this.ServerFileName_Win.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerFileName_Win.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerFileName_Win.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerFileName_Win.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerFileName_Win.FocusedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ServerFileName_Win.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerFileName_Win.HoverState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ServerFileName_Win.Location = new System.Drawing.Point(16, 55);
            this.ServerFileName_Win.MaxLength = 100;
            this.ServerFileName_Win.Name = "ServerFileName_Win";
            this.ServerFileName_Win.PasswordChar = '\0';
            this.ServerFileName_Win.PlaceholderText = "Dateiname";
            this.ServerFileName_Win.SelectedText = "";
            this.ServerFileName_Win.Size = new System.Drawing.Size(222, 48);
            this.ServerFileName_Win.TabIndex = 1;
            this.ServerFileName_Win.WordWrap = false;
            // 
            // TabListIcons
            // 
            this.TabListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabListIcons.ImageStream")));
            this.TabListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TabListIcons.Images.SetKeyName(0, "win_logo.png");
            this.TabListIcons.Images.SetKeyName(1, "about.png");
            // 
            // TabInfo
            // 
            this.TabInfo.BackColor = System.Drawing.SystemColors.Control;
            this.TabInfo.Controls.Add(this.HSeperator0);
            this.TabInfo.Controls.Add(this.AboutText);
            this.TabInfo.Controls.Add(this.AboutTitle);
            this.TabInfo.ImageIndex = 1;
            this.TabInfo.Location = new System.Drawing.Point(184, 4);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfo.Size = new System.Drawing.Size(556, 296);
            this.TabInfo.TabIndex = 1;
            this.TabInfo.Text = "Über";
            // 
            // AboutTitle
            // 
            this.AboutTitle.AutoSize = true;
            this.AboutTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTitle.Location = new System.Drawing.Point(6, 5);
            this.AboutTitle.Name = "AboutTitle";
            this.AboutTitle.Size = new System.Drawing.Size(241, 24);
            this.AboutTitle.TabIndex = 0;
            this.AboutTitle.Text = "Über dieses Programm";
            // 
            // AboutText
            // 
            this.AboutText.AutoSize = true;
            this.AboutText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutText.Location = new System.Drawing.Point(7, 56);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(415, 126);
            this.AboutText.TabIndex = 0;
            this.AboutText.Text = "Version: 1.0.2.10\r\nSprache: Deutsch (German)\r\n\r\nCopyright\r\nEntwickler: xcFr3sh\r\nF" +
    "rameworks: Winforms - Microsoft && Guna.UI2 - Sobatdata\r\nIcons: Icons8.com";
            // 
            // HSeperator0
            // 
            this.HSeperator0.Location = new System.Drawing.Point(6, 32);
            this.HSeperator0.Name = "HSeperator0";
            this.HSeperator0.Size = new System.Drawing.Size(260, 10);
            this.HSeperator0.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 304);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(914, 399);
            this.MinimumSize = new System.Drawing.Size(760, 343);
            this.Name = "MainForm";
            this.Text = "Minecraft Bootcode Generator";
            this.MainTabControl.ResumeLayout(false);
            this.TabWin.ResumeLayout(false);
            this.GroupOptional_Win.ResumeLayout(false);
            this.GroupOptional_Win.PerformLayout();
            this.GroupServerFile_Win.ResumeLayout(false);
            this.GroupServerFile_Win.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerRAM_Win)).EndInit();
            this.TabInfo.ResumeLayout(false);
            this.TabInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl MainTabControl;
        private System.Windows.Forms.TabPage TabWin;
        private Guna.UI2.WinForms.Guna2GroupBox GroupServerFile_Win;
        private Guna.UI2.WinForms.Guna2TextBox ServerFileName_Win;
        private Guna.UI2.WinForms.Guna2NumericUpDown ServerRAM_Win;
        private Guna.UI2.WinForms.Guna2HtmlLabel ServerRAMTitle_Win;
        private Guna.UI2.WinForms.Guna2GroupBox GroupOptional_Win;
        private Guna.UI2.WinForms.Guna2CheckBox AutomaticReboot_Win;
        private Guna.UI2.WinForms.Guna2CheckBox ShowGUI_Win;
        private Guna.UI2.WinForms.Guna2Button Generate_Win;
        private System.Windows.Forms.ImageList TabListIcons;
        private System.Windows.Forms.TabPage TabInfo;
        private System.Windows.Forms.Label AboutTitle;
        private System.Windows.Forms.Label AboutText;
        private Guna.UI2.WinForms.Guna2Separator HSeperator0;
    }
}

