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
    public partial class Form5 : Form
    {
        int turno = 1;
        int[,] matriz;
        int puntosplayer1 = 0;
        int puntosplayer2 = 0;
        bool yahayganador;
        //se crea una variable entera para el temporizador
        private int conteo;
        //se crea una variable entera para marcar el tiempo total de una partida
        int conteo_juego;
        SoundPlayer sonido = new SoundPlayer();
 
        public Form5()
        {
            InitializeComponent();
            iniciarjuego();
            // se le asigna un valor a la variable conteo para establecer el tiempo que le restara al temporizador
            conteo = 60;
            // se inicia la variable conteo_juego en 0 para medir el tiempo de una partida en segundos
            conteo_juego = 0;

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
            matriz = new int[5, 5];
            yahayganador = false;

            PicGanador.Image = Properties.Resources.f_11;
            FichasRavel.Controls.Clear();

            //arreglos para mostrar fichas e insertar valores

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
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
            int TamañoMatriz = 5;

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
                timer1.Stop();
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

        private void picReiniciar_Click(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.click_sound_effect;
            sonido.Play();
            //se hace el llamado para iniciar una partida al hacer clic en el boton reinicar limpiando el tablero
            iniciarjuego();
            // se hace el llamado al temporizador para detenerlo
            timer1.Stop();
            //se hacce un llamado al valor mostrado en pantalla y limpiar su contenido
            label3.Focus();
            //se le asigna un valor al temporizador, que es el que mostrara al estar inactivo
            label3.Text = "0";
            // se le asigna nuevamente el valor con el que iniciara el temporizador
            conteo = 60;
            //se le asigna el valor con el que iniciara el relog del juego
            conteo_juego = 0;
            //se da inicio al conteo del reloj del juego
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // se le asigna al siguiente elemento la funcion de restar unidades al conteo
            conteo--;
            //se le asigna a la variable conteo el lugar donde se mostrara dentro de la interfaz
            label3.Text = conteo.ToString();
            //al llegar a 0 el temporizador se detendra mostrando un mensaje en pantalla
            if (conteo == 0)
            {
                timer1.Stop();
                MessageBox.Show("el tiempo termino");
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources.click_sound_effect;
            sonido.Play();
            //el tiempo de juego y el temporizador iniciaran el conteo
            timer1.Start();
            timer2.Start();
        }

        private void FichasRavel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // se le asigna al siguiente elemento la funcion de restar unidades a la variable conteo_juego
            conteo_juego++;
            //se le asigna a la variable conteo_juego el lugar donde se mostrara dentro de la interfaz
            label4.Text = conteo_juego.ToString();
            //se iniciara el conteo
            timer2.Start();
            //al haber un ganador el conteo se detendra
            if (yahayganador == true )
            {
               timer2.Stop();
            
            }
            
        }
    }
}
