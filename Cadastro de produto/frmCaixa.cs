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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
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
    }
}
