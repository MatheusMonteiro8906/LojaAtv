using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudoCasoLojaInfo
{
    public partial class FLoja : Form
    {
        public FLoja()
        {
            InitializeComponent();
        }

        produtos HD500 = new();
        produtos HD1000 = new();
        produtos pendrive = new();
        produtos monitor = new();
        produtos HDMI = new();

        public void ativarLucro()
        {
            if (txtQuantidade.Text.Trim() != "" && txtPrecoCusto.Text.Trim() != "")
            {
                txtLucro.Enabled = true;
            }
            else
                txtLucro.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ativarLucro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboProduto.SelectedIndex == 0)
            {
                txtEstoque.Text = $"{HD500._estoque}";
            }
            else if (cboProduto.SelectedIndex == 1)
            {
                txtEstoque.Text = $"{HD1000._estoque}";
            }
            else if (cboProduto.SelectedIndex == 2)
            {
                txtEstoque.Text = $"{pendrive._estoque}";
            }
            else if (cboProduto.SelectedIndex == 3)
            {
                txtEstoque.Text = $"{monitor._estoque}";
            }
            else if (cboProduto.SelectedIndex == 4)
            {
                txtEstoque.Text = $"{HDMI._estoque}";
            }
            else
            {
                MessageBox.Show("Você precisa fazer uma seleção válida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double quantidade, precoCusto, lucro;

                quantidade = double.Parse(txtQuantidade.Text);
                precoCusto = double.Parse(txtPrecoCusto.Text);
                lucro = double.Parse(txtLucro.Text);

                txtTotalPagar.Text = $"{quantidade * precoCusto:C}";
                txtVenda.Text = $"{precoCusto + (precoCusto * (lucro / 100))}";
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa Digitar valores válidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            ativarLucro();
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOperacao.SelectedIndex != -1)
            {

                DialogResult resultado = MessageBox.Show($"você Deseja confirmar a movimentação de '{cboOperacao.SelectedItem}' para {txtMovimentacao.Text} itens?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes && cboOperacao.SelectedIndex == 0)
                {
                    //ComprarItens();
                }
                else if (resultado == DialogResult.Yes && cboOperacao.SelectedIndex == 1)
                {
                    //VenderItens();
                }

            }
            else
            {
                //LimparDados();
            }

        }
    }
}

