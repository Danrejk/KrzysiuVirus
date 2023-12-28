using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ckratka
{
    public partial class Muzyka : Form
    {
        public Muzyka()
        {
            InitializeComponent();
            PlayShit();
        }

        private async void PlayShit()
        {
            while (true)
            {
                int rand_num = new Random(Guid.NewGuid().GetHashCode()).Next(1, 25);
                string piosenka = $"music__{rand_num}_";

                System.IO.Stream rand_music = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(piosenka);
                System.Media.SoundPlayer muzyka = new SoundPlayer(rand_music);

                await Task.Run(() =>
                {
                    muzyka.PlaySync();
                });
            }
        }

    }
}
