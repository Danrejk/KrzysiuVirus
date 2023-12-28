namespace Ckratka
{
    partial class Krzysiu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Krzysiu));
            this.krzysiu_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.krzysiu_img)).BeginInit();
            this.SuspendLayout();
            // 
            // krzysiu_img
            // 
            this.krzysiu_img.ErrorImage = ((System.Drawing.Image)(resources.GetObject("krzysiu_img.ErrorImage")));
            this.krzysiu_img.Image = global::Ckratka.Properties.Resources.krzysiu__1_;
            this.krzysiu_img.InitialImage = ((System.Drawing.Image)(resources.GetObject("krzysiu_img.InitialImage")));
            this.krzysiu_img.Location = new System.Drawing.Point(0, 0);
            this.krzysiu_img.Margin = new System.Windows.Forms.Padding(0);
            this.krzysiu_img.Name = "krzysiu_img";
            this.krzysiu_img.Size = new System.Drawing.Size(250, 250);
            this.krzysiu_img.TabIndex = 0;
            this.krzysiu_img.TabStop = false;
            this.krzysiu_img.WaitOnLoad = true;
            // 
            // Krzysiu
            // 
            this.AccessibleName = "Krzysiu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(216, 229);
            this.ControlBox = false;
            this.Controls.Add(this.krzysiu_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Krzysiu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.krzysiu_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox krzysiu_img;
    }
}