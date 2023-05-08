using System;
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

        public void LimparDados()
        {
            txtVenda.Text = "";
            txtTotalPagar.Text = "";
            txtQuantidade.Text = "";
            txtPrecoCusto.Text = "";
            txtMovimentacao.Text = "";
            txtLucro.Text = "";
            txtEstoque.Text = "";
            txtBoxArquivo.Text = "";

            cboOperacao.SelectedIndex = -1;
            cboProduto.SelectedIndex = -1;
            cboProdutoEntrada.SelectedIndex = -1;

        }

        public void Salvar()
        {
            btnArquivo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = false;

            txtMovimentacao.Enabled = false;
            txtEstoque.Enabled = false;
            txtQuantidade.Enabled = false;
            txtPrecoCusto.Enabled = false;

            cboOperacao.Enabled = false;
            cboProduto.Enabled = false;
            cboProdutoEntrada.Enabled = false;
            LimparDados();
        }
    

        public void ativarLucro()
        {
            if (txtQuantidade.Text.Trim() != "" && txtPrecoCusto.Text.Trim() != "")

                txtLucro.Enabled = true;
            
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

        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnArquivo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = true;

            txtMovimentacao.Enabled = true;
            txtEstoque.Enabled = true;
            txtQuantidade.Enabled = true;
            txtPrecoCusto.Enabled = true;

            cboOperacao.Enabled = true;
            cboProduto.Enabled = true;
            cboProdutoEntrada.Enabled = true;
            LimparDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
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
        }

        private void txtLucro_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                double quantidade, precoCusto, lucro;
                
                if (txtPrecoCusto.Text.Trim() != "" && txtQuantidade.Text.Trim() != "" && txtLucro.Text.Trim() != "")
                {
                quantidade = double.Parse(txtQuantidade.Text);
                precoCusto = double.Parse(txtPrecoCusto.Text);
                lucro = double.Parse(txtLucro.Text);
                txtTotalPagar.Text = $"{quantidade * precoCusto:C}";
                txtVenda.Text = $"{precoCusto + (precoCusto * (lucro / 100))}";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa Digitar valores válidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVenda.Text = "";
            }
        }

        private void txtPrecoCusto_TextChanged_1(object sender, EventArgs e)
        {
            ativarLucro();
        }

        private void cboOperacao_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cboOperacao.SelectedIndex != -1)
                {

                    DialogResult resultado = MessageBox.Show($"você Deseja confirmar a movimentação de '{cboOperacao.SelectedItem}' para {txtMovimentacao.Text} itens?", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes && cboOperacao.SelectedIndex == 0)
                    {
                        switch (cboProdutoEntrada.SelectedIndex)
                        {
                            case 0:
                                HD500.Comprar(int.Parse(txtMovimentacao.Text));
                                break;
                            case 1:
                                HD1000.Comprar(int.Parse(txtMovimentacao.Text));
                                break;
                            case 2:
                                pendrive.Comprar(int.Parse(txtMovimentacao.Text));
                                break;
                            case 3:
                                monitor.Comprar(int.Parse(txtMovimentacao.Text));
                                break;
                            case 4:
                                HDMI.Comprar(int.Parse(txtMovimentacao.Text));
                                break;

                            default:
                                MessageBox.Show("Selecione opções válidas por favor!");
                                break;
                        }
                    }
                    else if (resultado == DialogResult.Yes && cboOperacao.SelectedIndex == 1)
                    {
                        switch (cboProdutoEntrada.SelectedIndex)
                        {
                            case 0:
                                HD500.Vender(int.Parse(txtMovimentacao.Text));
                                break;
                            case 1:
                                HD1000.Vender(int.Parse(txtMovimentacao.Text));
                                break;
                            case 2:
                                pendrive.Vender(int.Parse(txtMovimentacao.Text));
                                break;
                            case 3:
                                monitor.Vender(int.Parse(txtMovimentacao.Text));
                                break;
                            case 4:
                                HDMI.Vender(int.Parse(txtMovimentacao.Text));
                                break;

                            default:
                                MessageBox.Show("Algo deu errado!");
                                break;
                        }
                    }
                    else
                    {
                        cboProdutoEntrada.SelectedIndex = -1;
                        txtMovimentacao.Text = "";
                        cboOperacao.SelectedIndex = -1;
                    }

                }
                else
                {
                    LimparDados();
                }
            }
            catch (Exception)
            {

                MessageBox.Show($"Por favor digite valores válidos!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}

