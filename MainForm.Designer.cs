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
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.AboutText = new System.Windows.Forms.Label();
            this.AboutTitle = new System.Windows.Forms.Label();
            this.TabListIcons = new System.Windows.Forms.ImageList(this.components);
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.WindowBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainTabControl.SuspendLayout();
            this.TabWin.SuspendLayout();
            this.GroupOptional_Win.SuspendLayout();
            this.GroupServerFile_Win.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerRAM_Win)).BeginInit();
            this.TabInfo.SuspendLayout();
            this.WindowBar.SuspendLayout();
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
            this.MainTabControl.Location = new System.Drawing.Point(0, 26);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(760, 317);
            this.MainTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.MainTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.MainTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.MainTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.MainTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MainTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.MainTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.MainTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.Empty;
            this.MainTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.MainTabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            // 
            // TabWin
            // 
            this.TabWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabWin.Controls.Add(this.Generate_Win);
            this.TabWin.Controls.Add(this.GroupOptional_Win);
            this.TabWin.Controls.Add(this.GroupServerFile_Win);
            this.TabWin.ImageIndex = 0;
            this.TabWin.Location = new System.Drawing.Point(184, 4);
            this.TabWin.Margin = new System.Windows.Forms.Padding(4);
            this.TabWin.Name = "TabWin";
            this.TabWin.Padding = new System.Windows.Forms.Padding(4);
            this.TabWin.Size = new System.Drawing.Size(572, 309);
            this.TabWin.TabIndex = 0;
            this.TabWin.Text = "Windows";
            // 
            // Generate_Win
            // 
            this.Generate_Win.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate_Win.Animated = true;
            this.Generate_Win.BorderRadius = 5;
            this.Generate_Win.Cursor = System.Windows.Forms.Cursors.Default;
            this.Generate_Win.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Generate_Win.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Generate_Win.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Generate_Win.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Generate_Win.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.Generate_Win.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Win.ForeColor = System.Drawing.Color.White;
            this.Generate_Win.Location = new System.Drawing.Point(60, 265);
            this.Generate_Win.Name = "Generate_Win";
            this.Generate_Win.Size = new System.Drawing.Size(452, 36);
            this.Generate_Win.TabIndex = 5;
            this.Generate_Win.Text = "Generieren && Speichern";
            this.Generate_Win.Click += new System.EventHandler(this.Generate_Win_Click);
            // 
            // GroupOptional_Win
            // 
            this.GroupOptional_Win.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupOptional_Win.BorderColor = System.Drawing.Color.Empty;
            this.GroupOptional_Win.Controls.Add(this.ShowGUI_Win);
            this.GroupOptional_Win.Controls.Add(this.AutomaticReboot_Win);
            this.GroupOptional_Win.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.GroupOptional_Win.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.GroupOptional_Win.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupOptional_Win.ForeColor = System.Drawing.Color.White;
            this.GroupOptional_Win.Location = new System.Drawing.Point(8, 129);
            this.GroupOptional_Win.Margin = new System.Windows.Forms.Padding(4);
            this.GroupOptional_Win.Name = "GroupOptional_Win";
            this.GroupOptional_Win.Size = new System.Drawing.Size(555, 89);
            this.GroupOptional_Win.TabIndex = 4;
            this.GroupOptional_Win.Text = "Zusätzliche Funktionen";
            // 
            // ShowGUI_Win
            // 
            this.ShowGUI_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowGUI_Win.Animated = true;
            this.ShowGUI_Win.AutoSize = true;
            this.ShowGUI_Win.BackColor = System.Drawing.Color.Transparent;
            this.ShowGUI_Win.CheckedState.BorderRadius = 0;
            this.ShowGUI_Win.CheckedState.BorderThickness = 0;
            this.ShowGUI_Win.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.ShowGUI_Win.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGUI_Win.Location = new System.Drawing.Point(272, 55);
            this.ShowGUI_Win.Name = "ShowGUI_Win";
            this.ShowGUI_Win.Size = new System.Drawing.Size(265, 21);
            this.ShowGUI_Win.TabIndex = 1;
            this.ShowGUI_Win.Text = "Zusätzlich Grafische Oberfläche anzeigen";
            this.ShowGUI_Win.UncheckedState.BorderRadius = 0;
            this.ShowGUI_Win.UncheckedState.BorderThickness = 0;
            this.ShowGUI_Win.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ShowGUI_Win.UseVisualStyleBackColor = false;
            // 
            // AutomaticReboot_Win
            // 
            this.AutomaticReboot_Win.Animated = true;
            this.AutomaticReboot_Win.AutoSize = true;
            this.AutomaticReboot_Win.BackColor = System.Drawing.Color.Transparent;
            this.AutomaticReboot_Win.Checked = true;
            this.AutomaticReboot_Win.CheckedState.BorderRadius = 0;
            this.AutomaticReboot_Win.CheckedState.BorderThickness = 0;
            this.AutomaticReboot_Win.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.AutomaticReboot_Win.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutomaticReboot_Win.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutomaticReboot_Win.Location = new System.Drawing.Point(18, 55);
            this.AutomaticReboot_Win.Name = "AutomaticReboot_Win";
            this.AutomaticReboot_Win.Size = new System.Drawing.Size(164, 21);
            this.AutomaticReboot_Win.TabIndex = 0;
            this.AutomaticReboot_Win.Text = "Automatischer Neustart";
            this.AutomaticReboot_Win.UncheckedState.BorderRadius = 0;
            this.AutomaticReboot_Win.UncheckedState.BorderThickness = 0;
            this.AutomaticReboot_Win.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.AutomaticReboot_Win.UseVisualStyleBackColor = false;
            // 
            // GroupServerFile_Win
            // 
            this.GroupServerFile_Win.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupServerFile_Win.BorderColor = System.Drawing.Color.Empty;
            this.GroupServerFile_Win.Controls.Add(this.ServerRAMTitle_Win);
            this.GroupServerFile_Win.Controls.Add(this.ServerRAM_Win);
            this.GroupServerFile_Win.Controls.Add(this.ServerFileName_Win);
            this.GroupServerFile_Win.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.GroupServerFile_Win.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.GroupServerFile_Win.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupServerFile_Win.ForeColor = System.Drawing.Color.White;
            this.GroupServerFile_Win.Location = new System.Drawing.Point(8, 21);
            this.GroupServerFile_Win.Margin = new System.Windows.Forms.Padding(4);
            this.GroupServerFile_Win.Name = "GroupServerFile_Win";
            this.GroupServerFile_Win.Size = new System.Drawing.Size(555, 87);
            this.GroupServerFile_Win.TabIndex = 0;
            this.GroupServerFile_Win.Text = "Server-Datei & Einstellungen";
            // 
            // ServerRAMTitle_Win
            // 
            this.ServerRAMTitle_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerRAMTitle_Win.BackColor = System.Drawing.Color.Transparent;
            this.ServerRAMTitle_Win.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerRAMTitle_Win.ForeColor = System.Drawing.Color.White;
            this.ServerRAMTitle_Win.Location = new System.Drawing.Point(272, 52);
            this.ServerRAMTitle_Win.Name = "ServerRAMTitle_Win";
            this.ServerRAMTitle_Win.Size = new System.Drawing.Size(176, 22);
            this.ServerRAMTitle_Win.TabIndex = 3;
            this.ServerRAMTitle_Win.Text = "Max. Arbeitsspeicher (GB):";
            // 
            // ServerRAM_Win
            // 
            this.ServerRAM_Win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerRAM_Win.BackColor = System.Drawing.Color.Transparent;
            this.ServerRAM_Win.BorderColor = System.Drawing.Color.Empty;
            this.ServerRAM_Win.BorderRadius = 5;
            this.ServerRAM_Win.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerRAM_Win.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ServerRAM_Win.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerRAM_Win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ServerRAM_Win.Location = new System.Drawing.Point(464, 48);
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
            this.ServerRAM_Win.Size = new System.Drawing.Size(73, 30);
            this.ServerRAM_Win.TabIndex = 2;
            this.ServerRAM_Win.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.ServerRAM_Win.UpDownButtonForeColor = System.Drawing.Color.White;
            this.ServerRAM_Win.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ServerFileName_Win
            // 
            this.ServerFileName_Win.Animated = true;
            this.ServerFileName_Win.BackColor = System.Drawing.Color.Transparent;
            this.ServerFileName_Win.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ServerFileName_Win.BorderRadius = 5;
            this.ServerFileName_Win.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerFileName_Win.DefaultText = "";
            this.ServerFileName_Win.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerFileName_Win.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerFileName_Win.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerFileName_Win.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerFileName_Win.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ServerFileName_Win.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.ServerFileName_Win.FocusedState.ForeColor = System.Drawing.Color.White;
            this.ServerFileName_Win.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerFileName_Win.ForeColor = System.Drawing.Color.Black;
            this.ServerFileName_Win.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(174)))));
            this.ServerFileName_Win.Location = new System.Drawing.Point(18, 48);
            this.ServerFileName_Win.MaxLength = 100;
            this.ServerFileName_Win.Name = "ServerFileName_Win";
            this.ServerFileName_Win.PasswordChar = '\0';
            this.ServerFileName_Win.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ServerFileName_Win.PlaceholderText = "Server-Dateiname";
            this.ServerFileName_Win.SelectedText = "";
            this.ServerFileName_Win.Size = new System.Drawing.Size(189, 30);
            this.ServerFileName_Win.TabIndex = 1;
            this.ServerFileName_Win.WordWrap = false;
            // 
            // TabInfo
            // 
            this.TabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabInfo.Controls.Add(this.AboutText);
            this.TabInfo.Controls.Add(this.AboutTitle);
            this.TabInfo.ImageIndex = 1;
            this.TabInfo.Location = new System.Drawing.Point(184, 4);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabInfo.Size = new System.Drawing.Size(572, 309);
            this.TabInfo.TabIndex = 1;
            this.TabInfo.Text = "Über";
            // 
            // AboutText
            // 
            this.AboutText.AutoSize = true;
            this.AboutText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AboutText.Location = new System.Drawing.Point(7, 104);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(353, 119);
            this.AboutText.TabIndex = 0;
            this.AboutText.Text = "Version: 1.0.2.10\r\nSprache: Deutsch (German)\r\n\r\nCopyright\r\nEntwickler: xcFr3sh\r\nF" +
    "rameworks: Winforms - Microsoft && Guna.UI2 - Sobatdata\r\nIcons: Icons8.com";
            // 
            // AboutTitle
            // 
            this.AboutTitle.AutoSize = true;
            this.AboutTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTitle.ForeColor = System.Drawing.Color.White;
            this.AboutTitle.Location = new System.Drawing.Point(6, 73);
            this.AboutTitle.Name = "AboutTitle";
            this.AboutTitle.Size = new System.Drawing.Size(170, 21);
            this.AboutTitle.TabIndex = 0;
            this.AboutTitle.Text = "Über dieses Programm";
            // 
            // TabListIcons
            // 
            this.TabListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabListIcons.ImageStream")));
            this.TabListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TabListIcons.Images.SetKeyName(0, "win_logo.png");
            this.TabListIcons.Images.SetKeyName(1, "about.png");
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 5;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // WindowBar
            // 
            this.WindowBar.BackColor = System.Drawing.Color.Transparent;
            this.WindowBar.Controls.Add(this.ExitButton);
            this.WindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.WindowBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.WindowBar.Location = new System.Drawing.Point(0, 0);
            this.WindowBar.Name = "WindowBar";
            this.WindowBar.Size = new System.Drawing.Size(760, 26);
            this.WindowBar.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Animated = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.Empty;
            this.ExitButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(729, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseTransparentBackground = true;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.WindowBar;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 343);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.WindowBar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 343);
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
            this.WindowBar.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2GradientPanel WindowBar;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
    }
}

