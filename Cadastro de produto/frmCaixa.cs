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
        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            lblInvisiblepreco.Text = "";
            lblInvisibleTotal.Text = "";
            nudQuantidade.ValueChanged -= nudQuantidade_ValueChanged;
            nudQuantidade.Value = 0;
            nudQuantidade.ValueChanged += nudQuantidade_ValueChanged;
        }
        public void produtosLista()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "select nome,codProd from tbProdutos;";
            comm.CommandType = CommandType.Text;

            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                ltbProdutos.Items.Add(dr["nome"].ToString());
            }
            Conexao.fecharConexao();
        }

        public int valorVenda()
        {
            int valor = 0;
            
            foreach (DataGridViewRow row in dgvProduto.Rows)
            {
                if (row.IsNewRow) continue;

                int id = Convert.ToInt32(row.Cells["Código"].Value);
                int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                double preco = Convert.ToDouble(row.Cells["Valor Total"].Value);

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbVendas(codProd,dataVenda,quantidade,valor) values(@codProd,@dataVenda,@quantidade,@valor);";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@codProd", MySqlDbType.Int32).Value = id;
                comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
                comm.Parameters.Add("@valor", MySqlDbType.Decimal,18).Value = preco;
                comm.Parameters.Add("@dataVenda", MySqlDbType.Date).Value = DateTime.Now;

                comm.Connection = Conexao.obterConexao();

                valor += comm.ExecuteNonQuery();

                Conexao.fecharConexao();

               
            }
            return valor;
        }

        public void valorProduto(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select preco,codProd,nome from tbProdutos where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader Dr;
            Dr = comm.ExecuteReader();
            Dr.Read();

            lblInvisiblepreco.Text = Dr["preco"].ToString();
            txtCodigo.Text = Dr["codProd"].ToString();
            txtNome.Text = Dr["nome"].ToString();


            Conexao.fecharConexao();

        }

        public void adicionarProduto()
        {
            dgvProduto.Rows.Add(txtCodigo.Text, txtNome.Text, lblInvisiblepreco.Text, nudQuantidade.Value.ToString(), lblInvisibleTotal.Text);
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

            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Parent = pctFundo;

            lblNome.BackColor = Color.Transparent;
            lblNome.Parent = pctFundo;

            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Parent = pctFundo;

            btnAdicionar.BackColor = Color.Transparent;
            btnAdicionar.Parent = pctFundo;

            btnFinalizar.BackColor = Color.Transparent;
            btnFinalizar.Parent = pctFundo;

        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            FundoTransparente();

            dgvProduto.Columns.Add(lblCodigo.Text, "Código");
            dgvProduto.Columns.Add(lblNome.Text, "Nome");
            dgvProduto.Columns.Add(lblPreco.Text, "Preço");
            dgvProduto.Columns.Add(lblQuantidade.Text, "Quantidade");
            dgvProduto.Columns.Add("Valor Total", "Valor Total");
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

        private void btnConfirma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirma_Click_1(sender, e);
            }
        }

        private void btnConfirma_Click_1(object sender, EventArgs e)
        {
            if (ltbProdutos.SelectedItem != null)
            {
                string itemSelecionado = ltbProdutos.SelectedItem.ToString();
                valorProduto(itemSelecionado);
            }
            else
            {
                MessageBox.Show("Selecione um produto da lista.",
                     "Messagem do Sistema",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1);
                return;
            }
            if (nudQuantidade.Value == 0)
            {
                MessageBox.Show("Selecione uma quantidade.",
                    "Messagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            adicionarProduto();
            LimparCampos();
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Deseja confirmar a venda?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (resul == DialogResult.Yes)
            {
                MessageBox.Show("Venda confirmada com sucesso!",
                    "Messagem de Sucesso");
                valorVenda();
                LimparCampos();
                dgvProduto.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Erro");

            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(lblInvisiblepreco.Text);
            int quantidade = Convert.ToInt32(nudQuantidade.Value);
            double total = preco * quantidade;

            lblInvisibleTotal.Text = total.ToString("F2");
        }
    }
}
