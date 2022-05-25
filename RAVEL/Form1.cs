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
    public partial class Form1 : Form
    {
        // se declara una variavle global de tipo soundPlayer
        SoundPlayer sonido = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // se le asigna a la variable soundPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            // se da la intruccion de reproducir el audio a realizar la accion
            sonido.Play();
            // se da la instruccion de cerrar el programa al realizar
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se crea una variable  de tipo form asignandole como valor un formulario existente
            Form2 PantallaSeleccionDeNivel = new Form2();
            // // se le asigna a la variable soundPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la intruccion de reproducir el audio a realizar la accion
            sonido.Play();
            //se da la intruccion de mostrar el formulario al realizar la accion
            PantallaSeleccionDeNivel.Show();
            //al realizar la accion se ocultara el formulario de diseño actual 
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // se le asigna a la variable soundPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la intruccion de reproducir el audio a realizar la accion
            sonido.Play();
            //se crea una variable  de tipo form asignandole como valor un formulario existente
            Form6 PantallaGuia = new Form6();
            //se da la intruccion de mostrar el formulario al realizar la accion
            PantallaGuia.Show();
            //al realizar la accion se ocultara el formulario de diseño actual 
            this.Hide();
        }
    }
}
