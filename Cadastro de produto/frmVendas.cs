using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

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

        public int registro()
        {
            int valor = 0;

            foreach (DataGridViewRow row in dgvVendas.Rows)
            {
                if (row.IsNewRow) continue;

                string data = mskData.Text;
                int id = Convert.ToInt32(row.Cells["Código"].Value);
                double preco = Convert.ToDouble(row.Cells["Preço"].Value);
                string nome = Convert.ToString(row.Cells["Nome"].Value);
                int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                double total = Convert.ToDouble(row.Cells["Valor Total"].Value);
                double totalVenda = Convert.ToDouble(txtTotalVenda.Text.Replace("R$", "").Trim());


                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbRegistro(data,codigo,preco,nome,quantidade,valorTotal,totalVenda) values(@data,@codigo,@preco,@nome,@quantidade,@valorTotal,@totalVenda);";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@data", MySqlDbType.Date).Value = DateTime.ParseExact(data, "dd/MM/yyyy", null);
                comm.Parameters.Add("@codigo",MySqlDbType.Int32).Value = id;
                comm.Parameters.Add("@preco", MySqlDbType.Decimal).Value = preco;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
                comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
                comm.Parameters.Add("@valorTotal", MySqlDbType.Decimal).Value = total;
                comm.Parameters.Add("@totalVenda", MySqlDbType.Decimal).Value = totalVenda;

                comm.Connection = Conexao.obterConexao();

                valor += comm.ExecuteNonQuery();

                Conexao.fecharConexao();


            }
            return valor;
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
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(comm);

                DataTable dataTable = new DataTable();

                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dgvVendas.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Nenhuma venda encontrada para a data informada.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    limparCampos();
                }

                Conexao.fecharConexao();

            }
            catch (Exception)
            {
                MessageBox.Show("Liga o banco de dados",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

                registro();
            }
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void mskData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisa.Focus();
                btnPesquisa_Click(sender, e);
            }
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro abrir = new frmRegistro();
            abrir.Show();
            this.Hide();
        }
    }
}
