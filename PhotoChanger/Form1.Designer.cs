namespace PhotoChanger
{
    partial class Form1
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
            this.ogImage = new System.Windows.Forms.PictureBox();
            this.ogImageUpload = new System.Windows.Forms.Button();
            this.newImage = new System.Windows.Forms.PictureBox();
            this.saveImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ogImage
            // 
            this.ogImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ogImage.Location = new System.Drawing.Point(12, 12);
            this.ogImage.Name = "ogImage";
            this.ogImage.Size = new System.Drawing.Size(329, 216);
            this.ogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ogImage.TabIndex = 0;
            this.ogImage.TabStop = false;
            // 
            // ogImageUpload
            // 
            this.ogImageUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogImageUpload.Location = new System.Drawing.Point(12, 266);
            this.ogImageUpload.Name = "ogImageUpload";
            this.ogImageUpload.Size = new System.Drawing.Size(329, 69);
            this.ogImageUpload.TabIndex = 1;
            this.ogImageUpload.Text = "UPLOAD";
            this.ogImageUpload.UseVisualStyleBackColor = true;
            this.ogImageUpload.Click += new System.EventHandler(this.ogImageUpload_Click);
            // 
            // newImage
            // 
            this.newImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newImage.Location = new System.Drawing.Point(417, 12);
            this.newImage.Name = "newImage";
            this.newImage.Size = new System.Drawing.Size(329, 216);
            this.newImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newImage.TabIndex = 2;
            this.newImage.TabStop = false;
            // 
            // saveImage
            // 
            this.saveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImage.Location = new System.Drawing.Point(417, 266);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(329, 69);
            this.saveImage.TabIndex = 3;
            this.saveImage.Text = "SAVE NEW IMAGE";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upload a new image. This program will then make that image black and white. Just " +
    "like the old days.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.newImage);
            this.Controls.Add(this.ogImageUpload);
            this.Controls.Add(this.ogImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ogImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ogImage;
        private System.Windows.Forms.Button ogImageUpload;
        private System.Windows.Forms.PictureBox newImage;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Label label1;
    }
}

