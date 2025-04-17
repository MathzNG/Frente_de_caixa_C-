using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_produto
{
    public partial class frmAtualizarProdutos : Form
    {
        private RepositorioProduto repositorio = new RepositorioProduto();
        public frmAtualizarProdutos()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            decimal novoPreco = decimal.Parse(txtPreco.Text);
           
            repositorio.AtualizarProduto(id, novoPreco);
            MessageBox.Show("Produto atualizado com sucesso!");
          
        }
    }
}
