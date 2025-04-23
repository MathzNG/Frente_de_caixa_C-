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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        public void carregarProdutos()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "select codProd as Codigo, nome as Produto, preco as Preco, descricao as Descricao from tbProdutos;";
            comm.CommandType = CommandType.Text;

            MySqlDataReader da = comm.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(da);

            dgvProdutos.DataSource = dataTable;
        }

        public void limparInformacoes()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.Rows.Clear();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = Produto.ListaProdutos;
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

        private void carregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carregarProdutos();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparInformacoes();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();  
            abrir.Show();
            this.Hide();
        }
    }
}
