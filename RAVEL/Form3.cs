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
    public partial class Form3 : Form
    {
        
        int turno = 1;
        // se crea una variable matriz que servira de matriz
        int[,] matriz;
        //se declaran las variables acumuladoras del puntaje de ambos jugadores
        int puntosplayer1 = 0;
        int puntosplayer2 = 0;
        // se declara la bariable boleana para determinar el fin de la partida
        bool yahayganador;
        //se declara una variable global de tipo soundPlayer
        SoundPlayer sonido = new SoundPlayer();
        public Form3()
        {
            InitializeComponent();
            //hace el llamado de la instruccion inciar juego
            iniciarjuego();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // se le asigna a la variable soundPlayer el componente de audio que deve reproducir
            sonido.Stream = Properties.Resources.click_sound_effect;
            //se da la instruccion de de reproducir e sonido al realizar la accion
            sonido.Play();
            //se crea una variavle de tipo form a la que se le asigna como valor un formulario existente
            Form2 pantalla_seleccion_nivel = new Form2();
            //se da la instruccion de mostrar el formulario al realizar esta accion
            pantalla_seleccion_nivel.Show();
            //se da la instruccion de cerrar este formulario al realizar la accion
            this.Close();
        }

        public void iniciarjuego()
        {
            // inicializar las variables y la partida

            turno = 1;
            matriz = new int[3, 3];
            yahayganador = false;

            PicGanador.Image = Properties.Resources.f_11;
            FichasRavel.Controls.Clear();


            //var permite declarar una variable local dentro de un método o un bucle sin indicar explícitamente el tipo

            // esta matiz se encargara de la lectura de datos entrantes y los adyacentes
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)

                {
                    //las fichas tendran las siguientes propiedades para poder interactuar con el, usuario

                    //se crea variables a las que se le asignas imagenes inportadas en el proyecto 
                    var FichaJuego = new PictureBox();
                    //a la vriable ficha se le asigna la imagen importada en el proyexto
                    FichaJuego.Image = Properties.Resources.f_11;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    //al seleccionar una casilla de la matriz se iniciara el juego
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
            //se identifica la posicion que tiene una ficha tras la lectura de la matris en cada fila y columna
            string[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            matriz[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna);
            //se intercambian los turnos despues de cada jugada
            turno = (turno == 1) ? 2 : 1;
        }

        public void VerificarJuego(int Fila, int Columna)
        {
            //se verifica si las fichas completaron todas las filas y columnas
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamañoMatriz = 3;


            for (var i = 0; i < TamañoMatriz; i++)
            {
                for (var j = 0; j < TamañoMatriz; j++)
                {   //se verifica si hay llenas casillas de forma horizontal con la misma ficha
                    if (i == Fila)
                    {
                        if (matriz[i, j] == turno)
                        {
                            GanoFilas++;
                        }
                    }

                    //se verifica si hay llenas casillas de forma vertical con la misma ficha
                    if (j == Columna)
                    {
                        if (matriz[i, j] == turno)
                        {
                            GanoColumnas++;
                        }
                    }
                    //se verifica si hay llenas casillas de en la horizontal principal con la misma ficha
                    if (i == j)
                    {
                        if (matriz[i, j] == turno)
                        {
                            DiagonalPrincipal++;

                        }

                    }
                    //se verifica si hay llenas casillas de en la horizontal inversa con la misma ficha
                    if ((i + j) == (TamañoMatriz - 1))
                    {
                        
                        if (matriz[i, j] == turno)
                        {
                            DiagonalInversa++;
                        }

                    }
                }

            }
            // se valida si las filas, columnas o diagonales estan llenas con una ficha para que de esta forma se declare un ganador
            if ((GanoFilas == TamañoMatriz) || (GanoColumnas == TamañoMatriz) || (DiagonalInversa == TamañoMatriz) || (DiagonalPrincipal == TamañoMatriz))
            {
                yahayganador = true;
            }

            if (yahayganador)
            {
                //en el caso de haber un ganador se mostrara la ficha del ganador
                PicGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
                
                 //si el jugador fue ganador se le asignaan puntos de forma acumulatica
                if (turno == 1)
                {
                    puntosplayer1++;
                    lblplayer1.Text = puntosplayer1.ToString();
                }
                //si el jugador fue ganador se le asignaan puntos de forma acumulatica
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
        }
    }
}