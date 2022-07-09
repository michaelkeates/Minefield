
namespace MinefieldV2
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.studentlbl = new System.Windows.Forms.Label();
            this.hideAboutBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentlbl
            // 
            this.studentlbl.AutoSize = true;
            this.studentlbl.Location = new System.Drawing.Point(61, 96);
            this.studentlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentlbl.Name = "studentlbl";
            this.studentlbl.Size = new System.Drawing.Size(264, 13);
            this.studentlbl.TabIndex = 7;
            this.studentlbl.Text = "Michael Keates (23009273) HND Programming 2 CW1";
            // 
            // hideAboutBtn
            // 
            this.hideAboutBtn.Location = new System.Drawing.Point(154, 122);
            this.hideAboutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hideAboutBtn.Name = "hideAboutBtn";
            this.hideAboutBtn.Size = new System.Drawing.Size(75, 23);
            this.hideAboutBtn.TabIndex = 4;
            this.hideAboutBtn.Text = "Close";
            this.hideAboutBtn.UseVisualStyleBackColor = true;
            this.hideAboutBtn.Click += new System.EventHandler(this.hideAboutBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MinefieldV2.Properties.Resources.cc;
            this.pictureBox2.Location = new System.Drawing.Point(265, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MinefieldV2.Properties.Resources.USW_logo_colour_BILNGUAL;
            this.pictureBox1.Location = new System.Drawing.Point(-44, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(395, 158);
            this.Controls.Add(this.studentlbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hideAboutBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentlbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hideAboutBtn;
    }
}