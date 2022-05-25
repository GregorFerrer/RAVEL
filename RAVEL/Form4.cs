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
    public partial class Form4 : Form
    {
        int turno = 1;
        int[,] matriz;
        int puntosplayer1 = 0;
        int puntosplayer2 = 0;
        bool yahayganador;
        SoundPlayer sonido = new SoundPlayer();

        public Form4()
        {
            InitializeComponent();
            iniciarjuego();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.click_sound_effect;
            sonido.Play();
            Form2 pantalla_seleccion_nivel = new Form2();
            pantalla_seleccion_nivel.Show();
            this.Close();
        }

        public void iniciarjuego()
        {
            // inicializar las variables y la partida

            turno = 1;
            matriz = new int[4, 4];
            yahayganador = false;

            PicGanador.Image = Properties.Resources.f_11;
            FichasRavel.Controls.Clear();

            //arreglos para mostrar fichas e insertar valores

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.f_11;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += jugar;
                    FichasRavel.Controls.Add(FichaJuego, j, i);
                    matriz[i, j] = 0;

                }

            }

        }

        private void jugar(object sender, EventArgs e)
        {
            var FichaSeleccionadaUsuario = (PictureBox)sender;
            FichaSeleccionadaUsuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
            string[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            matriz[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna);
            turno = (turno == 1) ? 2 : 1;

        }

        public void VerificarJuego(int Fila, int Columna)
        {
            //se verifica si las fichas completaron todas las filas y columnas
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamañoMatriz = 4;

            for (var i = 0; i < TamañoMatriz; i++)
            {
                for (var j = 0; j < TamañoMatriz; j++)
                {
                    if (i == Fila)
                    {
                        if (matriz[i, j] == turno)
                        {
                            GanoFilas++;

                        }

                    }

                    if (j == Columna)
                    {
                        if (matriz[i, j] == turno)
                        {
                            GanoColumnas++;

                        }

                    }

                    if (i == j)
                    {
                        if (matriz[i, j] == turno)
                        {
                            DiagonalPrincipal++;

                        }

                    }

                    if ((i + j) == (TamañoMatriz - 1))
                    {
                        if (matriz[i, j] == turno)
                        {
                            DiagonalInversa++;
                        }

                    }

                }

            }

            if ((GanoFilas == TamañoMatriz) || (GanoColumnas == TamañoMatriz) || (DiagonalInversa == TamañoMatriz) || (DiagonalPrincipal == TamañoMatriz))
            {
                yahayganador = true;
            }

            if (yahayganador)
            {
                PicGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
                if (turno == 1)
                {
                    puntosplayer1++;
                    lblplayer1.Text = puntosplayer1.ToString();
                }
                else
                {
                    puntosplayer2++;
                    lblplayer2.Text = puntosplayer2.ToString();

                }
            }
        }

        private void picReiniciar_Click_1(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.click_sound_effect;
            sonido.Play();
            iniciarjuego();
        }
    }
}
