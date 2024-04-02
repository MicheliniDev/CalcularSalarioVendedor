using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cincoPorcento, valorCarro, comissao, totalVendas, salarioFixo, salarioFinal;
            valorCarro = Convert.ToDouble(txtValorCarro.Text);
            totalVendas = Convert.ToDouble(txtValorVendasTotal.Text);
            salarioFixo = Convert.ToDouble(txtSalario.Text);
            comissao = Convert.ToDouble(txtComissao.Text);
            cincoPorcento = valorCarro / 100 * 5;
            salarioFinal = salarioFixo + comissao + cincoPorcento;
            txtSalarioFinal.Text = salarioFinal.ToString();
            txtCincoPorcento.Text = cincoPorcento.ToString();  
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalarioFinal.Clear();
            txtCincoPorcento.Clear();
            txtValorCarro.Clear();
            txtValorVendasTotal.Clear();
            txtSalario.Clear();
            txtComissao.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
