using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_Basicos_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 / num2;
            txtResultado.Text = resultado.ToString();

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Declaração de váriáveis do tipo double: num1, num2 e resultado
            double num1, num2, resultado;
            /* num1 e num2 recebe conteúdo do textbox
             * (txtNum1.Text e txtNum2.Text)
             * Convert.ToDouble é necessário para que seja convertido
             * o conteúdo do textbox para o número */
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            // Variável resultado = recebe o conteúdo de num1 + num2 e realiza o cálculo
            resultado = num1 + num2;
            // txtResultado.text = recebe conteúdo da variável resultado e converte em número
            txtResultado.Text = resultado.ToString();

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
