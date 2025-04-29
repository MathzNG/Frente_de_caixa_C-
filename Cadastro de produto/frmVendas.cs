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

        }

        public void pesquisarPorData(string data)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT p.nome, v.valor, v.quantidade " +
                   "FROM tbVendas AS v " +
                   "INNER JOIN tbProdutos AS p ON v.codProd = p.codProd; ";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@dataVenda", MySqlDbType.Date).Value = data;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                string produto = $"{DR["nome"]} - {DR["quantidade"]} - {DR["valor"]}";
               
            }
            Conexao.fecharConexao();
        }

        public void carregarProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "SELECT p.codProd AS 'Código',p.preco AS 'Preço', p.nome AS 'Nome', v.quantidade AS 'Quantidade',v.valor AS 'Valor Total' " +
                   "FROM tbVendas AS v " +
                   "INNER JOIN tbProdutos AS p ON v.codProd = p.codProd;";
            comm.CommandType = CommandType.Text;

            MySqlDataReader da = comm.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(da);

            dgvVendas.DataSource = dataTable;
        }

        public void limparCampos()
        {
            mskData.Text = "";
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (!mskData.MaskCompleted)
            {
                MessageBox.Show("Digite a data da venda para pesquisar.",
                    "Messagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
                mskData.Focus();
                return;
            }
            else
            {
                pesquisarPorData(mskData.Text);
                carregarProdutos();
            }
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvVendas.Rows)
            {
                if (row.IsNewRow) continue;


                if (row.Cells["Valor Total"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["Valor Total"].Value);
                }
            }
            txtTotalVenda.Text = "R$" + total.ToString("F2");
        }
    }
}
