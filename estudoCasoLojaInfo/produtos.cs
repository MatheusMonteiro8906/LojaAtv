using System.Collections.Generic;
using System.IO;
using System;
using System.Windows.Forms;

namespace estudoCasoLojaInfo
{
    class produtos
    {

        public string nome { get; set; }


        private double valor;

        public double _valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private int estoque = 500;

        public int _estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        private double preco;

        public double _preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public void Comprar(int result)
        {
            valor = result;
            estoque += result;
        }

        public void Vender(int result)
        {
            valor = result;
            int estoqueBackup;
            estoqueBackup = estoque;
            estoque -= result;

            if (estoque < 0)
            {
                MessageBox.Show($"O valor de venda é maior do que o valor do estoque!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estoque = estoqueBackup;
            }

        }

        public void GravarMovimentacao()
        {
            var listaProdutos = ConsultarArquivo();

            listaProdutos.Add(this);

            string arquivoCaminho = @"C:\arquivos\estoque.txt";

            if (File.Exists(arquivoCaminho))
            {
                StreamWriter escreverArquivo = new StreamWriter(arquivoCaminho);
                escreverArquivo.WriteLine("Nome; estoque; movimentação");

                foreach (var c in listaProdutos)
                {
                    var linha = $"{c.nome};{c._estoque};{c.valor};";
                    escreverArquivo.WriteLine(linha);
                }
                escreverArquivo.Close();
            }
        }

        public void ApagarArquivo()
        {
            try
            {
                string arquivoCaminho = @"C:\arquivos\estoque.txt";
                using var arquivoReader = new StreamReader(arquivoCaminho);
                arquivoReader.Close();

                File.Delete(arquivoCaminho);

            }
            catch (Exception)
            {
                MessageBox.Show("Não existem arquivos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public List<produtos> ConsultarArquivo()
        {
            var listaProdutos = new List<produtos>();

            string arquivoCaminho = @"C:\arquivos\estoque.txt";

            if (File.Exists(arquivoCaminho))
            {
                using var arquivo = new StreamReader(arquivoCaminho);

                string linhaArquivo;
                int i = 0;

                while ((linhaArquivo = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue; 
                    var produtosArquivo = linhaArquivo.Split(';');

                    var produto = new produtos();

                    produto.nome = produtosArquivo[0];
                    produto.estoque = int.Parse(produtosArquivo[1]);
                    produto.valor = double.Parse(produtosArquivo[2]);

                    listaProdutos.Add(produto);


                }
                arquivo.Close();
            }

            return listaProdutos;
        }

        public List<produtos> ConsultarArquivo(string nome)
        {
            var listaProdutos = new List<produtos>();

            string arquivoCaminho = @"C:\arquivos\estoque.txt";

            if (File.Exists(arquivoCaminho))
            {
                using var arquivo = new StreamReader(arquivoCaminho);

                string linhaArquivo;
                int i = 0;

                while ((linhaArquivo = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;
                    var produtosArquivo = linhaArquivo.Split(';');
                    var produto = new produtos();

                    if (produtosArquivo[0] == nome)
                    {
                        produto.nome = produtosArquivo[0];
                        produto.estoque = int.Parse(produtosArquivo[1]);
                        produto.preco = double.Parse(produtosArquivo[2]);

                        listaProdutos.Add(produto);
                    }
                }
                arquivo.Close();
            }
            return listaProdutos;
        }

    }
}
