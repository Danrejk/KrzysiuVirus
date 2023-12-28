using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ckratka
{
    public partial class Krzysiu : Form
    {
        private bool isDragging = false;
        private int mouseX, mouseY;

        public Krzysiu()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.TopMost = true;

            // RANDOM OBRAZEK
            int rand_num = new Random(Guid.NewGuid().GetHashCode()).Next(1, 48);
            string krzysiu_imgnum = $"krzysiu__{rand_num}_";
            Console.WriteLine(krzysiu_imgnum);

            krzysiu_img.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(krzysiu_imgnum);
            krzysiu_img.SizeMode = PictureBoxSizeMode.StretchImage;

            // RANDOM SIZE
            int rand_size = new Random(Guid.NewGuid().GetHashCode()).Next(50, 250);
            krzysiu_img.Size = new System.Drawing.Size(rand_size, rand_size);

            // RANDOM LOCATION
            int ekran_w = Screen.PrimaryScreen.Bounds.Width;
            int ekran_h = Screen.PrimaryScreen.Bounds.Height;
            int rand_w = new Random(Guid.NewGuid().GetHashCode()).Next(1, ekran_w-rand_size);
            int rand_h = new Random(Guid.NewGuid().GetHashCode()).Next(1, ekran_h-rand_size);
            Console.WriteLine(rand_w +", "+ rand_h);

            this.Location = new System.Drawing.Point(rand_w, rand_h);

            // MOVEMENT
            krzysiu_img.MouseDown += Krzysiu_MouseDown;
            krzysiu_img.MouseUp += Krzysiu_MouseUp;
            krzysiu_img.MouseMove += Krzysiu_MouseMove;
        }

        private void Krzysiu_MouseDown(object sender, MouseEventArgs mysz)
        {
            if (mysz.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = mysz.X;
                mouseY = mysz.Y;
            }
        }
        private void Krzysiu_MouseUp(object sender, MouseEventArgs mysz)
        {
            isDragging = false;
        }
        private void Krzysiu_MouseMove(object sender, MouseEventArgs mysz)
        {
            if (isDragging)
            {
                int deltaX = mysz.X - mouseX;
                int deltaY = mysz.Y - mouseY;

                this.Location = new System.Drawing.Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }
    }
}