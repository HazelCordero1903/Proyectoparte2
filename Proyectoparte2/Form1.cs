namespace Proyectoparte2
{
    public partial class Form1 : Form
    {
        int a = 0, b = 0, resultado = 0;
        int opee = 0, limite = 11, modoJugadores = 1;
        int erroresTotales = 0, jugadores = 1;
        char operador = ' ';
        int[,] matriz = new int[2, 3];
        Boolean jugador = false;

        public Form1()

        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Seleccion_Operacion()
        {
            a = Random.Shared.Next(1, limite);
            b = Random.Shared.Next(1, limite);
            opee = Random.Shared.Next(1, 5);

            switch (opee)
            {
                case 1:
                    operador = '+';
                    resultado = a + b;
                    break;

                case 2:
                    operador = '-';
                    resultado = a - b;
                    break;

                case 3:
                    operador = '*';
                    resultado = a * b;
                    break;

                case 4:
                    operador = '/';
                    resultado = a / b;
                    break;

                default:
                    break;
            }
            n1.Text = a.ToString();
            n2.Text = b.ToString();
            op.Text = operador.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbJugadores.Items.Add("1 jugador");
            cbJugadores.Items.Add("2 jugadores");
            cbJugadores.SelectedIndex = 0;

            Seleccion_Operacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jugador == false ? "Turno del Jugador 1" : "Turno del Jugador 2");
            if (float.Parse(tresultado.Text).Equals(resultado))

            {
                MessageBox.Show("Correcto");
                laciertos.Text = (int.Parse(laciertos.Text) + 1).ToString();
                lpuntaje.Text = (int.Parse(lpuntaje.Text) + 5).ToString();

                if (jugador == false)
                {
                    matriz[0, 0] += 5;
                    matriz[0, 1] += 1;
                    
                }
                else
                {
                    matriz[1, 0] += 5;
                    matriz[1, 1] += 1;
                   
                }
            }
            else
            {
                MessageBox.Show($"Incorrecto. El resultado correcto es {resultado}");
                lerrores.Text = (int.Parse(lerrores.Text) + 1).ToString();

                if (jugador == false)
                {
                    matriz[0, 2] += 1;
                }
                else
                {
                    matriz[1, 2] += 1;
                }
            }
            if (modoJugadores == 2)
            {
                jugador = !jugador;
            }
            Seleccion_Operacion();
        }

        private void cbJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            modoJugadores = cbJugadores.SelectedIndex + 1;
            jugador = false;
            matriz = new int[2, 3];
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jugador 1");
            MessageBox.Show("Puntos: " + matriz[0, 0]);
            MessageBox.Show("Aciertos: " + matriz[0, 1]);
            MessageBox.Show("Errores: " + matriz[0, 2]);

            if (cbJugadores.SelectedIndex == 1)
            {
                MessageBox.Show("Jugador 2");
                MessageBox.Show("Puntos: " + matriz[1, 0]);
                MessageBox.Show("Aciertos: " + matriz[1, 1]);
                MessageBox.Show("Errores: " + matriz[1, 2]);
            }
        }
        }
    }

