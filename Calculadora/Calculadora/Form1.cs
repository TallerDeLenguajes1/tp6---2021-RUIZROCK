using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double n1, n2;
        string operacion;

        Clase_operaciones.Operaciones op = new Clase_operaciones.Operaciones();

        //Boton de numeros y punto

        private void btn_punto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }


        //Boton de operadores

        private void btn_div_Click(object sender, EventArgs e)
        {
            operacion = "/";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            operacion = "*";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            operacion = "-";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }
        private void btn_sum_Click(object sender, EventArgs e)
        {
            operacion = "+";
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        //Boton de funciones clear y igual

        private void btn_c_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(Pantalla.Text);
            double sum, res, pro, div;

            switch (operacion)
            {
                case "+":
                    sum = op.suma(n1,n2);
                    Pantalla.Text = sum.ToString();
                    break;


                case "-":
                    res = op.resta(n1, n2);
                    Pantalla.Text = res.ToString();
                    break;


                case "*":
                    pro = op.producto(n1, n2);
                    Pantalla.Text = pro.ToString();
                    break;


                case "/":
                    div = op.division(n1, n2);
                    Pantalla.Text = div.ToString();
                    break;

            }
        }



    }


}
