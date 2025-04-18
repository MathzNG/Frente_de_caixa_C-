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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
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
                ltbProdutos.Items.Add(dr["nome"].ToString());
            }
            Conexao.fecharConexao();
        }

        public void valorProduto(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select preco from tbProdutos where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader Dr;
            Dr = comm.ExecuteReader();
            Dr.Read();

            lblInvisiblepreco.Text = Dr["preco"].ToString();

            Conexao.fecharConexao();

        }
        public void FundoTransparente()
        {
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Parent = pctFundo;

            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Parent = pctFundo;

            lblValorTotal.BackColor = Color.Transparent;
            lblValorTotal.Parent = pctFundo;

            lblInvisiblepreco.BackColor = Color.Transparent;
            lblInvisiblepreco.Parent = pctFundo;

            lblInvisibleTotal.BackColor = Color.Transparent;
            lblInvisibleTotal.Parent = pctFundo;

            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Parent = pctFundo;

        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            FundoTransparente();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void ltbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbProdutos.SelectedItem != null)
            {
                string itemSelecionado = ltbProdutos.SelectedItem.ToString();
                valorProduto(itemSelecionado);
            }
        }
    }
}
