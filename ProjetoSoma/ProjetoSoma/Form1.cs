using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSoma
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 + n2;
            lblResultado.Text = resultado.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 - n2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 * n2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 / n2;
            lblResultado.Text = resultado.ToString();
        }
    }
}
