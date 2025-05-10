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
using System.Runtime.InteropServices;

namespace Cadastro_de_produto
{
    public partial class frmAtualizarProdutos : Form
    {
        
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
            comm.CommandText = "SELECT nome FROM tbProdutos WHERE nome LIKE @nome"; 
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = "%" + descricao + "%";

            try
            {
                comm.Connection = Conexao.obterConexao();

                MySqlDataReader DR = comm.ExecuteReader();

                while (DR.Read())
                {
                    ltbPesquisar.Items.Add((DR.GetString(0)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar o produto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ltbPesquisar.Items.Count == 0)
                {
                    MessageBox.Show("Produto não encontrado. Por favor digite outro produto",
                        "Mensagem do Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtNome.Clear();
                    txtNome.Focus();
                }
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

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.Focus();
                btnPesquisar_Click(sender, e);
            }
        }

        private void frmAtualizarProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }
    }
}
