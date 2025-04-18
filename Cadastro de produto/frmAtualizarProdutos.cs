using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_produto
{
    public partial class frmAtualizarProdutos : Form
    {
        private RepositorioProduto repositorio = new RepositorioProduto();
        public frmAtualizarProdutos()
        {
            InitializeComponent();
        }
        

        public int alterarDados(int codProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbProdutos set nome = @nome,preco = @preco where codProd = @codProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = codProd; 
            comm.Parameters.Add("@nome", MySqlDbType.VarChar,100).Value = txtNome.Text; 
            comm.Parameters.Add("@preco", MySqlDbType.Decimal,18).Value = txtPreco.Text; 

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
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
