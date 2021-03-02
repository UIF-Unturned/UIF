namespace UIF
{
    partial class itemList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemList));
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdToClipboard = new System.Windows.Forms.Button();
            this.ItemStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.VehicleHealthTextBox = new System.Windows.Forms.TextBox();
            this.VehicleHealthLabel = new System.Windows.Forms.Label();
            this.EngineTextBox = new System.Windows.Forms.TextBox();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.RangeTextBox = new System.Windows.Forms.TextBox();
            this.ItemType2TextBox = new System.Windows.Forms.TextBox();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.ItemType2Label = new System.Windows.Forms.Label();
            this.StructureDamageTextBox = new System.Windows.Forms.TextBox();
            this.ItemTypeTextBox = new System.Windows.Forms.TextBox();
            this.BuildingsDamageLabel = new System.Windows.Forms.Label();
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.PlayerDamageTextBox = new System.Windows.Forms.TextBox();
            this.DamageHeadTextBox = new System.Windows.Forms.TextBox();
            this.PlayerDamageLabel = new System.Windows.Forms.Label();
            this.BodyDamageTextBox = new System.Windows.Forms.TextBox();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.ProtectionTextBox = new System.Windows.Forms.TextBox();
            this.BodyDamageLabel = new System.Windows.Forms.Label();
            this.HeadDamageLabel = new System.Windows.Forms.Label();
            this.ProtectionLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.SortDamagePlayersBtn = new System.Windows.Forms.Button();
            this.SortCapacityBtn = new System.Windows.Forms.Button();
            this.SortProtectionBtn = new System.Windows.Forms.Button();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.SortDamageBuildingsBtn = new System.Windows.Forms.Button();
            this.MixBtn = new System.Windows.Forms.Button();
            this.SortVehicleHealthBtn = new System.Windows.Forms.Button();
            this.InfoGroupBox.SuspendLayout();
            this.ItemStatsGroupBox.SuspendLayout();
            this.SortingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsLabel.Location = new System.Drawing.Point(9, 9);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(98, 17);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Found results:";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(12, 29);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(167, 537);
            this.ResultsListBox.TabIndex = 6;
            this.ResultsListBox.TabStop = false;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.IdTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.IdLabel);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.IdToClipboard);
            this.InfoGroupBox.Location = new System.Drawing.Point(185, 29);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(263, 93);
            this.InfoGroupBox.TabIndex = 5;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(62, 39);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(195, 20);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(62, 18);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(195, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TabStop = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(6, 37);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(34, 20);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID: ";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(6, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name: ";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // IdToClipboard
            // 
            this.IdToClipboard.Location = new System.Drawing.Point(62, 65);
            this.IdToClipboard.Name = "IdToClipboard";
            this.IdToClipboard.Size = new System.Drawing.Size(195, 23);
            this.IdToClipboard.TabIndex = 4;
            this.IdToClipboard.TabStop = false;
            this.IdToClipboard.Text = "Copy ID to clipboard";
            this.IdToClipboard.UseVisualStyleBackColor = true;
            this.IdToClipboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemStatsGroupBox
            // 
            this.ItemStatsGroupBox.Controls.Add(this.VehicleHealthTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.VehicleHealthLabel);
            this.ItemStatsGroupBox.Controls.Add(this.EngineTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.EngineLabel);
            this.ItemStatsGroupBox.Controls.Add(this.RangeTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ItemType2TextBox);
            this.ItemStatsGroupBox.Controls.Add(this.RangeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemType2Label);
            this.ItemStatsGroupBox.Controls.Add(this.StructureDamageTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ItemTypeTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.BuildingsDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemTypeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.PlayerDamageTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.DamageHeadTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.PlayerDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.BodyDamageTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.CapacityTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.ProtectionTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.BodyDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.HeadDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ProtectionLabel);
            this.ItemStatsGroupBox.Controls.Add(this.CapacityLabel);
            this.ItemStatsGroupBox.Location = new System.Drawing.Point(185, 128);
            this.ItemStatsGroupBox.Name = "ItemStatsGroupBox";
            this.ItemStatsGroupBox.Size = new System.Drawing.Size(263, 240);
            this.ItemStatsGroupBox.TabIndex = 4;
            this.ItemStatsGroupBox.TabStop = false;
            this.ItemStatsGroupBox.Text = "Item Stats";
            // 
            // VehicleHealthTextBox
            // 
            this.VehicleHealthTextBox.Location = new System.Drawing.Point(195, 218);
            this.VehicleHealthTextBox.Name = "VehicleHealthTextBox";
            this.VehicleHealthTextBox.ReadOnly = true;
            this.VehicleHealthTextBox.Size = new System.Drawing.Size(62, 20);
            this.VehicleHealthTextBox.TabIndex = 18;
            this.VehicleHealthTextBox.TabStop = false;
            this.VehicleHealthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VehicleHealthLabel
            // 
            this.VehicleHealthLabel.AutoSize = true;
            this.VehicleHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleHealthLabel.Location = new System.Drawing.Point(6, 216);
            this.VehicleHealthLabel.Name = "VehicleHealthLabel";
            this.VehicleHealthLabel.Size = new System.Drawing.Size(116, 20);
            this.VehicleHealthLabel.TabIndex = 19;
            this.VehicleHealthLabel.Text = "Vehicle Health:";
            // 
            // EngineTextBox
            // 
            this.EngineTextBox.Location = new System.Drawing.Point(195, 198);
            this.EngineTextBox.Name = "EngineTextBox";
            this.EngineTextBox.ReadOnly = true;
            this.EngineTextBox.Size = new System.Drawing.Size(62, 20);
            this.EngineTextBox.TabIndex = 20;
            this.EngineTextBox.TabStop = false;
            this.EngineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineLabel.Location = new System.Drawing.Point(6, 196);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(63, 20);
            this.EngineLabel.TabIndex = 21;
            this.EngineLabel.Text = "Engine:";
            // 
            // RangeTextBox
            // 
            this.RangeTextBox.Location = new System.Drawing.Point(195, 138);
            this.RangeTextBox.Name = "RangeTextBox";
            this.RangeTextBox.ReadOnly = true;
            this.RangeTextBox.Size = new System.Drawing.Size(62, 20);
            this.RangeTextBox.TabIndex = 0;
            this.RangeTextBox.TabStop = false;
            this.RangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemType2TextBox
            // 
            this.ItemType2TextBox.Location = new System.Drawing.Point(195, 178);
            this.ItemType2TextBox.Name = "ItemType2TextBox";
            this.ItemType2TextBox.ReadOnly = true;
            this.ItemType2TextBox.Size = new System.Drawing.Size(62, 20);
            this.ItemType2TextBox.TabIndex = 1;
            this.ItemType2TextBox.TabStop = false;
            this.ItemType2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLabel.Location = new System.Drawing.Point(6, 136);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(61, 20);
            this.RangeLabel.TabIndex = 2;
            this.RangeLabel.Text = "Range:";
            // 
            // ItemType2Label
            // 
            this.ItemType2Label.AutoSize = true;
            this.ItemType2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemType2Label.Location = new System.Drawing.Point(6, 176);
            this.ItemType2Label.Name = "ItemType2Label";
            this.ItemType2Label.Size = new System.Drawing.Size(96, 20);
            this.ItemType2Label.TabIndex = 3;
            this.ItemType2Label.Text = "Item Type 2:";
            // 
            // StructureDamageTextBox
            // 
            this.StructureDamageTextBox.Location = new System.Drawing.Point(195, 118);
            this.StructureDamageTextBox.Name = "StructureDamageTextBox";
            this.StructureDamageTextBox.ReadOnly = true;
            this.StructureDamageTextBox.Size = new System.Drawing.Size(62, 20);
            this.StructureDamageTextBox.TabIndex = 4;
            this.StructureDamageTextBox.TabStop = false;
            this.StructureDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemTypeTextBox
            // 
            this.ItemTypeTextBox.Location = new System.Drawing.Point(195, 158);
            this.ItemTypeTextBox.Name = "ItemTypeTextBox";
            this.ItemTypeTextBox.ReadOnly = true;
            this.ItemTypeTextBox.Size = new System.Drawing.Size(62, 20);
            this.ItemTypeTextBox.TabIndex = 5;
            this.ItemTypeTextBox.TabStop = false;
            this.ItemTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuildingsDamageLabel
            // 
            this.BuildingsDamageLabel.AutoSize = true;
            this.BuildingsDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingsDamageLabel.Location = new System.Drawing.Point(6, 116);
            this.BuildingsDamageLabel.Name = "BuildingsDamageLabel";
            this.BuildingsDamageLabel.Size = new System.Drawing.Size(158, 20);
            this.BuildingsDamageLabel.TabIndex = 6;
            this.BuildingsDamageLabel.Text = "Damage to buildings:";
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemTypeLabel.Location = new System.Drawing.Point(6, 156);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(83, 20);
            this.ItemTypeLabel.TabIndex = 7;
            this.ItemTypeLabel.Text = "Item Type:";
            // 
            // PlayerDamageTextBox
            // 
            this.PlayerDamageTextBox.Location = new System.Drawing.Point(195, 98);
            this.PlayerDamageTextBox.Name = "PlayerDamageTextBox";
            this.PlayerDamageTextBox.ReadOnly = true;
            this.PlayerDamageTextBox.Size = new System.Drawing.Size(62, 20);
            this.PlayerDamageTextBox.TabIndex = 8;
            this.PlayerDamageTextBox.TabStop = false;
            this.PlayerDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DamageHeadTextBox
            // 
            this.DamageHeadTextBox.Location = new System.Drawing.Point(195, 58);
            this.DamageHeadTextBox.Name = "DamageHeadTextBox";
            this.DamageHeadTextBox.ReadOnly = true;
            this.DamageHeadTextBox.Size = new System.Drawing.Size(62, 20);
            this.DamageHeadTextBox.TabIndex = 9;
            this.DamageHeadTextBox.TabStop = false;
            this.DamageHeadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerDamageLabel
            // 
            this.PlayerDamageLabel.AutoSize = true;
            this.PlayerDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerDamageLabel.Location = new System.Drawing.Point(6, 96);
            this.PlayerDamageLabel.Name = "PlayerDamageLabel";
            this.PlayerDamageLabel.Size = new System.Drawing.Size(121, 20);
            this.PlayerDamageLabel.TabIndex = 10;
            this.PlayerDamageLabel.Text = "Player Damage:";
            // 
            // BodyDamageTextBox
            // 
            this.BodyDamageTextBox.Location = new System.Drawing.Point(195, 78);
            this.BodyDamageTextBox.Name = "BodyDamageTextBox";
            this.BodyDamageTextBox.ReadOnly = true;
            this.BodyDamageTextBox.Size = new System.Drawing.Size(62, 20);
            this.BodyDamageTextBox.TabIndex = 11;
            this.BodyDamageTextBox.TabStop = false;
            this.BodyDamageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(195, 18);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.ReadOnly = true;
            this.CapacityTextBox.Size = new System.Drawing.Size(62, 20);
            this.CapacityTextBox.TabIndex = 12;
            this.CapacityTextBox.TabStop = false;
            this.CapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProtectionTextBox
            // 
            this.ProtectionTextBox.Location = new System.Drawing.Point(195, 38);
            this.ProtectionTextBox.Name = "ProtectionTextBox";
            this.ProtectionTextBox.ReadOnly = true;
            this.ProtectionTextBox.Size = new System.Drawing.Size(62, 20);
            this.ProtectionTextBox.TabIndex = 13;
            this.ProtectionTextBox.TabStop = false;
            this.ProtectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BodyDamageLabel
            // 
            this.BodyDamageLabel.AutoSize = true;
            this.BodyDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyDamageLabel.Location = new System.Drawing.Point(6, 76);
            this.BodyDamageLabel.Name = "BodyDamageLabel";
            this.BodyDamageLabel.Size = new System.Drawing.Size(124, 20);
            this.BodyDamageLabel.TabIndex = 14;
            this.BodyDamageLabel.Text = "Damage (Body):";
            // 
            // HeadDamageLabel
            // 
            this.HeadDamageLabel.AutoSize = true;
            this.HeadDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadDamageLabel.Location = new System.Drawing.Point(6, 56);
            this.HeadDamageLabel.Name = "HeadDamageLabel";
            this.HeadDamageLabel.Size = new System.Drawing.Size(127, 20);
            this.HeadDamageLabel.TabIndex = 15;
            this.HeadDamageLabel.Text = "Damage (Head):";
            // 
            // ProtectionLabel
            // 
            this.ProtectionLabel.AutoSize = true;
            this.ProtectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProtectionLabel.Location = new System.Drawing.Point(6, 36);
            this.ProtectionLabel.Name = "ProtectionLabel";
            this.ProtectionLabel.Size = new System.Drawing.Size(113, 20);
            this.ProtectionLabel.TabIndex = 16;
            this.ProtectionLabel.Text = "Protection (%):";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapacityLabel.Location = new System.Drawing.Point(6, 16);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(122, 20);
            this.CapacityLabel.TabIndex = 17;
            this.CapacityLabel.Text = "Capacity (Cells):";
            // 
            // SortDamagePlayersBtn
            // 
            this.SortDamagePlayersBtn.Location = new System.Drawing.Point(10, 77);
            this.SortDamagePlayersBtn.Name = "SortDamagePlayersBtn";
            this.SortDamagePlayersBtn.Size = new System.Drawing.Size(247, 23);
            this.SortDamagePlayersBtn.TabIndex = 4;
            this.SortDamagePlayersBtn.TabStop = false;
            this.SortDamagePlayersBtn.Text = "Sort by damage to players";
            this.SortDamagePlayersBtn.UseVisualStyleBackColor = true;
            this.SortDamagePlayersBtn.Click += new System.EventHandler(this.SortDamagePlayersBtn_Click);
            // 
            // SortCapacityBtn
            // 
            this.SortCapacityBtn.Location = new System.Drawing.Point(10, 19);
            this.SortCapacityBtn.Name = "SortCapacityBtn";
            this.SortCapacityBtn.Size = new System.Drawing.Size(247, 23);
            this.SortCapacityBtn.TabIndex = 3;
            this.SortCapacityBtn.TabStop = false;
            this.SortCapacityBtn.Text = "Sort by clothing capacity";
            this.SortCapacityBtn.UseVisualStyleBackColor = true;
            this.SortCapacityBtn.Click += new System.EventHandler(this.SortCapacityBtn_Click);
            // 
            // SortProtectionBtn
            // 
            this.SortProtectionBtn.Location = new System.Drawing.Point(10, 48);
            this.SortProtectionBtn.Name = "SortProtectionBtn";
            this.SortProtectionBtn.Size = new System.Drawing.Size(247, 23);
            this.SortProtectionBtn.TabIndex = 2;
            this.SortProtectionBtn.TabStop = false;
            this.SortProtectionBtn.Text = "Sort by clothing protection";
            this.SortProtectionBtn.UseVisualStyleBackColor = true;
            this.SortProtectionBtn.Click += new System.EventHandler(this.SortProtectionBtn_Click);
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Controls.Add(this.SortVehicleHealthBtn);
            this.SortingGroupBox.Controls.Add(this.SortDamageBuildingsBtn);
            this.SortingGroupBox.Controls.Add(this.MixBtn);
            this.SortingGroupBox.Controls.Add(this.SortProtectionBtn);
            this.SortingGroupBox.Controls.Add(this.SortCapacityBtn);
            this.SortingGroupBox.Controls.Add(this.SortDamagePlayersBtn);
            this.SortingGroupBox.Location = new System.Drawing.Point(185, 374);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Size = new System.Drawing.Size(263, 192);
            this.SortingGroupBox.TabIndex = 0;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Sorting";
            // 
            // SortDamageBuildingsBtn
            // 
            this.SortDamageBuildingsBtn.Location = new System.Drawing.Point(10, 106);
            this.SortDamageBuildingsBtn.Name = "SortDamageBuildingsBtn";
            this.SortDamageBuildingsBtn.Size = new System.Drawing.Size(247, 23);
            this.SortDamageBuildingsBtn.TabIndex = 0;
            this.SortDamageBuildingsBtn.TabStop = false;
            this.SortDamageBuildingsBtn.Text = "Sort by damage to buildings";
            this.SortDamageBuildingsBtn.UseVisualStyleBackColor = true;
            this.SortDamageBuildingsBtn.Click += new System.EventHandler(this.SortDamageBuildingsBtn_Click);
            // 
            // MixBtn
            // 
            this.MixBtn.Location = new System.Drawing.Point(10, 164);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(247, 23);
            this.MixBtn.TabIndex = 1;
            this.MixBtn.TabStop = false;
            this.MixBtn.Text = "Mix";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // SortVehicleHealthBtn
            // 
            this.SortVehicleHealthBtn.Location = new System.Drawing.Point(10, 135);
            this.SortVehicleHealthBtn.Name = "SortVehicleHealthBtn";
            this.SortVehicleHealthBtn.Size = new System.Drawing.Size(247, 23);
            this.SortVehicleHealthBtn.TabIndex = 5;
            this.SortVehicleHealthBtn.TabStop = false;
            this.SortVehicleHealthBtn.Text = "Sort by vehicle health";
            this.SortVehicleHealthBtn.UseVisualStyleBackColor = true;
            this.SortVehicleHealthBtn.Click += new System.EventHandler(this.SortVehicleHealthBtn_Click);
            // 
            // itemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 575);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.ItemStatsGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ResultsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "itemList";
            this.Text = "Item List";
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ItemStatsGroupBox.ResumeLayout(false);
            this.ItemStatsGroupBox.PerformLayout();
            this.SortingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button IdToClipboard;
        private System.Windows.Forms.GroupBox ItemStatsGroupBox;
        private System.Windows.Forms.TextBox DamageHeadTextBox;
        private System.Windows.Forms.TextBox BodyDamageTextBox;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.TextBox ProtectionTextBox;
        private System.Windows.Forms.Label BodyDamageLabel;
        private System.Windows.Forms.Label HeadDamageLabel;
        private System.Windows.Forms.Label ProtectionLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Label ItemTypeLabel;
        private System.Windows.Forms.TextBox ItemTypeTextBox;
        private System.Windows.Forms.TextBox ItemType2TextBox;
        private System.Windows.Forms.Label ItemType2Label;
        private System.Windows.Forms.Button SortDamagePlayersBtn;
        private System.Windows.Forms.Button SortCapacityBtn;
        private System.Windows.Forms.Button SortProtectionBtn;
        private System.Windows.Forms.GroupBox SortingGroupBox;
        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.TextBox RangeTextBox;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.TextBox StructureDamageTextBox;
        private System.Windows.Forms.Label BuildingsDamageLabel;
        private System.Windows.Forms.TextBox PlayerDamageTextBox;
        private System.Windows.Forms.Label PlayerDamageLabel;
        private System.Windows.Forms.Button SortDamageBuildingsBtn;
        private System.Windows.Forms.TextBox VehicleHealthTextBox;
        private System.Windows.Forms.Label VehicleHealthLabel;
        private System.Windows.Forms.TextBox EngineTextBox;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Button SortVehicleHealthBtn;
    }
}