using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        /*numeros que se ingresen*/

        double n1;
        double n2;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        operaciones op = new operaciones();

        /*INTERFACE*/
        /*operaciones,resultado, y funcion clear*/

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();       //borra lo escrito en pantalla

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            n1 = double.Parse(textBox1.Text);  //convierte al primer numero de string a double
            textBox1.Clear();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            operacion= "*";
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            operacion =  "-";
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            operacion =  "+";
            n1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        /*numeros y punto decimal*/

        private void btncoma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        /*mostrador de escritura*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(textBox1.Text);

            double sum,res,pro,div;

           switch (operacion)
            {
                case "+":   sum=op.sumar(n1, n2);
                    textBox1.Text = sum.ToString();
                    break;

                case "-":   res=op.resta(n1, n2);
                            textBox1.Text = res.ToString();
                    break;

                case "*":   pro=op.producto(n1, n2);
                            textBox1.Text = pro.ToString();
                    break;

                case "/":   div=op.division(n1, n2);
                            textBox1.Text = div.ToString();
                    break;
            }
            
        }
    }
}
