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
    public partial class frmProdutos : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmProdutos()
        {
            InitializeComponent();
        }

        public void carregarProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "select codProd as 'Código', nome as Produto, preco as 'Preço', descricao as 'Descrição' from tbProdutos;";
            comm.CommandType = CommandType.Text;
            try
            {
                MySqlDataReader da = comm.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(da);

                dgvProdutos.DataSource = dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Ligar o banco de dados!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void limparInformacoes()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.Rows.Clear();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            
            carregarProdutos();
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void dgvProdutos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dgvProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (dgvProdutos.Columns[e.ColumnIndex].Name == "colDescricao")
                {
                    cell.ToolTipText = cell.Value?.ToString();
                }
            }
        }

        private void smiMenu_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void tsmCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }

        private void tsmCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa abrir = new frmCaixa();
            abrir.Show();
            this.Hide();
        }

        private void tsmVendas_Click(object sender, EventArgs e)
        {
            frmVendas abrir = new frmVendas();
            abrir.Show();
            this.Hide();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro abrir = new frmRegistro();
            abrir.Show();
            this.Hide();
        }
    }
}
