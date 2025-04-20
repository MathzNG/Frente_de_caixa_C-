using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_produto
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
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
    }
}
