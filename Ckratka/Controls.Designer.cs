namespace Ckratka
{
    partial class controls
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
            this.krzysiu_butt = new System.Windows.Forms.Button();
            this.off_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // krzysiu_butt
            // 
            this.krzysiu_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.krzysiu_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krzysiu_butt.Location = new System.Drawing.Point(12, 12);
            this.krzysiu_butt.Name = "krzysiu_butt";
            this.krzysiu_butt.Size = new System.Drawing.Size(210, 110);
            this.krzysiu_butt.TabIndex = 0;
            this.krzysiu_butt.Text = "Krzysiu";
            this.krzysiu_butt.UseVisualStyleBackColor = true;
            this.krzysiu_butt.Click += new System.EventHandler(this.krzysiu_Click);
            // 
            // off_butt
            // 
            this.off_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.off_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.off_butt.Location = new System.Drawing.Point(12, 128);
            this.off_butt.Name = "off_butt";
            this.off_butt.Size = new System.Drawing.Size(210, 110);
            this.off_butt.TabIndex = 1;
            this.off_butt.Text = "Sio!!!";
            this.off_butt.UseVisualStyleBackColor = true;
            this.off_butt.Click += new System.EventHandler(this.off_Click);
            // 
            // controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 249);
            this.Controls.Add(this.off_butt);
            this.Controls.Add(this.krzysiu_butt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "controls";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Krzysiu Virus";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button krzysiu_butt;
        private System.Windows.Forms.Button off_butt;
    }
}

