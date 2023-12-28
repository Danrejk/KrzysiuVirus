using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ckratka
{
    public partial class controls : Form
    {
        public controls()
        {
            InitializeComponent();
            spawner();
            Muzyka muzyka = new Muzyka();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
        }

        private async void spawner()
        {
            while (true)
            {
                Krzysiu krzysiu_obra = new Krzysiu();
                krzysiu_obra.Show();

                await Task.Delay(10000);

                this.Invoke(new Action(() => { this.Visible = false; })); // Update UI safely
            }
        }


        private async void krzysiu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Krzysiu krzysiu_obra = new Krzysiu();
                krzysiu_obra.Show();
                await Task.Delay(1000);
            }
        }
        private void off_Click(object sender, EventArgs e)
        {
            var current = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process.GetProcessesByName(current.ProcessName)
                .Where(t => t.Id != current.Id)
                .ToList()
                .ForEach(t => t.Kill());

            current.Kill();
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
