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
using Org.BouncyCastle.Asn1.Mozilla;

namespace Cadastro_de_produto
{
    public partial class frmCaixa : Form
    {

        public string Valor { get; set; }

        public frmCaixa()
        {
            InitializeComponent();
            produtosLista();
        }
        public void LimparCampos()
        {
            lblInvisiblepreco.Text = "";
            lblInvisibleTotal.Text = "";
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
            MySqlCommand comm = new MySqlCommand();
<<<<<<< HEAD
            comm.CommandText = "insert into tbVendas(valor,dataVenda)values(@valor,@dataVenda);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@valor",MySqlDbType.Decimal,18).Value = lblInvisibleTotal.Text;
            comm.Parameters.Add("@dataVenda",MySqlDbType.Date).Value = dtpDataVenda.Text;

            comm.Connection = Conexao.obterConexao();
=======
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "insert into tbVendas(valor) values(@valor);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@valor",MySqlDbType.VarChar,100).Value = lblInvisibleTotal.Text;
>>>>>>> 1196cfc3d3eda50cb68f7f6f6c81d3638fc9f997

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public void valorProduto(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select preco from tbProdutos where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader Dr;
            Dr = comm.ExecuteReader();
            Dr.Read();

            lblInvisiblepreco.Text = Dr["preco"].ToString();

            Conexao.fecharConexao();

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

            btnConfirma.BackColor = Color.Transparent;
            btnConfirma.Parent = pctFundo;

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

        private void ltbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbProdutos.SelectedItem != null)
            {
                string itemSelecionado = ltbProdutos.SelectedItem.ToString();
                valorProduto(itemSelecionado);
               
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
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
            double valorMultiplicador = Convert.ToInt32(nudQuantidade.Value);
            double valorProduto = Convert.ToDouble(lblInvisiblepreco.Text);
            double resultado = valorProduto * valorMultiplicador;

            lblInvisibleTotal.Text = resultado.ToString();

            DialogResult resul = MessageBox.Show("Deseja confirmar a venda?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (resul == DialogResult.Yes)
            { 
                valorVenda();
<<<<<<< HEAD
                MessageBox.Show("Venda confirmada com sucesso!");
                LimparCampos();
=======
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
>>>>>>> 1196cfc3d3eda50cb68f7f6f6c81d3638fc9f997
            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirma.Focus();
            }
        }
    }
}
