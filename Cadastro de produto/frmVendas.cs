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
    public partial class frmVendas : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
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
            comm.CommandText = @"SELECT p.codProd AS 'Código',p.preco AS 'Preço', p.nome AS 'Nome', v.quantidade AS 'Quantidade',v.valor AS 'Valor Total' " +
                   "FROM tbVendas AS v " +
                   "INNER JOIN tbProdutos AS p ON v.codProd = p.codProd where v.dataVenda = @dataVenda;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            DateTime dataFormatada = DateTime.ParseExact(mskData.Text, "dd/MM/yyyy", null);
            comm.Parameters.Add("@dataVenda", MySqlDbType.Date).Value = dataFormatada;
           
            MySqlDataAdapter da = new MySqlDataAdapter(comm);

            DataTable dataTable = new DataTable();

            da.Fill(dataTable);

            dgvVendas.DataSource = dataTable;

            Conexao.fecharConexao();
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
                carregarProdutos();

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

        private void frmVendas_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
