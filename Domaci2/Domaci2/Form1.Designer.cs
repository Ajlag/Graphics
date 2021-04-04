namespace Domaci2
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
            this.Crtaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Crtaj
            // 
            this.Crtaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crtaj.Location = new System.Drawing.Point(194, 618);
            this.Crtaj.Name = "Crtaj";
            this.Crtaj.Size = new System.Drawing.Size(181, 82);
            this.Crtaj.TabIndex = 0;
            this.Crtaj.Text = "Crtaj";
            this.Crtaj.UseVisualStyleBackColor = true;
            this.Crtaj.Click += new System.EventHandler(this.Crtaj_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Domaci2.Properties.Resources.v1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(582, 800);
            this.panel1.MinimumSize = new System.Drawing.Size(582, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 600);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Crtaj);
            this.MaximumSize = new System.Drawing.Size(625, 775);
            this.MinimumSize = new System.Drawing.Size(624, 775);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Crtaj;
        private System.Windows.Forms.Panel panel1;
    }
}

