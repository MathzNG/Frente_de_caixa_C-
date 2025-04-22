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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        public frmVendas(string valor)
        {
            InitializeComponent();
            ltbValor.Items.Add(valor);
        }

    }
}
