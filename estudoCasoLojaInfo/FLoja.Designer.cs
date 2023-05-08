
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
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMovimentacao = new System.Windows.Forms.TabControl();
            this.tabCompra = new System.Windows.Forms.TabPage();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProdutoEntrada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMovimentacao = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtBoxArquivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.tabMovimentacao.SuspendLayout();
            this.tabCompra.SuspendLayout();
            this.tabVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.Enabled = false;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "HD 500 GB",
            "HD 1TB",
            "PENDRIVE",
            "MONITOR",
            "CABO HDMI"});
            this.cboProduto.Location = new System.Drawing.Point(196, 57);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(6);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(226, 33);
            this.cboProduto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estoque:";
            // 
            // tabMovimentacao
            // 
            this.tabMovimentacao.Controls.Add(this.tabCompra);
            this.tabMovimentacao.Controls.Add(this.tabVenda);
            this.tabMovimentacao.Location = new System.Drawing.Point(104, 239);
            this.tabMovimentacao.Margin = new System.Windows.Forms.Padding(6);
            this.tabMovimentacao.Name = "tabMovimentacao";
            this.tabMovimentacao.SelectedIndex = 0;
            this.tabMovimentacao.Size = new System.Drawing.Size(768, 208);
            this.tabMovimentacao.TabIndex = 12;
            // 
            // tabCompra
            // 
            this.tabCompra.BackColor = System.Drawing.Color.Transparent;
            this.tabCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCompra.Controls.Add(this.txtVenda);
            this.tabCompra.Controls.Add(this.label5);
            this.tabCompra.Controls.Add(this.txtPrecoCusto);
            this.tabCompra.Controls.Add(this.label4);
            this.tabCompra.Controls.Add(this.txtLucro);
            this.tabCompra.Controls.Add(this.label3);
            this.tabCompra.Controls.Add(this.label7);
            this.tabCompra.Controls.Add(this.label6);
            this.tabCompra.Controls.Add(this.txtTotalPagar);
            this.tabCompra.Controls.Add(this.txtQuantidade);
            this.tabCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCompra.Location = new System.Drawing.Point(4, 34);
            this.tabCompra.Margin = new System.Windows.Forms.Padding(6);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.Padding = new System.Windows.Forms.Padding(6);
            this.tabCompra.Size = new System.Drawing.Size(760, 170);
            this.tabCompra.TabIndex = 0;
            this.tabCompra.Text = "Gerenciador";
            // 
            // txtVenda
            // 
            this.txtVenda.Enabled = false;
            this.txtVenda.Location = new System.Drawing.Point(518, 131);
            this.txtVenda.Margin = new System.Windows.Forms.Padding(6);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.ReadOnly = true;
            this.txtVenda.Size = new System.Drawing.Size(199, 32);
            this.txtVenda.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Preço de venda (unitário):";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Enabled = false;
            this.txtPrecoCusto.Location = new System.Drawing.Point(280, 62);
            this.txtPrecoCusto.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(183, 32);
            this.txtPrecoCusto.TabIndex = 5;
            this.txtPrecoCusto.TextChanged += new System.EventHandler(this.txtPrecoCusto_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "% Lucro:";
            // 
            // txtLucro
            // 
            this.txtLucro.Enabled = false;
            this.txtLucro.Location = new System.Drawing.Point(552, 62);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(6);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(110, 32);
            this.txtLucro.TabIndex = 7;
            this.txtLucro.TextChanged += new System.EventHandler(this.txtLucro_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço de custo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total a pagar ao fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(39, 131);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(225, 32);
            this.txtTotalPagar.TabIndex = 11;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(39, 62);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(6);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(157, 32);
            this.txtQuantidade.TabIndex = 9;
            // 
            // tabVenda
            // 
            this.tabVenda.BackColor = System.Drawing.Color.Transparent;
            this.tabVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabVenda.Controls.Add(this.cboOperacao);
            this.tabVenda.Controls.Add(this.label11);
            this.tabVenda.Controls.Add(this.label8);
            this.tabVenda.Controls.Add(this.cboProdutoEntrada);
            this.tabVenda.Controls.Add(this.label10);
            this.tabVenda.Controls.Add(this.txtMovimentacao);
            this.tabVenda.Location = new System.Drawing.Point(4, 34);
            this.tabVenda.Margin = new System.Windows.Forms.Padding(6);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(6);
            this.tabVenda.Size = new System.Drawing.Size(760, 170);
            this.tabVenda.TabIndex = 1;
            this.tabVenda.Text = "Entrada e saída";
            // 
            // cboOperacao
            // 
            this.cboOperacao.Enabled = false;
            this.cboOperacao.FormattingEnabled = true;
            this.cboOperacao.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.cboOperacao.Location = new System.Drawing.Point(517, 71);
            this.cboOperacao.Margin = new System.Windows.Forms.Padding(6);
            this.cboOperacao.Name = "cboOperacao";
            this.cboOperacao.Size = new System.Drawing.Size(226, 33);
            this.cboOperacao.TabIndex = 25;
            this.cboOperacao.SelectedIndexChanged += new System.EventHandler(this.cboOperacao_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Operação:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Produto:";
            // 
            // cboProdutoEntrada
            // 
            this.cboProdutoEntrada.Enabled = false;
            this.cboProdutoEntrada.FormattingEnabled = true;
            this.cboProdutoEntrada.Items.AddRange(new object[] {
            "HD 500 GB",
            "HD 1TB",
            "PENDRIVE",
            "MONITOR",
            "CABO HDMI"});
            this.cboProdutoEntrada.Location = new System.Drawing.Point(24, 71);
            this.cboProdutoEntrada.Margin = new System.Windows.Forms.Padding(6);
            this.cboProdutoEntrada.Name = "cboProdutoEntrada";
            this.cboProdutoEntrada.Size = new System.Drawing.Size(226, 33);
            this.cboProdutoEntrada.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Movimentação:";
            // 
            // txtMovimentacao
            // 
            this.txtMovimentacao.Enabled = false;
            this.txtMovimentacao.Location = new System.Drawing.Point(286, 72);
            this.txtMovimentacao.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovimentacao.Name = "txtMovimentacao";
            this.txtMovimentacao.Size = new System.Drawing.Size(207, 32);
            this.txtMovimentacao.TabIndex = 18;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(204, 153);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(6);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(155, 32);
            this.txtEstoque.TabIndex = 10;
            // 
            // txtBoxArquivo
            // 
            this.txtBoxArquivo.Location = new System.Drawing.Point(94, 507);
            this.txtBoxArquivo.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxArquivo.Multiline = true;
            this.txtBoxArquivo.Name = "txtBoxArquivo";
            this.txtBoxArquivo.ReadOnly = true;
            this.txtBoxArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxArquivo.Size = new System.Drawing.Size(795, 181);
            this.txtBoxArquivo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 464);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Histórico de Compra e Venda";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::estudoCasoLojaInfo.Properties.Resources.pesquisa;
            this.btnPesquisar.Location = new System.Drawing.Point(431, 41);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(63, 67);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::estudoCasoLojaInfo.Properties.Resources.novo;
            this.btnNovo.Location = new System.Drawing.Point(901, 273);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(92, 83);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::estudoCasoLojaInfo.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(901, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 85);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnArquivo
            // 
            this.btnArquivo.BackColor = System.Drawing.Color.Transparent;
            this.btnArquivo.Enabled = false;
            this.btnArquivo.FlatAppearance.BorderSize = 0;
            this.btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivo.Image = global::estudoCasoLojaInfo.Properties.Resources.consultar;
            this.btnArquivo.Location = new System.Drawing.Point(911, 543);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(92, 88);
            this.btnArquivo.TabIndex = 21;
            this.btnArquivo.UseVisualStyleBackColor = false;
            // 
            // FLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 719);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxArquivo);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.tabMovimentacao);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabMovimentacao.ResumeLayout(false);
            this.tabCompra.ResumeLayout(false);
            this.tabCompra.PerformLayout();
            this.tabVenda.ResumeLayout(false);
            this.tabVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

