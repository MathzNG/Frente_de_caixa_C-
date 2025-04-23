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
            txtNome.Focus();
        }
        

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisar.SelectedItem != null)
            {
                string produto = ltbPesquisar.SelectedItem.ToString();
                frmCadastro abrir = new frmCadastro(produto);
                abrir.Show();
                this.Hide();

            }
        }
        public void pesquisarPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbProdutos where nome like '%" + descricao + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = descricao;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                ltbPesquisar.Items.Add((DR.GetString(0)));
            }

            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite o nome do produto para pesquisar.");
                return;
            }
            pesquisarPorNome(txtNome.Text);
        }
    }
}
