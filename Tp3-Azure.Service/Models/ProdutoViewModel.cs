using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Azure.Service.Models
{
    class ProdutoViewModel
    {

        public Guid ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public string Preco { get; set; }

        public int Quantidade { get; set; }

        public string Flag { get; set; }

    }
}
