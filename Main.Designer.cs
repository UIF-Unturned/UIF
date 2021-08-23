﻿namespace UIF
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
            this.MarkFolderAsDefaultBtn = new System.Windows.Forms.PictureBox();
            this.LocalizationComboBox = new System.Windows.Forms.ComboBox();
            this.LocalizationLabel = new System.Windows.Forms.Label();
            this.LoadModsToRamBtn = new System.Windows.Forms.Button();
            this.OpenFldrBtn = new System.Windows.Forms.PictureBox();
            this.MinusFldrBtn = new System.Windows.Forms.PictureBox();
            this.PlusFldrBtn = new System.Windows.Forms.PictureBox();
            this.FldrComboBox = new System.Windows.Forms.ComboBox();
            this.InfoBtn = new System.Windows.Forms.PictureBox();
            this.AbouGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscordLink = new System.Windows.Forms.PictureBox();
            this.GitHubLink = new System.Windows.Forms.PictureBox();
            this.MainGroupBox.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkFolderAsDefaultBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFldrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusFldrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusFldrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBtn)).BeginInit();
            this.AbouGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLink)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(152, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 20);
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
            this.IDBox.Location = new System.Drawing.Point(152, 45);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(207, 20);
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
            this.SettingsGroupBox.Controls.Add(this.MarkFolderAsDefaultBtn);
            this.SettingsGroupBox.Controls.Add(this.LocalizationComboBox);
            this.SettingsGroupBox.Controls.Add(this.LocalizationLabel);
            this.SettingsGroupBox.Controls.Add(this.LoadModsToRamBtn);
            this.SettingsGroupBox.Controls.Add(this.OpenFldrBtn);
            this.SettingsGroupBox.Controls.Add(this.MinusFldrBtn);
            this.SettingsGroupBox.Controls.Add(this.PlusFldrBtn);
            this.SettingsGroupBox.Controls.Add(this.FldrComboBox);
            this.SettingsGroupBox.Controls.Add(this.InfoBtn);
            this.SettingsGroupBox.Controls.Add(this.SelectFldrLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 121);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(455, 100);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "SETTINGS";
            // 
            // MarkFolderAsDefaultBtn
            // 
            this.MarkFolderAsDefaultBtn.Image = ((System.Drawing.Image)(resources.GetObject("MarkFolderAsDefaultBtn.Image")));
            this.MarkFolderAsDefaultBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("MarkFolderAsDefaultBtn.InitialImage")));
            this.MarkFolderAsDefaultBtn.Location = new System.Drawing.Point(395, 13);
            this.MarkFolderAsDefaultBtn.Name = "MarkFolderAsDefaultBtn";
            this.MarkFolderAsDefaultBtn.Size = new System.Drawing.Size(24, 23);
            this.MarkFolderAsDefaultBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MarkFolderAsDefaultBtn.TabIndex = 11;
            this.MarkFolderAsDefaultBtn.TabStop = false;
            this.MarkFolderAsDefaultBtn.Click += new System.EventHandler(this.MarkFolderAsDefaultBtn_Click);
            // 
            // LocalizationComboBox
            // 
            this.LocalizationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalizationComboBox.Location = new System.Drawing.Point(343, 69);
            this.LocalizationComboBox.Name = "LocalizationComboBox";
            this.LocalizationComboBox.Size = new System.Drawing.Size(106, 21);
            this.LocalizationComboBox.TabIndex = 9;
            this.LocalizationComboBox.TabStop = false;
            this.LocalizationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocalizationComboBox_SelectedIndexChanged);
            this.LocalizationComboBox.TextUpdate += new System.EventHandler(this.LocalizationComboBox_TextUpdate);
            // 
            // LocalizationLabel
            // 
            this.LocalizationLabel.AutoSize = true;
            this.LocalizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.LocalizationLabel.Location = new System.Drawing.Point(255, 72);
            this.LocalizationLabel.Name = "LocalizationLabel";
            this.LocalizationLabel.Size = new System.Drawing.Size(82, 16);
            this.LocalizationLabel.TabIndex = 8;
            this.LocalizationLabel.Text = "Localization:";
            // 
            // LoadModsToRamBtn
            // 
            this.LoadModsToRamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadModsToRamBtn.Location = new System.Drawing.Point(6, 69);
            this.LoadModsToRamBtn.Name = "LoadModsToRamBtn";
            this.LoadModsToRamBtn.Size = new System.Drawing.Size(243, 23);
            this.LoadModsToRamBtn.TabIndex = 7;
            this.LoadModsToRamBtn.TabStop = false;
            this.LoadModsToRamBtn.Text = "Load mods";
            this.LoadModsToRamBtn.UseVisualStyleBackColor = true;
            this.LoadModsToRamBtn.Click += new System.EventHandler(this.LoadModsToRamBtn_Click);
            // 
            // OpenFldrBtn
            // 
            this.OpenFldrBtn.Image = global::UIF.Properties.Resources.folder_icon;
            this.OpenFldrBtn.InitialImage = global::UIF.Properties.Resources.folder_icon;
            this.OpenFldrBtn.Location = new System.Drawing.Point(425, 13);
            this.OpenFldrBtn.Name = "OpenFldrBtn";
            this.OpenFldrBtn.Size = new System.Drawing.Size(24, 23);
            this.OpenFldrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFldrBtn.TabIndex = 6;
            this.OpenFldrBtn.TabStop = false;
            this.OpenFldrBtn.Click += new System.EventHandler(this.OpenFldrBtn_Click);
            // 
            // MinusFldrBtn
            // 
            this.MinusFldrBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinusFldrBtn.Image")));
            this.MinusFldrBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("MinusFldrBtn.InitialImage")));
            this.MinusFldrBtn.Location = new System.Drawing.Point(365, 13);
            this.MinusFldrBtn.Name = "MinusFldrBtn";
            this.MinusFldrBtn.Size = new System.Drawing.Size(24, 23);
            this.MinusFldrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinusFldrBtn.TabIndex = 5;
            this.MinusFldrBtn.TabStop = false;
            this.MinusFldrBtn.Click += new System.EventHandler(this.MinusFldrBtn_Click);
            // 
            // PlusFldrBtn
            // 
            this.PlusFldrBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlusFldrBtn.Image")));
            this.PlusFldrBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("PlusFldrBtn.InitialImage")));
            this.PlusFldrBtn.Location = new System.Drawing.Point(335, 13);
            this.PlusFldrBtn.Name = "PlusFldrBtn";
            this.PlusFldrBtn.Size = new System.Drawing.Size(24, 23);
            this.PlusFldrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlusFldrBtn.TabIndex = 4;
            this.PlusFldrBtn.TabStop = false;
            this.PlusFldrBtn.Click += new System.EventHandler(this.PlusFldrBtn_Click);
            // 
            // FldrComboBox
            // 
            this.FldrComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FldrComboBox.Location = new System.Drawing.Point(6, 42);
            this.FldrComboBox.Name = "FldrComboBox";
            this.FldrComboBox.Size = new System.Drawing.Size(443, 21);
            this.FldrComboBox.TabIndex = 0;
            this.FldrComboBox.TabStop = false;
            this.FldrComboBox.SelectedIndexChanged += new System.EventHandler(this.FldrComboBox_SelectedIndexChanged);
            this.FldrComboBox.TextUpdate += new System.EventHandler(this.FldrComboBox_TextUpdate);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Image = global::UIF.Properties.Resources.info_icon;
            this.InfoBtn.InitialImage = global::UIF.Properties.Resources.info_icon;
            this.InfoBtn.Location = new System.Drawing.Point(169, 13);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(24, 23);
            this.InfoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoBtn.TabIndex = 3;
            this.InfoBtn.TabStop = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // AbouGroupBox
            // 
            this.AbouGroupBox.Controls.Add(this.VersionLabel);
            this.AbouGroupBox.Controls.Add(this.CopyrightLabel);
            this.AbouGroupBox.Controls.Add(this.DiscordLink);
            this.AbouGroupBox.Controls.Add(this.GitHubLink);
            this.AbouGroupBox.Location = new System.Drawing.Point(12, 227);
            this.AbouGroupBox.Name = "AbouGroupBox";
            this.AbouGroupBox.Size = new System.Drawing.Size(455, 65);
            this.AbouGroupBox.TabIndex = 6;
            this.AbouGroupBox.TabStop = false;
            this.AbouGroupBox.Text = "About";
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
            this.ClientSize = new System.Drawing.Size(479, 306);
            this.Controls.Add(this.AbouGroupBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.MarkFolderAsDefaultBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFldrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusFldrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusFldrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoBtn)).EndInit();
            this.AbouGroupBox.ResumeLayout(false);
            this.AbouGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox AbouGroupBox;
        private System.Windows.Forms.ComboBox FldrComboBox;
        private System.Windows.Forms.PictureBox MinusFldrBtn;
        private System.Windows.Forms.PictureBox PlusFldrBtn;
        private System.Windows.Forms.PictureBox OpenFldrBtn;
        private System.Windows.Forms.Button LoadModsToRamBtn;
        private System.Windows.Forms.ComboBox LocalizationComboBox;
        private System.Windows.Forms.Label LocalizationLabel;
        private System.Windows.Forms.PictureBox MarkFolderAsDefaultBtn;
    }
}

