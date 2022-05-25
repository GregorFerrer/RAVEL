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
    public partial class Form2 : Form
    {
        //se declara una variable global de tipo soundPlayer
        SoundPlayer sonido = new SoundPlayer();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // se le asigna a la variable sounPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la intruccion de reporducir el sonido al realizar la accion
            sonido.Play();
            //se crea una variable de tipo form y se le asigna como valor un formulario existente
            Form1 pantalla1 = new Form1();
            //se da la instruccion de mostrar el formulario al realizar la accion
            pantalla1.Show();
            //se da la instruccion de cerrar este formulario al realizar la accion
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // se le asigna a la variable sounPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la intruccion de reporducir el sonido al realizar la accion
            sonido.Play();
            //se crea una variable de tipo form y se le asigna como valor un formulario existente
            Form3 pantalla_nivel1 = new Form3();
            //se da la instruccion de mostrar el formulario al realizar la accion
            pantalla_nivel1.Show();
            //se da la instruccion de cerrar este formulario al realizar la accion
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // se le asigna a la variable sounPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la intruccion de reporducir el sonido al realizar la accion
            sonido.Play();
            //se crea una variable de tipo form y se le asigna como valor un formulario existente
            Form4 pantallan_nivel2 = new Form4();
            //se da la instruccion de mostrar el formulario al realizar la accion
            pantallan_nivel2.Show();
            //se da la instruccion de cerrar este formulario al realizar la accion
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // se le asigna a la variable sounPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la intruccion de reporducir el sonido al realizar la accion
            sonido.Play();
            //se crea una variable de tipo form y se le asigna como valor un formulario existente
            Form5 pantallan_nivel3 = new Form5();
            //se da la instruccion de mostrar el formulario al realizar la accion
            pantallan_nivel3.Show();
            //se da la instruccion de cerrar este formulario al realizar la accion
            this.Close();

        }
    }
}
