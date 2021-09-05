namespace UIF
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.NameIdToClipboard = new System.Windows.Forms.Button();
            this.AllNameIdToClipboard = new System.Windows.Forms.Button();
            this.IdPrefixTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdToClipboard = new System.Windows.Forms.Button();
            this.ItemStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.CalibersTextBox = new System.Windows.Forms.TextBox();
            this.damage = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.shake = new System.Windows.Forms.TextBox();
            this.health = new System.Windows.Forms.TextBox();
            this.engine = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.useable = new System.Windows.Forms.TextBox();
            this.range = new System.Windows.Forms.TextBox();
            this.structure_damage = new System.Windows.Forms.TextBox();
            this.player_damage = new System.Windows.Forms.TextBox();
            this.player_spine_damage = new System.Windows.Forms.TextBox();
            this.player_skull_damage = new System.Windows.Forms.TextBox();
            this.armor = new System.Windows.Forms.TextBox();
            this.BarrelDamageLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.ShakeLabel = new System.Windows.Forms.Label();
            this.ItemHealthLabel = new System.Windows.Forms.Label();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.RangeLabel = new System.Windows.Forms.Label();
            this.ItemType2Label = new System.Windows.Forms.Label();
            this.BuildingsDamageLabel = new System.Windows.Forms.Label();
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.PlayerDamageLabel = new System.Windows.Forms.Label();
            this.BodyDamageLabel = new System.Windows.Forms.Label();
            this.HeadDamageLabel = new System.Windows.Forms.Label();
            this.ProtectionLabel = new System.Windows.Forms.Label();
            this.ItemCapacityLabel = new System.Windows.Forms.Label();
            this.item_capacity = new System.Windows.Forms.TextBox();
            this.SortDamagePlayersBtn = new System.Windows.Forms.Button();
            this.SortCapacityBtn = new System.Windows.Forms.Button();
            this.SortProtectionBtn = new System.Windows.Forms.Button();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.SortByBarrelDamageBtn = new System.Windows.Forms.Button();
            this.SortByVolumeBtn = new System.Windows.Forms.Button();
            this.SortByShakeBtn = new System.Windows.Forms.Button();
            this.SortByBuildingHealthBtn = new System.Windows.Forms.Button();
            this.SortBarricadeCapacityBtn = new System.Windows.Forms.Button();
            this.SortVehicleHealthBtn = new System.Windows.Forms.Button();
            this.SortDamageBuildingsBtn = new System.Windows.Forms.Button();
            this.MixBtn = new System.Windows.Forms.Button();
            this.InfoGroupBox.SuspendLayout();
            this.ItemStatsGroupBox.SuspendLayout();
            this.SortingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsLabel.Location = new System.Drawing.Point(12, 11);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(116, 20);
            this.ResultsLabel.TabIndex = 7;
            this.ResultsLabel.Text = "Found results:";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 16;
            this.ResultsListBox.Location = new System.Drawing.Point(16, 36);
            this.ResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(221, 548);
            this.ResultsListBox.TabIndex = 6;
            this.ResultsListBox.TabStop = false;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.NameIdToClipboard);
            this.InfoGroupBox.Controls.Add(this.AllNameIdToClipboard);
            this.InfoGroupBox.Controls.Add(this.IdPrefixTextBox);
            this.InfoGroupBox.Controls.Add(this.IdTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.IdLabel);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.IdToClipboard);
            this.InfoGroupBox.Location = new System.Drawing.Point(247, 36);
            this.InfoGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoGroupBox.Size = new System.Drawing.Size(459, 181);
            this.InfoGroupBox.TabIndex = 5;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // NameIdToClipboard
            // 
            this.NameIdToClipboard.Location = new System.Drawing.Point(120, 102);
            this.NameIdToClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameIdToClipboard.Name = "NameIdToClipboard";
            this.NameIdToClipboard.Size = new System.Drawing.Size(331, 28);
            this.NameIdToClipboard.TabIndex = 7;
            this.NameIdToClipboard.TabStop = false;
            this.NameIdToClipboard.Text = "Copy Name/ID to clipboard";
            this.NameIdToClipboard.UseVisualStyleBackColor = true;
            this.NameIdToClipboard.Click += new System.EventHandler(this.NameIdToClipboard_Click);
            // 
            // AllNameIdToClipboard
            // 
            this.AllNameIdToClipboard.Location = new System.Drawing.Point(120, 130);
            this.AllNameIdToClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllNameIdToClipboard.Name = "AllNameIdToClipboard";
            this.AllNameIdToClipboard.Size = new System.Drawing.Size(331, 28);
            this.AllNameIdToClipboard.TabIndex = 6;
            this.AllNameIdToClipboard.TabStop = false;
            this.AllNameIdToClipboard.Text = "Copy all Name/ID to clipboard";
            this.AllNameIdToClipboard.UseVisualStyleBackColor = true;
            this.AllNameIdToClipboard.Click += new System.EventHandler(this.AllNameIdToClipboard_Click);
            // 
            // IdPrefixTextBox
            // 
            this.IdPrefixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdPrefixTextBox.Location = new System.Drawing.Point(120, 46);
            this.IdPrefixTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdPrefixTextBox.Name = "IdPrefixTextBox";
            this.IdPrefixTextBox.Size = new System.Drawing.Size(173, 26);
            this.IdPrefixTextBox.TabIndex = 5;
            this.IdPrefixTextBox.TabStop = false;
            this.IdPrefixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdTextBox.Location = new System.Drawing.Point(295, 46);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(155, 26);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(120, 20);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(329, 26);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TabStop = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(8, 46);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(42, 25);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID: ";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(8, 20);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name: ";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // IdToClipboard
            // 
            this.IdToClipboard.Location = new System.Drawing.Point(120, 74);
            this.IdToClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdToClipboard.Name = "IdToClipboard";
            this.IdToClipboard.Size = new System.Drawing.Size(331, 28);
            this.IdToClipboard.TabIndex = 4;
            this.IdToClipboard.TabStop = false;
            this.IdToClipboard.Text = "Copy ID to clipboard";
            this.IdToClipboard.UseVisualStyleBackColor = true;
            this.IdToClipboard.Click += new System.EventHandler(this.IdToClipboard_Click);
            // 
            // ItemStatsGroupBox
            // 
            this.ItemStatsGroupBox.Controls.Add(this.CalibersTextBox);
            this.ItemStatsGroupBox.Controls.Add(this.damage);
            this.ItemStatsGroupBox.Controls.Add(this.volume);
            this.ItemStatsGroupBox.Controls.Add(this.shake);
            this.ItemStatsGroupBox.Controls.Add(this.health);
            this.ItemStatsGroupBox.Controls.Add(this.engine);
            this.ItemStatsGroupBox.Controls.Add(this.type);
            this.ItemStatsGroupBox.Controls.Add(this.useable);
            this.ItemStatsGroupBox.Controls.Add(this.range);
            this.ItemStatsGroupBox.Controls.Add(this.structure_damage);
            this.ItemStatsGroupBox.Controls.Add(this.player_damage);
            this.ItemStatsGroupBox.Controls.Add(this.player_spine_damage);
            this.ItemStatsGroupBox.Controls.Add(this.player_skull_damage);
            this.ItemStatsGroupBox.Controls.Add(this.armor);
            this.ItemStatsGroupBox.Controls.Add(this.BarrelDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.VolumeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ShakeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemHealthLabel);
            this.ItemStatsGroupBox.Controls.Add(this.EngineLabel);
            this.ItemStatsGroupBox.Controls.Add(this.RangeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemType2Label);
            this.ItemStatsGroupBox.Controls.Add(this.BuildingsDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemTypeLabel);
            this.ItemStatsGroupBox.Controls.Add(this.PlayerDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.BodyDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.HeadDamageLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ProtectionLabel);
            this.ItemStatsGroupBox.Controls.Add(this.ItemCapacityLabel);
            this.ItemStatsGroupBox.Controls.Add(this.item_capacity);
            this.ItemStatsGroupBox.Location = new System.Drawing.Point(247, 202);
            this.ItemStatsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemStatsGroupBox.Name = "ItemStatsGroupBox";
            this.ItemStatsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemStatsGroupBox.Size = new System.Drawing.Size(459, 548);
            this.ItemStatsGroupBox.TabIndex = 4;
            this.ItemStatsGroupBox.TabStop = false;
            this.ItemStatsGroupBox.Text = "Item Stats";
            // 
            // CalibersTextBox
            // 
            this.CalibersTextBox.Location = new System.Drawing.Point(13, 390);
            this.CalibersTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalibersTextBox.Multiline = true;
            this.CalibersTextBox.Name = "CalibersTextBox";
            this.CalibersTextBox.ReadOnly = true;
            this.CalibersTextBox.Size = new System.Drawing.Size(436, 149);
            this.CalibersTextBox.TabIndex = 28;
            // 
            // damage
            // 
            this.damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.damage.Location = new System.Drawing.Point(345, 342);
            this.damage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.damage.Name = "damage";
            this.damage.ReadOnly = true;
            this.damage.Size = new System.Drawing.Size(104, 26);
            this.damage.TabIndex = 26;
            this.damage.TabStop = false;
            this.damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volume
            // 
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volume.Location = new System.Drawing.Point(345, 318);
            this.volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volume.Name = "volume";
            this.volume.ReadOnly = true;
            this.volume.Size = new System.Drawing.Size(104, 26);
            this.volume.TabIndex = 24;
            this.volume.TabStop = false;
            this.volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shake
            // 
            this.shake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shake.Location = new System.Drawing.Point(345, 293);
            this.shake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shake.Name = "shake";
            this.shake.ReadOnly = true;
            this.shake.Size = new System.Drawing.Size(104, 26);
            this.shake.TabIndex = 22;
            this.shake.TabStop = false;
            this.shake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // health
            // 
            this.health.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.Location = new System.Drawing.Point(345, 268);
            this.health.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.health.Name = "health";
            this.health.ReadOnly = true;
            this.health.Size = new System.Drawing.Size(104, 26);
            this.health.TabIndex = 18;
            this.health.TabStop = false;
            this.health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // engine
            // 
            this.engine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engine.Location = new System.Drawing.Point(345, 244);
            this.engine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.engine.Name = "engine";
            this.engine.ReadOnly = true;
            this.engine.Size = new System.Drawing.Size(104, 26);
            this.engine.TabIndex = 20;
            this.engine.TabStop = false;
            this.engine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.Location = new System.Drawing.Point(345, 219);
            this.type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Size = new System.Drawing.Size(104, 26);
            this.type.TabIndex = 1;
            this.type.TabStop = false;
            this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // useable
            // 
            this.useable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useable.Location = new System.Drawing.Point(345, 194);
            this.useable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useable.Name = "useable";
            this.useable.ReadOnly = true;
            this.useable.Size = new System.Drawing.Size(104, 26);
            this.useable.TabIndex = 5;
            this.useable.TabStop = false;
            this.useable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // range
            // 
            this.range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.range.Location = new System.Drawing.Point(345, 170);
            this.range.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.range.Name = "range";
            this.range.ReadOnly = true;
            this.range.Size = new System.Drawing.Size(104, 26);
            this.range.TabIndex = 0;
            this.range.TabStop = false;
            this.range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // structure_damage
            // 
            this.structure_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.structure_damage.Location = new System.Drawing.Point(345, 145);
            this.structure_damage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.structure_damage.Name = "structure_damage";
            this.structure_damage.ReadOnly = true;
            this.structure_damage.Size = new System.Drawing.Size(104, 26);
            this.structure_damage.TabIndex = 4;
            this.structure_damage.TabStop = false;
            this.structure_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_damage
            // 
            this.player_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_damage.Location = new System.Drawing.Point(345, 121);
            this.player_damage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player_damage.Name = "player_damage";
            this.player_damage.ReadOnly = true;
            this.player_damage.Size = new System.Drawing.Size(104, 26);
            this.player_damage.TabIndex = 8;
            this.player_damage.TabStop = false;
            this.player_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_spine_damage
            // 
            this.player_spine_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_spine_damage.Location = new System.Drawing.Point(345, 96);
            this.player_spine_damage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player_spine_damage.Name = "player_spine_damage";
            this.player_spine_damage.ReadOnly = true;
            this.player_spine_damage.Size = new System.Drawing.Size(104, 26);
            this.player_spine_damage.TabIndex = 11;
            this.player_spine_damage.TabStop = false;
            this.player_spine_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_skull_damage
            // 
            this.player_skull_damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_skull_damage.Location = new System.Drawing.Point(345, 71);
            this.player_skull_damage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player_skull_damage.Name = "player_skull_damage";
            this.player_skull_damage.ReadOnly = true;
            this.player_skull_damage.Size = new System.Drawing.Size(104, 26);
            this.player_skull_damage.TabIndex = 9;
            this.player_skull_damage.TabStop = false;
            this.player_skull_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // armor
            // 
            this.armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.armor.Location = new System.Drawing.Point(345, 47);
            this.armor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.armor.Name = "armor";
            this.armor.ReadOnly = true;
            this.armor.Size = new System.Drawing.Size(104, 26);
            this.armor.TabIndex = 13;
            this.armor.TabStop = false;
            this.armor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarrelDamageLabel
            // 
            this.BarrelDamageLabel.AutoSize = true;
            this.BarrelDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BarrelDamageLabel.Location = new System.Drawing.Point(8, 340);
            this.BarrelDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BarrelDamageLabel.Name = "BarrelDamageLabel";
            this.BarrelDamageLabel.Size = new System.Drawing.Size(226, 25);
            this.BarrelDamageLabel.TabIndex = 27;
            this.BarrelDamageLabel.Text = "Barrel damage multiplier:";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeLabel.Location = new System.Drawing.Point(8, 315);
            this.VolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(268, 25);
            this.VolumeLabel.TabIndex = 25;
            this.VolumeLabel.Text = "Suppressor volume multiplier:";
            // 
            // ShakeLabel
            // 
            this.ShakeLabel.AutoSize = true;
            this.ShakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShakeLabel.Location = new System.Drawing.Point(8, 290);
            this.ShakeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShakeLabel.Name = "ShakeLabel";
            this.ShakeLabel.Size = new System.Drawing.Size(250, 25);
            this.ShakeLabel.TabIndex = 23;
            this.ShakeLabel.Text = "Grip/Barrel shake multiplier:";
            // 
            // ItemHealthLabel
            // 
            this.ItemHealthLabel.AutoSize = true;
            this.ItemHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemHealthLabel.Location = new System.Drawing.Point(8, 266);
            this.ItemHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemHealthLabel.Name = "ItemHealthLabel";
            this.ItemHealthLabel.Size = new System.Drawing.Size(229, 25);
            this.ItemHealthLabel.TabIndex = 19;
            this.ItemHealthLabel.Text = "Barricade/vehicle Health:";
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineLabel.Location = new System.Drawing.Point(8, 241);
            this.EngineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(79, 25);
            this.EngineLabel.TabIndex = 21;
            this.EngineLabel.Text = "Engine:";
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RangeLabel.Location = new System.Drawing.Point(8, 167);
            this.RangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(75, 25);
            this.RangeLabel.TabIndex = 2;
            this.RangeLabel.Text = "Range:";
            // 
            // ItemType2Label
            // 
            this.ItemType2Label.AutoSize = true;
            this.ItemType2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemType2Label.Location = new System.Drawing.Point(8, 217);
            this.ItemType2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemType2Label.Name = "ItemType2Label";
            this.ItemType2Label.Size = new System.Drawing.Size(63, 25);
            this.ItemType2Label.TabIndex = 3;
            this.ItemType2Label.Text = "Type:";
            // 
            // BuildingsDamageLabel
            // 
            this.BuildingsDamageLabel.AutoSize = true;
            this.BuildingsDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildingsDamageLabel.Location = new System.Drawing.Point(8, 143);
            this.BuildingsDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuildingsDamageLabel.Name = "BuildingsDamageLabel";
            this.BuildingsDamageLabel.Size = new System.Drawing.Size(195, 25);
            this.BuildingsDamageLabel.TabIndex = 6;
            this.BuildingsDamageLabel.Text = "Damage to buildings:";
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemTypeLabel.Location = new System.Drawing.Point(8, 192);
            this.ItemTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(90, 25);
            this.ItemTypeLabel.TabIndex = 7;
            this.ItemTypeLabel.Text = "Useable:";
            // 
            // PlayerDamageLabel
            // 
            this.PlayerDamageLabel.AutoSize = true;
            this.PlayerDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerDamageLabel.Location = new System.Drawing.Point(8, 118);
            this.PlayerDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerDamageLabel.Name = "PlayerDamageLabel";
            this.PlayerDamageLabel.Size = new System.Drawing.Size(152, 25);
            this.PlayerDamageLabel.TabIndex = 10;
            this.PlayerDamageLabel.Text = "Player Damage:";
            // 
            // BodyDamageLabel
            // 
            this.BodyDamageLabel.AutoSize = true;
            this.BodyDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyDamageLabel.Location = new System.Drawing.Point(8, 94);
            this.BodyDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BodyDamageLabel.Name = "BodyDamageLabel";
            this.BodyDamageLabel.Size = new System.Drawing.Size(156, 25);
            this.BodyDamageLabel.TabIndex = 14;
            this.BodyDamageLabel.Text = "Damage (Body):";
            // 
            // HeadDamageLabel
            // 
            this.HeadDamageLabel.AutoSize = true;
            this.HeadDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadDamageLabel.Location = new System.Drawing.Point(8, 69);
            this.HeadDamageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadDamageLabel.Name = "HeadDamageLabel";
            this.HeadDamageLabel.Size = new System.Drawing.Size(158, 25);
            this.HeadDamageLabel.TabIndex = 15;
            this.HeadDamageLabel.Text = "Damage (Head):";
            // 
            // ProtectionLabel
            // 
            this.ProtectionLabel.AutoSize = true;
            this.ProtectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProtectionLabel.Location = new System.Drawing.Point(8, 44);
            this.ProtectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProtectionLabel.Name = "ProtectionLabel";
            this.ProtectionLabel.Size = new System.Drawing.Size(142, 25);
            this.ProtectionLabel.TabIndex = 16;
            this.ProtectionLabel.Text = "Protection (%):";
            // 
            // ItemCapacityLabel
            // 
            this.ItemCapacityLabel.AutoSize = true;
            this.ItemCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemCapacityLabel.Location = new System.Drawing.Point(8, 20);
            this.ItemCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCapacityLabel.Name = "ItemCapacityLabel";
            this.ItemCapacityLabel.Size = new System.Drawing.Size(309, 25);
            this.ItemCapacityLabel.TabIndex = 17;
            this.ItemCapacityLabel.Text = "Barricade/clothing capacity (cells):";
            // 
            // item_capacity
            // 
            this.item_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_capacity.Location = new System.Drawing.Point(345, 22);
            this.item_capacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.item_capacity.Name = "item_capacity";
            this.item_capacity.ReadOnly = true;
            this.item_capacity.Size = new System.Drawing.Size(104, 26);
            this.item_capacity.TabIndex = 12;
            this.item_capacity.TabStop = false;
            this.item_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SortDamagePlayersBtn
            // 
            this.SortDamagePlayersBtn.Location = new System.Drawing.Point(17, 133);
            this.SortDamagePlayersBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortDamagePlayersBtn.Name = "SortDamagePlayersBtn";
            this.SortDamagePlayersBtn.Size = new System.Drawing.Size(231, 28);
            this.SortDamagePlayersBtn.TabIndex = 4;
            this.SortDamagePlayersBtn.TabStop = false;
            this.SortDamagePlayersBtn.Text = "Damage to players";
            this.SortDamagePlayersBtn.UseVisualStyleBackColor = true;
            this.SortDamagePlayersBtn.Click += new System.EventHandler(this.SortDamagePlayersBtn_Click);
            // 
            // SortCapacityBtn
            // 
            this.SortCapacityBtn.Location = new System.Drawing.Point(17, 62);
            this.SortCapacityBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortCapacityBtn.Name = "SortCapacityBtn";
            this.SortCapacityBtn.Size = new System.Drawing.Size(231, 28);
            this.SortCapacityBtn.TabIndex = 3;
            this.SortCapacityBtn.TabStop = false;
            this.SortCapacityBtn.Text = "Clothing capacity";
            this.SortCapacityBtn.UseVisualStyleBackColor = true;
            this.SortCapacityBtn.Click += new System.EventHandler(this.SortCapacityBtn_Click);
            // 
            // SortProtectionBtn
            // 
            this.SortProtectionBtn.Location = new System.Drawing.Point(17, 97);
            this.SortProtectionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortProtectionBtn.Name = "SortProtectionBtn";
            this.SortProtectionBtn.Size = new System.Drawing.Size(231, 28);
            this.SortProtectionBtn.TabIndex = 2;
            this.SortProtectionBtn.TabStop = false;
            this.SortProtectionBtn.Text = "Clothing protection";
            this.SortProtectionBtn.UseVisualStyleBackColor = true;
            this.SortProtectionBtn.Click += new System.EventHandler(this.SortProtectionBtn_Click);
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Controls.Add(this.SortByLabel);
            this.SortingGroupBox.Controls.Add(this.SortByBarrelDamageBtn);
            this.SortingGroupBox.Controls.Add(this.SortByVolumeBtn);
            this.SortingGroupBox.Controls.Add(this.SortByShakeBtn);
            this.SortingGroupBox.Controls.Add(this.SortByBuildingHealthBtn);
            this.SortingGroupBox.Controls.Add(this.SortBarricadeCapacityBtn);
            this.SortingGroupBox.Controls.Add(this.SortVehicleHealthBtn);
            this.SortingGroupBox.Controls.Add(this.SortDamageBuildingsBtn);
            this.SortingGroupBox.Controls.Add(this.MixBtn);
            this.SortingGroupBox.Controls.Add(this.SortProtectionBtn);
            this.SortingGroupBox.Controls.Add(this.SortCapacityBtn);
            this.SortingGroupBox.Controls.Add(this.SortDamagePlayersBtn);
            this.SortingGroupBox.Location = new System.Drawing.Point(713, 36);
            this.SortingGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortingGroupBox.Size = new System.Drawing.Size(256, 549);
            this.SortingGroupBox.TabIndex = 0;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Sorting";
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByLabel.Location = new System.Drawing.Point(43, 20);
            this.SortByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(160, 39);
            this.SortByLabel.TabIndex = 11;
            this.SortByLabel.Text = "Sort by ...";
            // 
            // SortByBarrelDamageBtn
            // 
            this.SortByBarrelDamageBtn.Location = new System.Drawing.Point(17, 347);
            this.SortByBarrelDamageBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortByBarrelDamageBtn.Name = "SortByBarrelDamageBtn";
            this.SortByBarrelDamageBtn.Size = new System.Drawing.Size(231, 28);
            this.SortByBarrelDamageBtn.TabIndex = 10;
            this.SortByBarrelDamageBtn.TabStop = false;
            this.SortByBarrelDamageBtn.Text = "Barrel damage";
            this.SortByBarrelDamageBtn.UseVisualStyleBackColor = true;
            this.SortByBarrelDamageBtn.Click += new System.EventHandler(this.SortByBarrelDamageBtn_Click);
            // 
            // SortByVolumeBtn
            // 
            this.SortByVolumeBtn.Location = new System.Drawing.Point(17, 383);
            this.SortByVolumeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortByVolumeBtn.Name = "SortByVolumeBtn";
            this.SortByVolumeBtn.Size = new System.Drawing.Size(231, 28);
            this.SortByVolumeBtn.TabIndex = 9;
            this.SortByVolumeBtn.TabStop = false;
            this.SortByVolumeBtn.Text = "Barrel volume";
            this.SortByVolumeBtn.UseVisualStyleBackColor = true;
            this.SortByVolumeBtn.Click += new System.EventHandler(this.SortByVolumeBtn_Click);
            // 
            // SortByShakeBtn
            // 
            this.SortByShakeBtn.Location = new System.Drawing.Point(17, 311);
            this.SortByShakeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortByShakeBtn.Name = "SortByShakeBtn";
            this.SortByShakeBtn.Size = new System.Drawing.Size(231, 28);
            this.SortByShakeBtn.TabIndex = 8;
            this.SortByShakeBtn.TabStop = false;
            this.SortByShakeBtn.Text = "Shake";
            this.SortByShakeBtn.UseVisualStyleBackColor = true;
            this.SortByShakeBtn.Click += new System.EventHandler(this.SortByShakeBtn_Click);
            // 
            // SortByBuildingHealthBtn
            // 
            this.SortByBuildingHealthBtn.Location = new System.Drawing.Point(17, 276);
            this.SortByBuildingHealthBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortByBuildingHealthBtn.Name = "SortByBuildingHealthBtn";
            this.SortByBuildingHealthBtn.Size = new System.Drawing.Size(231, 28);
            this.SortByBuildingHealthBtn.TabIndex = 7;
            this.SortByBuildingHealthBtn.TabStop = false;
            this.SortByBuildingHealthBtn.Text = "Building health";
            this.SortByBuildingHealthBtn.UseVisualStyleBackColor = true;
            this.SortByBuildingHealthBtn.Click += new System.EventHandler(this.SortByBuildingHealthBtn_Click);
            // 
            // SortBarricadeCapacityBtn
            // 
            this.SortBarricadeCapacityBtn.Location = new System.Drawing.Point(17, 240);
            this.SortBarricadeCapacityBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortBarricadeCapacityBtn.Name = "SortBarricadeCapacityBtn";
            this.SortBarricadeCapacityBtn.Size = new System.Drawing.Size(231, 28);
            this.SortBarricadeCapacityBtn.TabIndex = 6;
            this.SortBarricadeCapacityBtn.TabStop = false;
            this.SortBarricadeCapacityBtn.Text = "Barricade capacity";
            this.SortBarricadeCapacityBtn.UseVisualStyleBackColor = true;
            this.SortBarricadeCapacityBtn.Click += new System.EventHandler(this.SortBarricadeCapacityBtn_Click);
            // 
            // SortVehicleHealthBtn
            // 
            this.SortVehicleHealthBtn.Location = new System.Drawing.Point(17, 204);
            this.SortVehicleHealthBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortVehicleHealthBtn.Name = "SortVehicleHealthBtn";
            this.SortVehicleHealthBtn.Size = new System.Drawing.Size(231, 28);
            this.SortVehicleHealthBtn.TabIndex = 5;
            this.SortVehicleHealthBtn.TabStop = false;
            this.SortVehicleHealthBtn.Text = "Vehicle health";
            this.SortVehicleHealthBtn.UseVisualStyleBackColor = true;
            this.SortVehicleHealthBtn.Click += new System.EventHandler(this.SortVehicleHealthBtn_Click);
            // 
            // SortDamageBuildingsBtn
            // 
            this.SortDamageBuildingsBtn.Location = new System.Drawing.Point(17, 169);
            this.SortDamageBuildingsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortDamageBuildingsBtn.Name = "SortDamageBuildingsBtn";
            this.SortDamageBuildingsBtn.Size = new System.Drawing.Size(231, 28);
            this.SortDamageBuildingsBtn.TabIndex = 0;
            this.SortDamageBuildingsBtn.TabStop = false;
            this.SortDamageBuildingsBtn.Text = "Damage to buildings";
            this.SortDamageBuildingsBtn.UseVisualStyleBackColor = true;
            this.SortDamageBuildingsBtn.Click += new System.EventHandler(this.SortDamageBuildingsBtn_Click);
            // 
            // MixBtn
            // 
            this.MixBtn.Location = new System.Drawing.Point(19, 454);
            this.MixBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(231, 28);
            this.MixBtn.TabIndex = 1;
            this.MixBtn.TabStop = false;
            this.MixBtn.Text = "Mix";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 789);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.ItemStatsGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ResultsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ItemList";
            this.Text = "Item List";
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ItemStatsGroupBox.ResumeLayout(false);
            this.ItemStatsGroupBox.PerformLayout();
            this.SortingGroupBox.ResumeLayout(false);
            this.SortingGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox player_skull_damage;
        private System.Windows.Forms.TextBox player_spine_damage;
        private System.Windows.Forms.TextBox item_capacity;
        private System.Windows.Forms.TextBox armor;
        private System.Windows.Forms.Label BodyDamageLabel;
        private System.Windows.Forms.Label HeadDamageLabel;
        private System.Windows.Forms.Label ProtectionLabel;
        private System.Windows.Forms.Label ItemCapacityLabel;
        private System.Windows.Forms.Label ItemTypeLabel;
        private System.Windows.Forms.TextBox useable;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label ItemType2Label;
        private System.Windows.Forms.Button SortDamagePlayersBtn;
        private System.Windows.Forms.Button SortCapacityBtn;
        private System.Windows.Forms.Button SortProtectionBtn;
        private System.Windows.Forms.GroupBox SortingGroupBox;
        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.TextBox range;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.TextBox structure_damage;
        private System.Windows.Forms.Label BuildingsDamageLabel;
        private System.Windows.Forms.TextBox player_damage;
        private System.Windows.Forms.Label PlayerDamageLabel;
        private System.Windows.Forms.Button SortDamageBuildingsBtn;
        private System.Windows.Forms.TextBox health;
        private System.Windows.Forms.Label ItemHealthLabel;
        private System.Windows.Forms.TextBox engine;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Button SortVehicleHealthBtn;
        private System.Windows.Forms.Button SortBarricadeCapacityBtn;
        private System.Windows.Forms.Button SortByBuildingHealthBtn;
        private System.Windows.Forms.Button SortByShakeBtn;
        private System.Windows.Forms.TextBox shake;
        private System.Windows.Forms.Label ShakeLabel;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Button SortByVolumeBtn;
        private System.Windows.Forms.TextBox damage;
        private System.Windows.Forms.Label BarrelDamageLabel;
        private System.Windows.Forms.Button SortByBarrelDamageBtn;
        private System.Windows.Forms.TextBox IdPrefixTextBox;
        private System.Windows.Forms.Button AllNameIdToClipboard;
        private System.Windows.Forms.Button NameIdToClipboard;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.TextBox CalibersTextBox;
    }
}