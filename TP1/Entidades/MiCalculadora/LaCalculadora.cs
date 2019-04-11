using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblLabel.Text = "";
            cmbOperador.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblLabel.Text = Convert.ToString(resultado);
        }

        private static double Operar(string Numero1, string Numero2, string Operador)
        {
            double resultado = 0;
            Numero num1 = new Numero(Numero1);
            Numero num2 = new Numero(Numero2);

            resultado = Calculadora.Operar(num1, num2, Operador);
            return resultado;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //sacar
        }

        private void btnCerrar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click_Click(object sender, EventArgs e)
        {
            lblLabel.Text = Numero.DecimalBinario(lblLabel.Text);
        }

        private void btnConvertirADecimal_Click_Click(object sender, EventArgs e)
        {
            lblLabel.Text = Numero.BinarioDecimal(lblLabel.Text);
        }
    }
}
