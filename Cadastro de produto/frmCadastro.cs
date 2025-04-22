using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro_de_produto
{
    public partial class frmCadastro : Form
    {
        private RepositorioProduto repositorio = new RepositorioProduto();
        public frmCadastro()
        {
            InitializeComponent();

        }
        public frmCadastro(string produto)
        {
            InitializeComponent();
            txtNome.Text = produto;
           valorProduto(txtNome.Text);
        }

        public int CadastroProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProdutos(nome,preco,descricao) values(@nome,@preco,@descricao);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = txtPreco.Text;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

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
      

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtId.Clear();
            txtDescricao.Clear();

            int totalLista = Produto.ListaProdutos.Count;
            int novoCodigo = totalLista + 1;
            txtId.Text = novoCodigo.ToString("D4");

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Produto prod = new Produto();

            try
            {
                CadastroProdutos();
                prod.Id = long.Parse(txtId.Text);
                prod.Nome = txtNome.Text;
                prod.Preco = decimal.Parse(txtPreco.Text);
                prod.Descricao = txtDescricao.Text;

                MessageBox.Show("Produto cadastrado com sucesso!");
                Produto.ListaProdutos.Add(prod);
                frmProdutos abrir = new frmProdutos();
                abrir.ShowDialog();
                LimparCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores validos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }

        private void mspMenuprincipal_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void mspProduto_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.Show();
            this.Hide();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            int totalLista = Produto.ListaProdutos.Count;
            int novoCodigo = totalLista + 1;
            txtId.Text = novoCodigo.ToString("D4");
        }

        /* public void ProdutosLista()
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
        */

        public void ValorProduto(string nome)
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
            //Método para deletar dados

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbProdutos where codProd = @codProd;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = codProd;

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public int alterarDados(int codProd)
        {
            //Método para atualizar dados

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbProdutos set nome = @nome,preco = @preco,descricao = @descricao where codProd = @codProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = codProd;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = txtPreco.Text;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Atualizar valor ou nome do produto

            if (alterarDados(Convert.ToInt32(txtId.Text)) == 1)
            {
                MessageBox.Show("Produto atualizado com sucesso!");
                txtNome.Clear();
                txtPreco.Clear();
                txtDescricao.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar produto!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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
                txtNome.Text = "";
                txtPreco.Clear();
                txtDescricao.Clear();
            }
            else
            {
                MessageBox.Show("Produto não excluido!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmAtualizarProdutos abrir = new frmAtualizarProdutos();
            abrir.Show();
            this.Hide();
        }
    }
}
