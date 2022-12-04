namespace winNews
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
            this.newsSiteComboBox = new System.Windows.Forms.ComboBox();
            this.newsHaber = new System.Windows.Forms.Label();
            this.newsList = new System.Windows.Forms.ListBox();
            this.newsDescription = new System.Windows.Forms.Label();
            this.haberImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.haberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // newsSiteComboBox
            // 
            this.newsSiteComboBox.FormattingEnabled = true;
            this.newsSiteComboBox.Location = new System.Drawing.Point(49, 66);
            this.newsSiteComboBox.Name = "newsSiteComboBox";
            this.newsSiteComboBox.Size = new System.Drawing.Size(244, 24);
            this.newsSiteComboBox.TabIndex = 0;
            this.newsSiteComboBox.SelectedIndexChanged += new System.EventHandler(this.newsSiteComboBox_SelectedIndexChanged);
            // 
            // newsHaber
            // 
            this.newsHaber.AutoSize = true;
            this.newsHaber.Location = new System.Drawing.Point(46, 35);
            this.newsHaber.Name = "newsHaber";
            this.newsHaber.Size = new System.Drawing.Size(94, 17);
            this.newsHaber.TabIndex = 1;
            this.newsHaber.Text = "Haber Siteleri";
            // 
            // newsList
            // 
            this.newsList.FormattingEnabled = true;
            this.newsList.ItemHeight = 16;
            this.newsList.Location = new System.Drawing.Point(26, 121);
            this.newsList.Name = "newsList";
            this.newsList.Size = new System.Drawing.Size(405, 212);
            this.newsList.TabIndex = 2;
            this.newsList.SelectedIndexChanged += new System.EventHandler(this.newsList_SelectedIndexChanged);
            // 
            // newsDescription
            // 
            this.newsDescription.Location = new System.Drawing.Point(483, 282);
            this.newsDescription.Name = "newsDescription";
            this.newsDescription.Size = new System.Drawing.Size(373, 212);
            this.newsDescription.TabIndex = 3;
            this.newsDescription.Text = "Haber Açıklaması";
            this.newsDescription.Click += new System.EventHandler(this.newsDescription_Click);
            // 
            // haberImage
            // 
            this.haberImage.Location = new System.Drawing.Point(486, 12);
            this.haberImage.Name = "haberImage";
            this.haberImage.Size = new System.Drawing.Size(459, 243);
            this.haberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.haberImage.TabIndex = 4;
            this.haberImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 503);
            this.Controls.Add(this.haberImage);
            this.Controls.Add(this.newsDescription);
            this.Controls.Add(this.newsList);
            this.Controls.Add(this.newsHaber);
            this.Controls.Add(this.newsSiteComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.haberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox newsSiteComboBox;
        private System.Windows.Forms.Label newsHaber;
        private System.Windows.Forms.ListBox newsList;
        private System.Windows.Forms.Label newsDescription;
        private System.Windows.Forms.PictureBox haberImage;
    }
}

