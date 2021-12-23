
namespace UIF
{
    partial class Folders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Folders));
            this.PlusFldrBtn = new System.Windows.Forms.PictureBox();
            this.OpenFldrBtn = new System.Windows.Forms.PictureBox();
            this.MinusFldrBtn = new System.Windows.Forms.PictureBox();
            this.FoldersListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlusFldrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFldrBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusFldrBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // PlusFldrBtn
            // 
            this.PlusFldrBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlusFldrBtn.Image")));
            this.PlusFldrBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("PlusFldrBtn.InitialImage")));
            this.PlusFldrBtn.Location = new System.Drawing.Point(567, 12);
            this.PlusFldrBtn.Name = "PlusFldrBtn";
            this.PlusFldrBtn.Size = new System.Drawing.Size(24, 23);
            this.PlusFldrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlusFldrBtn.TabIndex = 12;
            this.PlusFldrBtn.TabStop = false;
            this.PlusFldrBtn.Click += new System.EventHandler(this.PlusFldrBtn_Click);
            // 
            // OpenFldrBtn
            // 
            this.OpenFldrBtn.Image = global::UIF.Properties.Resources.folder_icon;
            this.OpenFldrBtn.InitialImage = global::UIF.Properties.Resources.folder_icon;
            this.OpenFldrBtn.Location = new System.Drawing.Point(567, 70);
            this.OpenFldrBtn.Name = "OpenFldrBtn";
            this.OpenFldrBtn.Size = new System.Drawing.Size(24, 23);
            this.OpenFldrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFldrBtn.TabIndex = 14;
            this.OpenFldrBtn.TabStop = false;
            this.OpenFldrBtn.Click += new System.EventHandler(this.OpenFldrBtn_Click);
            // 
            // MinusFldrBtn
            // 
            this.MinusFldrBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinusFldrBtn.Image")));
            this.MinusFldrBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("MinusFldrBtn.InitialImage")));
            this.MinusFldrBtn.Location = new System.Drawing.Point(567, 41);
            this.MinusFldrBtn.Name = "MinusFldrBtn";
            this.MinusFldrBtn.Size = new System.Drawing.Size(24, 23);
            this.MinusFldrBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinusFldrBtn.TabIndex = 13;
            this.MinusFldrBtn.TabStop = false;
            this.MinusFldrBtn.Click += new System.EventHandler(this.MinusFldrBtn_Click);
            // 
            // FoldersListBox
            // 
            this.FoldersListBox.FormattingEnabled = true;
            this.FoldersListBox.Location = new System.Drawing.Point(12, 12);
            this.FoldersListBox.Name = "FoldersListBox";
            this.FoldersListBox.Size = new System.Drawing.Size(549, 124);
            this.FoldersListBox.TabIndex = 16;
            // 
            // Folders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 147);
            this.Controls.Add(this.FoldersListBox);
            this.Controls.Add(this.PlusFldrBtn);
            this.Controls.Add(this.OpenFldrBtn);
            this.Controls.Add(this.MinusFldrBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Folders";
            this.Text = "Folders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Folders_FormClosing);
            this.Load += new System.EventHandler(this.Folders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlusFldrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFldrBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusFldrBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PlusFldrBtn;
        private System.Windows.Forms.PictureBox OpenFldrBtn;
        private System.Windows.Forms.PictureBox MinusFldrBtn;
        private System.Windows.Forms.CheckedListBox FoldersListBox;
    }
}