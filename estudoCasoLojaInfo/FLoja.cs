using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace estudoCasoLojaInfo
{
    public partial class FLoja : Form
    {
        public FLoja()
        {
            InitializeComponent();
        }
        produtos produto = new();
        produtos HD500 = new();
        produtos HD1000 = new();
        produtos pendrive = new();
        produtos monitor = new();
        produtos HDMI = new();
        int indexCbo;

        public void salvarExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var excel = new ExcelPackage();
            using var worksheet = excel.Workbook.Worksheets.Add("Registro do estoque");
            File.ReadAllLines(@"C:\arquivos\estoque.txt")
                .Select((line, index) => new { line, index })
                .ToList()
                .ForEach(pair =>
                {
                    var cells = pair.line.Split(';');
                    var rowIndex = pair.index + 1;
                    var columnIndex = 1;
                    foreach (var cell in cells)
                    {
                        if (int.TryParse(cell, out int intValue))
                        {
                            worksheet.Cells[rowIndex, columnIndex].Style.Numberformat.Format = "0";
                            worksheet.Cells[rowIndex, columnIndex].Value = intValue;
                        }
                        else if (double.TryParse(cell, out double doubleValue))
                        {
                            worksheet.Cells[rowIndex, columnIndex].Style.Numberformat.Format = "0.00";
                            worksheet.Cells[rowIndex, columnIndex].Value = doubleValue;
                        }
                        else
                        {
                            worksheet.Cells[rowIndex, columnIndex].Value = cell;
                        }
                        columnIndex++;
                    }
                });
            excel.SaveAs(new FileInfo(@"C:\arquivos\Registro.xlsx"));
        }

        public void DefinirNomes()
        {
            HD500.nome = "HD500";
            HD1000.nome = "HD1000";
            pendrive.nome = "pendrive";
            monitor.nome = "monitor";
            HDMI.nome = "HDMI";
        }

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

        private void PercorrerArquivo()
        {
            txtBoxArquivo.Clear();
            var dados = produto.ConsultarArquivo();

            foreach (var c in dados)
            {
                txtBoxArquivo.Text += $"\r\n Nome: {c.nome} - estoque: {c._estoque} - movimentação: {c._valor}\r\n"; //  - movimentação: {c._valor:C}
            }

            if (txtBoxArquivo.Text.Trim() == "")
            {
                MessageBox.Show("Não existem registros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void _PercorrerArquivo(string nome)
        {
            txtBoxArquivo.Clear();
            var dados = produto.ConsultarArquivo(nome);

            foreach (var c in dados)
            {
                txtBoxArquivo.Text += $"\r\n Nome: {c.nome} - estoque: {c._estoque} - movimentação: {c._valor}\r\n"; //  - movimentação: {c._valor:C}
            }

            if (txtBoxArquivo.Text.Trim() == "")
            {
                MessageBox.Show("Não existem registros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Salvar()
        {
            btnArquivo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcel.Enabled = false;

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
            btnExcel.Enabled = true;

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
                    _PercorrerArquivo(HD500.nome);
                }
                else if (cboProduto.SelectedIndex == 1)
                {
                    txtEstoque.Text = $"{HD1000._estoque}";
                    _PercorrerArquivo(HD1000.nome);
                }
                else if (cboProduto.SelectedIndex == 2)
                {
                    txtEstoque.Text = $"{pendrive._estoque}";
                    _PercorrerArquivo(pendrive.nome);
                }
                else if (cboProduto.SelectedIndex == 3)
                {
                    txtEstoque.Text = $"{monitor._estoque}";
                    _PercorrerArquivo(monitor.nome);
                }
                else if (cboProduto.SelectedIndex == 4)
                {
                    txtEstoque.Text = $"{HDMI._estoque}";
                    _PercorrerArquivo(HDMI.nome);
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

            if (indexCbo == 0)
            {
                HD500.GravarMovimentacao();
            }
            else if (indexCbo == 1)
            {
                HD1000.GravarMovimentacao();
            }
            else if (indexCbo == 2)
            {
                pendrive.GravarMovimentacao();
            }
            else if (indexCbo == 3)
            {
                monitor.GravarMovimentacao();
            }
            else if (indexCbo == 4)
            {
                HDMI.GravarMovimentacao();
            }

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            ativarLucro();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            PercorrerArquivo();
        }

        private void cboProdutoEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefinirNomes();
            if (cboProdutoEntrada.SelectedIndex == 0)
            {
                indexCbo = 0;
            }
            else if (cboProdutoEntrada.SelectedIndex == 1)
            {
                indexCbo = 1;
            }
            else if (cboProdutoEntrada.SelectedIndex == 2)
            {
                indexCbo = 2;
            }
            else if (cboProdutoEntrada.SelectedIndex == 3)
            {
                indexCbo = 3;
            }
            else if (cboProdutoEntrada.SelectedIndex == 4)
            {
                indexCbo = 4;
            }
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefinirNomes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            salvarExcel();
        }
    }
}