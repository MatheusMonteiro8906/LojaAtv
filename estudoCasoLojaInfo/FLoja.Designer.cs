
namespace estudoCasoLojaInfo
{
    partial class FLoja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboProduto = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabMovimentacao = new System.Windows.Forms.TabControl();
            tabCompra = new System.Windows.Forms.TabPage();
            txtVenda = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPrecoCusto = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtLucro = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtTotalPagar = new System.Windows.Forms.TextBox();
            txtQuantidade = new System.Windows.Forms.TextBox();
            tabVenda = new System.Windows.Forms.TabPage();
            cboOperacao = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            cboProdutoEntrada = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            txtMovimentacao = new System.Windows.Forms.TextBox();
            txtEstoque = new System.Windows.Forms.TextBox();
            txtBoxArquivo = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            btnPesquisar = new System.Windows.Forms.Button();
            btnNovo = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnArquivo = new System.Windows.Forms.Button();
            tabMovimentacao.SuspendLayout();
            tabCompra.SuspendLayout();
            tabVenda.SuspendLayout();
            SuspendLayout();
            // 
            // cboProduto
            // 
            cboProduto.FormattingEnabled = true;
            cboProduto.Items.AddRange(new object[] { "HD 500 GB", "HD 1TB", "PENDRIVE", "MONITOR", "CABO HDMI" });
            cboProduto.Location = new System.Drawing.Point(196, 57);
            cboProduto.Margin = new System.Windows.Forms.Padding(6);
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new System.Drawing.Size(226, 46);
            cboProduto.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(104, 62);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 38);
            label2.TabIndex = 13;
            label2.Text = "Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(104, 153);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 38);
            label1.TabIndex = 11;
            label1.Text = "Estoque:";
            // 
            // tabMovimentacao
            // 
            tabMovimentacao.Controls.Add(tabCompra);
            tabMovimentacao.Controls.Add(tabVenda);
            tabMovimentacao.Location = new System.Drawing.Point(104, 239);
            tabMovimentacao.Margin = new System.Windows.Forms.Padding(6);
            tabMovimentacao.Name = "tabMovimentacao";
            tabMovimentacao.SelectedIndex = 0;
            tabMovimentacao.Size = new System.Drawing.Size(768, 208);
            tabMovimentacao.TabIndex = 12;
            // 
            // tabCompra
            // 
            tabCompra.BackColor = System.Drawing.Color.Transparent;
            tabCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabCompra.Controls.Add(txtVenda);
            tabCompra.Controls.Add(label5);
            tabCompra.Controls.Add(txtPrecoCusto);
            tabCompra.Controls.Add(label4);
            tabCompra.Controls.Add(txtLucro);
            tabCompra.Controls.Add(label3);
            tabCompra.Controls.Add(label7);
            tabCompra.Controls.Add(label6);
            tabCompra.Controls.Add(txtTotalPagar);
            tabCompra.Controls.Add(txtQuantidade);
            tabCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tabCompra.Location = new System.Drawing.Point(4, 47);
            tabCompra.Margin = new System.Windows.Forms.Padding(6);
            tabCompra.Name = "tabCompra";
            tabCompra.Padding = new System.Windows.Forms.Padding(6);
            tabCompra.Size = new System.Drawing.Size(760, 157);
            tabCompra.TabIndex = 0;
            tabCompra.Text = "Gerenciador";
            // 
            // txtVenda
            // 
            txtVenda.Location = new System.Drawing.Point(518, 131);
            txtVenda.Margin = new System.Windows.Forms.Padding(6);
            txtVenda.Name = "txtVenda";
            txtVenda.ReadOnly = true;
            txtVenda.Size = new System.Drawing.Size(199, 45);
            txtVenda.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(518, 100);
            label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(333, 38);
            label5.TabIndex = 14;
            label5.Text = "Preço de venda (unitário):";
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new System.Drawing.Point(280, 62);
            txtPrecoCusto.Margin = new System.Windows.Forms.Padding(6);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new System.Drawing.Size(183, 45);
            txtPrecoCusto.TabIndex = 5;
            txtPrecoCusto.TextChanged += txtPrecoCusto_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(552, 18);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 38);
            label4.TabIndex = 8;
            label4.Text = "% Lucro:";
            // 
            // txtLucro
            // 
            txtLucro.Enabled = false;
            txtLucro.Location = new System.Drawing.Point(552, 62);
            txtLucro.Margin = new System.Windows.Forms.Padding(6);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new System.Drawing.Size(110, 45);
            txtLucro.TabIndex = 7;
            txtLucro.TextChanged += txtLucro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(279, 18);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(206, 38);
            label3.TabIndex = 6;
            label3.Text = "Preço de custo:";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(39, 100);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(363, 38);
            label7.TabIndex = 12;
            label7.Text = "Total a pagar ao fornecedor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(39, 18);
            label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(167, 38);
            label6.TabIndex = 10;
            label6.Text = "Quantidade:";
            label6.Click += label6_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new System.Drawing.Point(39, 131);
            txtTotalPagar.Margin = new System.Windows.Forms.Padding(6);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.ReadOnly = true;
            txtTotalPagar.Size = new System.Drawing.Size(225, 45);
            txtTotalPagar.TabIndex = 11;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new System.Drawing.Point(39, 62);
            txtQuantidade.Margin = new System.Windows.Forms.Padding(6);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new System.Drawing.Size(157, 45);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.TextChanged += textBox1_TextChanged;
            // 
            // tabVenda
            // 
            tabVenda.BackColor = System.Drawing.Color.Transparent;
            tabVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabVenda.Controls.Add(cboOperacao);
            tabVenda.Controls.Add(label11);
            tabVenda.Controls.Add(label8);
            tabVenda.Controls.Add(cboProdutoEntrada);
            tabVenda.Controls.Add(label10);
            tabVenda.Controls.Add(txtMovimentacao);
            tabVenda.Location = new System.Drawing.Point(4, 47);
            tabVenda.Margin = new System.Windows.Forms.Padding(6);
            tabVenda.Name = "tabVenda";
            tabVenda.Padding = new System.Windows.Forms.Padding(6);
            tabVenda.Size = new System.Drawing.Size(760, 157);
            tabVenda.TabIndex = 1;
            tabVenda.Text = "Entrada e saída";
            // 
            // cboOperacao
            // 
            cboOperacao.FormattingEnabled = true;
            cboOperacao.Items.AddRange(new object[] { "Compra", "Venda" });
            cboOperacao.Location = new System.Drawing.Point(517, 71);
            cboOperacao.Margin = new System.Windows.Forms.Padding(6);
            cboOperacao.Name = "cboOperacao";
            cboOperacao.Size = new System.Drawing.Size(226, 46);
            cboOperacao.TabIndex = 25;
            cboOperacao.SelectedIndexChanged += cboOperacao_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(517, 41);
            label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(142, 38);
            label11.TabIndex = 24;
            label11.Text = "Operação:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(24, 41);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(122, 38);
            label8.TabIndex = 22;
            label8.Text = "Produto:";
            // 
            // cboProdutoEntrada
            // 
            cboProdutoEntrada.FormattingEnabled = true;
            cboProdutoEntrada.Items.AddRange(new object[] { "HD 500 GB", "HD 1TB", "PENDRIVE", "MONITOR", "CABO HDMI" });
            cboProdutoEntrada.Location = new System.Drawing.Point(24, 71);
            cboProdutoEntrada.Margin = new System.Windows.Forms.Padding(6);
            cboProdutoEntrada.Name = "cboProdutoEntrada";
            cboProdutoEntrada.Size = new System.Drawing.Size(226, 46);
            cboProdutoEntrada.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(286, 41);
            label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(205, 38);
            label10.TabIndex = 19;
            label10.Text = "Movimentação:";
            // 
            // txtMovimentacao
            // 
            txtMovimentacao.Location = new System.Drawing.Point(286, 72);
            txtMovimentacao.Margin = new System.Windows.Forms.Padding(6);
            txtMovimentacao.Name = "txtMovimentacao";
            txtMovimentacao.Size = new System.Drawing.Size(207, 45);
            txtMovimentacao.TabIndex = 18;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new System.Drawing.Point(204, 153);
            txtEstoque.Margin = new System.Windows.Forms.Padding(6);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.ReadOnly = true;
            txtEstoque.Size = new System.Drawing.Size(155, 45);
            txtEstoque.TabIndex = 10;
            // 
            // txtBoxArquivo
            // 
            txtBoxArquivo.Location = new System.Drawing.Point(94, 507);
            txtBoxArquivo.Margin = new System.Windows.Forms.Padding(6);
            txtBoxArquivo.Multiline = true;
            txtBoxArquivo.Name = "txtBoxArquivo";
            txtBoxArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtBoxArquivo.Size = new System.Drawing.Size(795, 181);
            txtBoxArquivo.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(344, 464);
            label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(378, 38);
            label9.TabIndex = 16;
            label9.Text = "Histórico de Compra e Venda";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPesquisar.Image = Properties.Resources.pesquisa;
            btnPesquisar.Location = new System.Drawing.Point(431, 41);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new System.Drawing.Size(63, 67);
            btnPesquisar.TabIndex = 18;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += button1_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = System.Drawing.Color.Transparent;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNovo.Image = Properties.Resources.novo;
            btnNovo.Location = new System.Drawing.Point(901, 273);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new System.Drawing.Size(92, 83);
            btnNovo.TabIndex = 19;
            btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = System.Drawing.Color.Transparent;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.Image = Properties.Resources.salvar;
            btnSalvar.Location = new System.Drawing.Point(901, 362);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(93, 85);
            btnSalvar.TabIndex = 20;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnArquivo
            // 
            btnArquivo.BackColor = System.Drawing.Color.Transparent;
            btnArquivo.FlatAppearance.BorderSize = 0;
            btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnArquivo.Image = Properties.Resources.consultar;
            btnArquivo.Location = new System.Drawing.Point(911, 543);
            btnArquivo.Name = "btnArquivo";
            btnArquivo.Size = new System.Drawing.Size(92, 88);
            btnArquivo.TabIndex = 21;
            btnArquivo.UseVisualStyleBackColor = false;
            // 
            // FLoja
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1089, 719);
            Controls.Add(btnArquivo);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnPesquisar);
            Controls.Add(label9);
            Controls.Add(txtBoxArquivo);
            Controls.Add(cboProduto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEstoque);
            Controls.Add(tabMovimentacao);
            Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FLoja";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tabMovimentacao.ResumeLayout(false);
            tabCompra.ResumeLayout(false);
            tabCompra.PerformLayout();
            tabVenda.ResumeLayout(false);
            tabVenda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMovimentacao;
        private System.Windows.Forms.TabPage tabCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtBoxArquivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMovimentacao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOperacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProdutoEntrada;
    }
}

