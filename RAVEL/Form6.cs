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
namespace RAVEL
{
    public partial class Form6 : Form
    {
        SoundPlayer sonido = new SoundPlayer();

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.click_sound_effect;
            Form1 pantalla1 = new Form1();
            sonido.Play();
            pantalla1.Show();
            this.Close();

        }
    }
}
