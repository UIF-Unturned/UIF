namespace UIF
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchIDBtn = new System.Windows.Forms.Button();
            this.EnterIdLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.AllItemsBtn = new System.Windows.Forms.Button();
            this.SearchNameBtn = new System.Windows.Forms.Button();
            this.SelectFldrLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.LocalizationComboBox = new System.Windows.Forms.ComboBox();
            this.LocalizationLabel = new System.Windows.Forms.Label();
            this.LoadModsToRamBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.PictureBox();
            this.SelectedFldrsBtn = new System.Windows.Forms.Button();
            this.AboutGroupBox = new System.Windows.Forms.GroupBox();
            this.RUAuthorLabel = new System.Windows.Forms.Label();
            this.DiscordLink = new System.Windows.Forms.PictureBox();
            this.GitHubLink = new System.Windows.Forms.PictureBox();
            this.MainGroupBox.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBtn)).BeginInit();
            this.AboutGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(178, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TabStop = false;
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterNameLabel.Location = new System.Drawing.Point(6, 20);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(107, 16);
            this.EnterNameLabel.TabIndex = 6;
            this.EnterNameLabel.Text = "Enter item name:";
            this.EnterNameLabel.Click += new System.EventHandler(this.EnterNameLabel_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.SearchIDBtn);
            this.MainGroupBox.Controls.Add(this.EnterIdLabel);
            this.MainGroupBox.Controls.Add(this.IDBox);
            this.MainGroupBox.Controls.Add(this.AllItemsBtn);
            this.MainGroupBox.Controls.Add(this.SearchNameBtn);
            this.MainGroupBox.Controls.Add(this.NameTextBox);
            this.MainGroupBox.Controls.Add(this.EnterNameLabel);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(455, 103);
            this.MainGroupBox.TabIndex = 5;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "MAIN";
            // 
            // SearchIDBtn
            // 
            this.SearchIDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchIDBtn.Location = new System.Drawing.Point(365, 45);
            this.SearchIDBtn.Name = "SearchIDBtn";
            this.SearchIDBtn.Size = new System.Drawing.Size(84, 20);
            this.SearchIDBtn.TabIndex = 0;
            this.SearchIDBtn.TabStop = false;
            this.SearchIDBtn.Text = "Search";
            this.SearchIDBtn.UseVisualStyleBackColor = true;
            this.SearchIDBtn.Click += new System.EventHandler(this.SearchIDButton_Click);
            // 
            // EnterIdLabel
            // 
            this.EnterIdLabel.AutoSize = true;
            this.EnterIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterIdLabel.Location = new System.Drawing.Point(6, 45);
            this.EnterIdLabel.Name = "EnterIdLabel";
            this.EnterIdLabel.Size = new System.Drawing.Size(123, 16);
            this.EnterIdLabel.TabIndex = 1;
            this.EnterIdLabel.Text = "Or enter the item ID:";
            this.EnterIdLabel.Click += new System.EventHandler(this.EnterIdLabel_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(178, 45);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(180, 20);
            this.IDBox.TabIndex = 2;
            this.IDBox.TabStop = false;
            // 
            // AllItemsBtn
            // 
            this.AllItemsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllItemsBtn.Location = new System.Drawing.Point(6, 71);
            this.AllItemsBtn.Name = "AllItemsBtn";
            this.AllItemsBtn.Size = new System.Drawing.Size(443, 23);
            this.AllItemsBtn.TabIndex = 3;
            this.AllItemsBtn.TabStop = false;
            this.AllItemsBtn.Text = "View items by categories";
            this.AllItemsBtn.UseVisualStyleBackColor = true;
            this.AllItemsBtn.Click += new System.EventHandler(this.AllItemsBtn_Click);
            // 
            // SearchNameBtn
            // 
            this.SearchNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchNameBtn.Location = new System.Drawing.Point(365, 19);
            this.SearchNameBtn.Name = "SearchNameBtn";
            this.SearchNameBtn.Size = new System.Drawing.Size(84, 20);
            this.SearchNameBtn.TabIndex = 4;
            this.SearchNameBtn.TabStop = false;
            this.SearchNameBtn.Text = "Search";
            this.SearchNameBtn.UseVisualStyleBackColor = true;
            this.SearchNameBtn.Click += new System.EventHandler(this.SearchNameBtn_Click);
            // 
            // SelectFldrLabel
            // 
            this.SelectFldrLabel.AutoSize = true;
            this.SelectFldrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFldrLabel.Location = new System.Drawing.Point(6, 16);
            this.SelectFldrLabel.Name = "SelectFldrLabel";
            this.SelectFldrLabel.Size = new System.Drawing.Size(164, 16);
            this.SelectFldrLabel.TabIndex = 2;
            this.SelectFldrLabel.Text = "Selected folder with mods:";
            this.SelectFldrLabel.Click += new System.EventHandler(this.SelectFldrLabel_Click);
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyrightLabel.Location = new System.Drawing.Point(383, 47);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(72, 18);
            this.CopyrightLabel.TabIndex = 4;
            this.CopyrightLabel.Text = "(с) YMO4";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(175, 19);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(42, 20);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Ver. ";
            this.VersionLabel.Visible = false;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.LocalizationComboBox);
            this.SettingsGroupBox.Controls.Add(this.LocalizationLabel);
            this.SettingsGroupBox.Controls.Add(this.LoadModsToRamBtn);
            this.SettingsGroupBox.Controls.Add(this.InfoBtn);
            this.SettingsGroupBox.Controls.Add(this.SelectFldrLabel);
            this.SettingsGroupBox.Controls.Add(this.SelectedFldrsBtn);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 121);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(455, 73);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "SETTINGS";
            // 
            // LocalizationComboBox
            // 
            this.LocalizationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalizationComboBox.Location = new System.Drawing.Point(358, 42);
            this.LocalizationComboBox.Name = "LocalizationComboBox";
            this.LocalizationComboBox.Size = new System.Drawing.Size(92, 21);
            this.LocalizationComboBox.TabIndex = 9;
            this.LocalizationComboBox.TabStop = false;
            this.LocalizationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocalizationComboBox_SelectedIndexChanged);
            this.LocalizationComboBox.TextUpdate += new System.EventHandler(this.LocalizationComboBox_TextUpdate);
            // 
            // LocalizationLabel
            // 
            this.LocalizationLabel.AutoSize = true;
            this.LocalizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.LocalizationLabel.Location = new System.Drawing.Point(280, 45);
            this.LocalizationLabel.Name = "LocalizationLabel";
            this.LocalizationLabel.Size = new System.Drawing.Size(72, 16);
            this.LocalizationLabel.TabIndex = 8;
            this.LocalizationLabel.Text = "Language:";
            // 
            // LoadModsToRamBtn
            // 
            this.LoadModsToRamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadModsToRamBtn.Location = new System.Drawing.Point(6, 42);
            this.LoadModsToRamBtn.Name = "LoadModsToRamBtn";
            this.LoadModsToRamBtn.Size = new System.Drawing.Size(243, 23);
            this.LoadModsToRamBtn.TabIndex = 7;
            this.LoadModsToRamBtn.TabStop = false;
            this.LoadModsToRamBtn.Text = "Load mods";
            this.LoadModsToRamBtn.UseVisualStyleBackColor = true;
            this.LoadModsToRamBtn.Click += new System.EventHandler(this.LoadModsToRamBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Image = global::UIF.Properties.Resources.info_icon;
            this.InfoBtn.InitialImage = global::UIF.Properties.Resources.info_icon;
            this.InfoBtn.Location = new System.Drawing.Point(425, 13);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(24, 23);
            this.InfoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoBtn.TabIndex = 3;
            this.InfoBtn.TabStop = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // SelectedFldrsBtn
            // 
            this.SelectedFldrsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedFldrsBtn.Location = new System.Drawing.Point(200, 13);
            this.SelectedFldrsBtn.Name = "SelectedFldrsBtn";
            this.SelectedFldrsBtn.Size = new System.Drawing.Size(219, 23);
            this.SelectedFldrsBtn.TabIndex = 10;
            this.SelectedFldrsBtn.TabStop = false;
            this.SelectedFldrsBtn.Text = "Click!";
            this.SelectedFldrsBtn.UseVisualStyleBackColor = true;
            this.SelectedFldrsBtn.Click += new System.EventHandler(this.SelectedFldrsBtn_Click);
            // 
            // AboutGroupBox
            // 
            this.AboutGroupBox.Controls.Add(this.RUAuthorLabel);
            this.AboutGroupBox.Controls.Add(this.VersionLabel);
            this.AboutGroupBox.Controls.Add(this.CopyrightLabel);
            this.AboutGroupBox.Controls.Add(this.DiscordLink);
            this.AboutGroupBox.Controls.Add(this.GitHubLink);
            this.AboutGroupBox.Location = new System.Drawing.Point(12, 200);
            this.AboutGroupBox.Name = "AboutGroupBox";
            this.AboutGroupBox.Size = new System.Drawing.Size(455, 65);
            this.AboutGroupBox.TabIndex = 6;
            this.AboutGroupBox.TabStop = false;
            this.AboutGroupBox.Text = "About";
            // 
            // RUAuthorLabel
            // 
            this.RUAuthorLabel.AutoSize = true;
            this.RUAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RUAuthorLabel.Location = new System.Drawing.Point(248, 29);
            this.RUAuthorLabel.Name = "RUAuthorLabel";
            this.RUAuthorLabel.Size = new System.Drawing.Size(0, 18);
            this.RUAuthorLabel.TabIndex = 5;
            this.RUAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiscordLink
            // 
            this.DiscordLink.Image = global::UIF.Properties.Resources.discord_icon;
            this.DiscordLink.ImageLocation = "";
            this.DiscordLink.InitialImage = global::UIF.Properties.Resources.discord_icon;
            this.DiscordLink.Location = new System.Drawing.Point(6, 19);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(115, 36);
            this.DiscordLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscordLink.TabIndex = 1;
            this.DiscordLink.TabStop = false;
            this.DiscordLink.Click += new System.EventHandler(this.DiscordLink_Click);
            // 
            // GitHubLink
            // 
            this.GitHubLink.Image = global::UIF.Properties.Resources.github_icon;
            this.GitHubLink.ImageLocation = "";
            this.GitHubLink.InitialImage = global::UIF.Properties.Resources.github_icon;
            this.GitHubLink.Location = new System.Drawing.Point(127, 19);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(42, 36);
            this.GitHubLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHubLink.TabIndex = 2;
            this.GitHubLink.TabStop = false;
            this.GitHubLink.Click += new System.EventHandler(this.GitHubLink_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 275);
            this.Controls.Add(this.AboutGroupBox);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "UIF";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBtn)).EndInit();
            this.AboutGroupBox.ResumeLayout(false);
            this.AboutGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Button SearchNameBtn;
        private System.Windows.Forms.Button AllItemsBtn;
        private System.Windows.Forms.Label SelectFldrLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Button SearchIDBtn;
        private System.Windows.Forms.Label EnterIdLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.PictureBox GitHubLink;
        private System.Windows.Forms.PictureBox DiscordLink;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.PictureBox InfoBtn;
        private System.Windows.Forms.GroupBox AboutGroupBox;
        private System.Windows.Forms.Button LoadModsToRamBtn;
        private System.Windows.Forms.ComboBox LocalizationComboBox;
        private System.Windows.Forms.Label LocalizationLabel;
        private System.Windows.Forms.Label RUAuthorLabel;
        private System.Windows.Forms.Button SelectedFldrsBtn;
    }
}

