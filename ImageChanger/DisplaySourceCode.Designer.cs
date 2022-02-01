
namespace ImageChanger
{
    partial class DisplaySourceCode
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
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.lighGrayDisplay = new System.Windows.Forms.PictureBox();
            this.uploadImage = new System.Windows.Forms.Button();
            this.lightGrayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lighGrayDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(30, 25);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(324, 342);
            this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // lighGrayDisplay
            // 
            this.lighGrayDisplay.Location = new System.Drawing.Point(380, 25);
            this.lighGrayDisplay.Name = "lighGrayDisplay";
            this.lighGrayDisplay.Size = new System.Drawing.Size(401, 235);
            this.lighGrayDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lighGrayDisplay.TabIndex = 2;
            this.lighGrayDisplay.TabStop = false;
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(106, 387);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(194, 106);
            this.uploadImage.TabIndex = 4;
            this.uploadImage.Text = "UploadImage";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // lightGrayButton
            // 
            this.lightGrayButton.Location = new System.Drawing.Point(505, 266);
            this.lightGrayButton.Name = "lightGrayButton";
            this.lightGrayButton.Size = new System.Drawing.Size(144, 65);
            this.lightGrayButton.TabIndex = 7;
            this.lightGrayButton.Text = "Light Gray";
            this.lightGrayButton.UseVisualStyleBackColor = true;
            this.lightGrayButton.Click += new System.EventHandler(this.lightGrayButton_Click);
            // 
            // DisplaySourceCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 550);
            this.Controls.Add(this.lightGrayButton);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.lighGrayDisplay);
            this.Controls.Add(this.originalImage);
            this.Name = "DisplaySourceCode";
            this.Text = "Display Portal";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lighGrayDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox lighGrayDisplay;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.Button lightGrayButton;
    }
}

