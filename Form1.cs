using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_GitHub_1oDAWSemi_Calculadora
{
    public partial class Form1 : Form
    {
        /**
         * @Author: Tonet / S3ll4rd0 (Antonio Nicolás Salmerón Rubio)
         * 
         * @Variables: Declaro 3 variables double para que acepten decimales, 
         * con las que trabajaremos en todo el programa.
         * Declaro 1 variable operador string que servirá para añadir en ella todos los 
         * números con las pulsaciones de botones, y hasta que no queramos operar, en 
         * cuyo caso lo convertiremos a double para trabajar con el valor que contenga.
         * Declaro una variable boleana para almacenar si el operador tiene coma o no,
         * que nos servirá para poder comprobar que cada operador que introduzcamos solo
         * pueda tener 1 coma.
         */

        private double operador1;
        private double operador2;
        private double resultado;
        private string operador;
        private bool tieneComa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             *  @Author: Tonet / S3ll4rd0 (Antonio Nicolás Salmerón Rubio)
             *  
             *  @Method: Este método inicia las variables privadas y pone en las pantallas,
             *  el valor de 0 en ambas, tanto la de resultado, que es la que va a mostrar el 
             *  resultado de todas las operaciones consecutivas, por ejemplo si vamos sumando
             *  muchos números, esa pantalla mostrará el valor final de todas las operaciones,
             *  como en la pantalla de operador, que es la pantalla que contendrá en pantalla
             *  el valor del operador con el que estamos trabajando en el momento.
             *  
             *  @Variables: operadores definidos como double para que acepten decimales,
             *  y una variable resultado que almacenará el resultado de la operació entre ambas.
             *  Cuando se introduzcan más de dos operadores, resultado almacenará el valor de 
             *  todo lo calculado, mientras que operador1 se vaciará para poder recibir el nuevo 
             *  operador que introduzcamos, y operador2 mantendrá el valor que ya tenemos para 
             *  hacer las debidas operaciones.
             */

            operador1 = 0;
            operador2 = 0;
            resultado = 0;
            operador = "";
            tieneComa = false;
            textBoxOperador.Text = "0";
            textBoxResultado.Text = "0";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            /**
             *  @Author: Tonet / S3ll4rd0 (Antonio Nicolás Salmerón Rubio)
             *  
             *  @Method: Este método comprueba si solo hay un 0 en el operador, no añadir
             *  más, y solo añadirá ceros en los supuestos de que el operador sea un "0,", 
             *  es decir, un cero con coma, o que el operador sea mayor a un caracter, y que
             *  este caracter sea distinto a 0.
             */

                // Obtengo el valor del textBox Operador y lo almaceno en el string operador
            operador = textBoxOperador.Text;
            
                // Si el operador es solo un cero, no añado nada más, sigue siendo solo un cero
            if (operador == "0")
            {
                operador = "0";
            }
                // Si el string operador contiene un 0 seguido de una coma, entonces si le permito 
                // añadir todos los ceros que desee el usuario
            else if (operador == "0,")
            {
                operador += "0";
            }
                // Si el operador es mayor a 1 carácter, y este carácter es distinto a 0,
                // Por ejemplo, un "6", entonces si añado nuevos ceros al string operador
            else if (operador.Length >= 1 && operador != "0")
            {
                operador += "0";
            }

                // Imprimo en pantalla del operador el numero obtenido después de las operaciones.
            textBoxOperador.Text = operador;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            /**
             *  @Author: Tonet / S3ll4rd0 (Antonio Nicolás Salmerón Rubio)
             *  
             *  @Method: Este método obtiene el contenido del text box operador, lo pasa al 
             *  string operador, le añade un 1, y lo vuelve a mostrar en el text box.
             */
            if (textBoxOperador.Text == "0") 
            {
                textBoxOperador.Text = "1";
            }else
            { 
                // Obtengo el valor total del text Box del operador
            operador = textBoxOperador.Text;
                // Añado un 1 al operador
            operador += "1";
                // Vuelvo a mostrar el valor actualizado en el text box
            textBoxOperador.Text = operador;
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            /*Este método añadimos un 2 a la pantalla, comprobamos que no tenga nada el textbox y si lo tiene añadimos el 4*/
            if (textBoxOperador.Text == "0")
            {
                textBoxOperador.Text = "2";
            }
            else
            {
                textBoxOperador.Text += "2";
            }

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            /**
             *  @Author: Jose Manuel
             *  
             *  @Method: Este método añade un 4 al textBoxOperador.
             *  Si el contenido del textBoxOperador es 0, lo elimina y pone un 4. 
             *  
             */

            if (textBoxOperador.Text == "0")
            {
                textBoxOperador.Text = "4";
            }
            else
            {
                textBoxOperador.Text += "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            /**
            *  @Author: Anabel
            *  
            *  @Method: Este método obtiene el valor del textBoxOperador. En caso de qeu el contenido sea 0, 
            *  lo elimina y pone un 7. Si tiene otro valor, añadirá el 7 a dicho valor. 
            *  Devuelve resultado por textBoxOperador
            *  
            */
            if (textBoxOperador.Text == "0")
            {
                textBoxOperador.Text = "7";
            }
            else 
            {
                operador=textBoxOperador.Text;
                operador += "7";
                textBoxOperador.Text = operador;
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            /**
            *  @Author: Ivan Ibáñez
            *  
            *  @Method: Este método añade un 9 al textBoxOperador.
            *  Si el contenido del textBoxOperador es 0, lo elimina y pone un 9. Si tiene otro valor 
            *  concatena el textBoxOperador con un nueve.
            */
            if (textBoxOperador.Text == "0")
            {
                textBoxOperador.Text = "9";
            }
            else if (!textBoxOperador.Text.Equals("0"))
            {
                textBoxOperador.Text += "9";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            /**
            *  @Author: Ivan Ibáñez
            *  
            *  @Method: Este método añade el textBoxOperador al textBoxResultado acompañado del simbolo de multiplicar x.
            *  Si el operador1 es 0 es que es el primer operador que se introduce y pasa el contenido del textboxOperador
            *  al textBoxResultado concatenado con el simbolo "x".
            *  Si operador1 es distinto de 0 significa que es el segundo operador que se introduce con lo que se agrega a
            *  operador2 el valor del textBoxOperador. 
            */

            if (operador1 == 0)
            {
                operador1 = Convert.ToDouble(textBoxOperador.Text);
                textBoxResultado.Text = textBoxOperador.Text + " x";
                textBoxOperador.Text = "0";

            }
            else if (operador1 != 0)
            {
                operador2 = Convert.ToDouble(textBoxOperador.Text);
            }

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {

        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            /**
             *  @Author: Jose Manuel
             *  
             *  @Method: Este método comprueba que hayan números en el textBoxOperador.
             *  Si hay, guarda en la variable operador1 lo que hay en textBoxOperador
             *  y en la variable operador el carácter ^.
             *  Además pone un 0 en textBoxOperador.
             *  
             */

            if (textBoxOperador.Text != "")
            {
                operador1 = Convert.ToDouble(textBoxOperador.Text);
                operador = "^";
                textBoxOperador.Text = "0";
            }
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {

        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
