
namespace UIF
{
    partial class VehicleCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleCategories));
            this.VehiclesGroup = new System.Windows.Forms.GroupBox();
            this.VehiclesCategoriesLabel = new System.Windows.Forms.Label();
            this.HelicoptersBtn = new System.Windows.Forms.Button();
            this.PlanesBtn = new System.Windows.Forms.Button();
            this.AllVehiclesBtn = new System.Windows.Forms.Button();
            this.BoatsBtn = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.VehiclesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehiclesGroup
            // 
            this.VehiclesGroup.Controls.Add(this.Cars);
            this.VehiclesGroup.Controls.Add(this.BoatsBtn);
            this.VehiclesGroup.Controls.Add(this.AllVehiclesBtn);
            this.VehiclesGroup.Controls.Add(this.PlanesBtn);
            this.VehiclesGroup.Controls.Add(this.HelicoptersBtn);
            this.VehiclesGroup.Location = new System.Drawing.Point(12, 36);
            this.VehiclesGroup.Name = "VehiclesGroup";
            this.VehiclesGroup.Size = new System.Drawing.Size(177, 163);
            this.VehiclesGroup.TabIndex = 0;
            this.VehiclesGroup.TabStop = false;
            this.VehiclesGroup.Text = "Vehicles";
            // 
            // VehiclesCategoriesLabel
            // 
            this.VehiclesCategoriesLabel.AutoSize = true;
            this.VehiclesCategoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VehiclesCategoriesLabel.Location = new System.Drawing.Point(12, 9);
            this.VehiclesCategoriesLabel.Name = "VehiclesCategoriesLabel";
            this.VehiclesCategoriesLabel.Size = new System.Drawing.Size(178, 24);
            this.VehiclesCategoriesLabel.TabIndex = 1;
            this.VehiclesCategoriesLabel.Text = "Vehicles Categories";
            // 
            // HelicoptersBtn
            // 
            this.HelicoptersBtn.Location = new System.Drawing.Point(6, 19);
            this.HelicoptersBtn.Name = "HelicoptersBtn";
            this.HelicoptersBtn.Size = new System.Drawing.Size(165, 23);
            this.HelicoptersBtn.TabIndex = 0;
            this.HelicoptersBtn.Text = "Helicopters";
            this.HelicoptersBtn.UseVisualStyleBackColor = true;
            this.HelicoptersBtn.Click += new System.EventHandler(this.HelicoptersBtn_Click);
            // 
            // PlanesBtn
            // 
            this.PlanesBtn.Location = new System.Drawing.Point(6, 48);
            this.PlanesBtn.Name = "PlanesBtn";
            this.PlanesBtn.Size = new System.Drawing.Size(165, 23);
            this.PlanesBtn.TabIndex = 1;
            this.PlanesBtn.Text = "Planes";
            this.PlanesBtn.UseVisualStyleBackColor = true;
            this.PlanesBtn.Click += new System.EventHandler(this.PlanesBtn_Click);
            // 
            // AllVehiclesBtn
            // 
            this.AllVehiclesBtn.Location = new System.Drawing.Point(6, 135);
            this.AllVehiclesBtn.Name = "AllVehiclesBtn";
            this.AllVehiclesBtn.Size = new System.Drawing.Size(165, 23);
            this.AllVehiclesBtn.TabIndex = 2;
            this.AllVehiclesBtn.Text = "All vehicles";
            this.AllVehiclesBtn.UseVisualStyleBackColor = true;
            this.AllVehiclesBtn.Click += new System.EventHandler(this.AllVehiclesBtn_Click);
            // 
            // BoatsBtn
            // 
            this.BoatsBtn.Location = new System.Drawing.Point(6, 77);
            this.BoatsBtn.Name = "BoatsBtn";
            this.BoatsBtn.Size = new System.Drawing.Size(165, 23);
            this.BoatsBtn.TabIndex = 3;
            this.BoatsBtn.Text = "Boats";
            this.BoatsBtn.UseVisualStyleBackColor = true;
            this.BoatsBtn.Click += new System.EventHandler(this.BoatsBtn_Click);
            // 
            // Cars
            // 
            this.Cars.Location = new System.Drawing.Point(6, 106);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(165, 23);
            this.Cars.TabIndex = 4;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = true;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // VehicleCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 211);
            this.Controls.Add(this.VehiclesCategoriesLabel);
            this.Controls.Add(this.VehiclesGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VehicleCategories";
            this.Text = "Vehicle Categories";
            this.VehiclesGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox VehiclesGroup;
        private System.Windows.Forms.Label VehiclesCategoriesLabel;
        private System.Windows.Forms.Button PlanesBtn;
        private System.Windows.Forms.Button HelicoptersBtn;
        private System.Windows.Forms.Button AllVehiclesBtn;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button BoatsBtn;
    }
}