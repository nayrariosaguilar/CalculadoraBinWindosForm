using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculadoraBin
{
    public partial class Calculadora : Form
    {
        //@NR Lista de carácteres con los que jugaremos
        List<char> NumBinarios = new List<char>();

        public Calculadora()
        {
            InitializeComponent();
        }

        //@NR en este caso como modificamos todo lo que se ve en pantalla a través de los botones,
        //@NR crearemos un método que actualize el textBox durante todo el programa
        public void ActualizarPantalla()
        {
            //@NR debemos de acceder al contenido de la lista a través de ToArray
            Pantalla.Text = new string(NumBinarios.ToArray());
        }


        public void Button1_Click(object sender, EventArgs e)
        {
            //@NR la condición para añadir un numero
            //@NR que sea más pequeño que 8
            if (NumBinarios.Count < 8)
            {
                NumBinarios.Add('0');
                //@NR despues de cada cambio actualizamos la pantalla
                ActualizarPantalla();
            }
            else
            {
                //@NR ventana personalizada que muestra el error
                MessageBox.Show("No puedes introducir más de 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        public void button2_Click(object sender, EventArgs e)
        {
            //@NR la condición para añadir un numero
            //@NR que sea más pequeño que 8

            if (NumBinarios.Count < 8)
            {
                NumBinarios.Add('1');
                //@NR despues de cada cambio actualizamos la pantalla
                ActualizarPantalla();
            }
            else
            {
                //@NR ventana personalizada que muestra el error
                MessageBox.Show("No puedes introducir más de 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            // @NR la única condición para convertir de binario a decimal esque sean 8 digítos
            if (NumBinarios.Count == 8)
            {
                //@NR Convert espera recibir un String por eso instanciamos una cadena de nuestra lista
                string binario = new string(NumBinarios.ToArray());

                try
                {
                    //NR el segundo parametro indica la base, y devuelve un entero "casteado"
                    int baseDecimal = Convert.ToInt32(binario, 2);

                    //@NR debemos de limpiar la lista, para que no haga futuros calculos incorrectos
                    NumBinarios.Clear();

                    //@NR mostramos por pantalla el resultado de la conversión, debemos castear a String
                    Pantalla.Text = baseDecimal.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            //@NR Mostramos un mensaje de error si no cumple la condición
            else if (NumBinarios.Count < 8)
            {
                MessageBox.Show("Deben ser EXACTAMENTE 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        public void button4_Click(object sender, EventArgs e)
        {
            //@NR botón encargado de reiniciar el programa
            //@NR borra la lista y actualiza la pantalla
            NumBinarios.Clear();
            ActualizarPantalla();
        }


    }
}
