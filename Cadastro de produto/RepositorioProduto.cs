using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_produto
{
    internal class RepositorioProduto
    {
        private List<Produto> produtos = new List<Produto>();
        private long proximoId = 1;

        public void AdicionarProduto( long id, string nome, decimal preco,string descricao)
        {
            Produto novoProduto = new Produto();
            produtos.Add(novoProduto);
        }

        public List<Produto> ListarProdutos()
        {
            return produtos;
        }
        public void AtualizarProduto(int id, decimal novoPreco)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produto.Preco = novoPreco;
                
            }
        }

        public void ExcluirProduto(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produtos.Remove(produto);
            }
        }
    }
}
