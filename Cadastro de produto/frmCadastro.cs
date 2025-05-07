using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            desabilitarCampos();
        }
        public void desabilitarCampos()
        {
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            txtNome.Focus();
        }
        public void habilitarCampos()
        {
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            txtNome.Focus();
        }
        public frmCadastro(string produto)
        {
            InitializeComponent();
            txtNome.Text = produto;
            valorProduto(txtNome.Text);
            habilitarCampos();
        }

        public int CadastroProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProdutos(nome,preco,descricao) values(@nome,@preco,@descricao);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = nudPreco.Text;
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

            nudPreco.Text = Dr["preco"].ToString();
            txtId.Text = Dr["codProd"].ToString();
            txtDescricao.Text = Dr["descricao"].ToString();

            Conexao.fecharConexao();

        }


        private void LimparCampos()
        {
            txtNome.Clear();
            nudPreco.Value = 0;
            txtId.Clear();
            txtDescricao.Clear();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || nudPreco.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
                return;
            }
            if (CadastroProdutos() == 1)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
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

        }


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

            nudPreco.Text = Dr["preco"].ToString();
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
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 18).Value = nudPreco.Text;
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
                nudPreco.Value = 0;
                txtDescricao.Clear();
                desabilitarCampos();
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
                nudPreco.Value = 0;
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
            abrir.ShowDialog();
            this.Hide();
        }

        private void mspVendas_Click(object sender, EventArgs e)
        {
            frmVendas abrir = new frmVendas();
            abrir.Show();
            this.Hide();
        }

        private void mspCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa abrir = new frmCaixa();
            abrir.Show();
            this.Hide();
        }
    }
}
