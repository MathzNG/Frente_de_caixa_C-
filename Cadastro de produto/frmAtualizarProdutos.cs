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
            produtosLista();
        }
        public void produtosLista()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "select nome from tbProdutos;";
            comm.CommandType = CommandType.Text;

            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cbbNome.Items.Add(dr["nome"].ToString());

            }
            Conexao.fecharConexao();
        }

        public void valorProduto(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select preco,codProd,descricao from tbProdutos where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader Dr;
            Dr = comm.ExecuteReader();
            Dr.Read();

            txtPreco.Text = Dr["preco"].ToString();
            txtId.Text = Dr["codProd"].ToString();
            txtDescricao.Text = Dr["descricao"].ToString();

            Conexao.fecharConexao();

        }

        public int deleteProduto(int codProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbProdutos where codProd = @codProd;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProd",MySqlDbType.Int32).Value = codProd;

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }


        public int alterarDados(int codProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbProdutos set preco = @preco,descricao = @descricao where codProd = @codProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = codProd;
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = txtPreco.Text;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (alterarDados(Convert.ToInt32(txtId.Text)) == 1)
            {
                MessageBox.Show("Produto atualizado com sucesso!");
                cbbNome.Text = "";
                txtPreco.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar produto!");
            }
        }


        private void cbbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNome.SelectedItem != null)
            {
                string produto = cbbNome.SelectedItem.ToString();
                frmCadastro abrir = new frmCadastro(produto);
                abrir.Show();
                this.Hide();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o produto?",
                "Messagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                deleteProduto(Convert.ToInt32(txtId.Text));
                MessageBox.Show("Produto excluido com sucesso!");
                cbbNome.Text = "";
                txtPreco.Clear();
                txtDescricao.Clear();
            }
            else
            {
                MessageBox.Show("Produto não excluido!");
            }
        }
    }
}
