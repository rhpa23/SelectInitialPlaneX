namespace SelectInitialPlane
{
    partial class UiIcon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Location = new System.Drawing.Point(8, 7);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(206, 146);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.UI_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(206, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "-------------------------";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.UI_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.UI_Click);
            // 
            // UiIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxImage);
            this.Name = "UiIcon";
            this.Size = new System.Drawing.Size(223, 191);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
