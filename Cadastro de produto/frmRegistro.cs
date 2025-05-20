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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            carregarData();
        }

        public void carregarData()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select DISTINCT data from tbRegistro order by data desc;";
            comm.CommandType = CommandType.Text;
            try
            {
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader DR = comm.ExecuteReader();
                while (DR.Read())
                {
                    cbbData.Items.Add(DR.GetDateTime(0).ToString("dd/MM/yyyy"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar as datas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void carregarValor(string valor)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "select totalVenda from tbRegistro where data = @data;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            try
            {
                DateTime dataConvertida = DateTime.ParseExact(cbbData.Text, "dd/MM/yyyy", null);
                comm.Parameters.Add("@data", MySqlDbType.Date).Value = dataConvertida.ToString("yyyy-MM-dd");


                MySqlDataReader DR = comm.ExecuteReader();
                if (DR.Read())
                {
                    double valorTotal = Convert.ToDouble(DR["totalVenda"]);
                    txtTotalVenda.Text = valorTotal.ToString("C2");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar o valor total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbData.Text = "";
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        public void carregarRegistro(string data)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao.obterConexao();
            comm.CommandText = "select codigo as 'Código', preco as 'Preço', nome as 'Nome', quantidade as 'Quantidade', valorTotal as 'Valor Total' from tbRegistro where data = @data;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
       
            try
            {

                DateTime dataConvertida = DateTime.ParseExact(cbbData.Text, "dd/MM/yyyy", null);
                comm.Parameters.Add("@data", MySqlDbType.Date).Value = dataConvertida.ToString("yyyy-MM-dd");
                

                MySqlDataAdapter da = new MySqlDataAdapter(comm);

                DataTable datable = new DataTable();

                da.Fill(datable);

                if (datable.Rows.Count > 0)
                {
                    dgvRegistroVenda.DataSource = datable;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado para a data selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar os registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        private void cbbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbData.SelectedItem != null)
            {
                string data = cbbData.SelectedItem.ToString();
                carregarRegistro(data);
                carregarValor(data);
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.Show();
            this.Hide();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa abrir = new frmCaixa();
            abrir.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro abrir = new frmCadastro();
            abrir.Show();
            this.Hide();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas abrir = new frmVendas();
            abrir.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }
    }
}
