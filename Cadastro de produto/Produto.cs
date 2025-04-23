using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_produto
{
    internal class Produto
    {
            public long Id { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
          
        public string Descricao { get; set; }

        public static List<Produto> ListaProdutos = new List<Produto>();

    }
}
