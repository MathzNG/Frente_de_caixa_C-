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
    public partial class frmCadastro : Form
    {
        private RepositorioProduto repositorio = new RepositorioProduto();
        public frmCadastro()
        {
            InitializeComponent();
        }

        public int CadastroProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProdutos(nome,preco,descricao) values(@nome,@preco,@descricao);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar,100).Value = txtNome.Text;
            comm.Parameters.Add("@preco", MySqlDbType.Decimal,18).Value = txtPreco.Text;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtId.Clear();

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


        private void mspAtualizar_Click(object sender, EventArgs e)
        {
            frmAtualizarProdutos abrir = new frmAtualizarProdutos();
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


    }
}
