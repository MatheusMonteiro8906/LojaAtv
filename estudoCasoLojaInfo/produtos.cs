using System.Windows.Forms;

namespace estudoCasoLojaInfo
{
    class produtos
    {

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
            estoque += result;
        }

        public void Vender(int result)
        {
            int estoqueBackup;
            estoqueBackup = estoque;
            estoque -= result;

            if (estoque < 0)
            {
                MessageBox.Show($"O valor de venda é maior do que o valor do estoque!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estoque = estoqueBackup;
            }

        }

        string path = "";
        public void pesquisar()
        {

        }

    }
}
