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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
            verVenda();
        }
        public frmVendas(string valor)
        {
            InitializeComponent();
            ltbValor.Items.Add(valor);
        }
        public void verVenda()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select valor from tbVendas;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr = comm.ExecuteReader();
            while(dr.Read())
            {  
                ltbValor.Items.Add(dr["valor"].ToString());
            }
            Conexao.fecharConexao();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa abrir = new frmCaixa();
            abrir.Show();
            this.Hide();
        }
    }
}
