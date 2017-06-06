using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3_Azure.Data.Context;
using Tp3_Azure.Domain;

namespace Tp3_Azure.Data
{
    public class PedidoDao
    {
        
        DataContext _contexto;
        public PedidoDao()
        {
            this._contexto = new DataContext();
        }

        public void Add(Pedido p)
        {
            _contexto.Pedidos.Add(p);
            _contexto.SaveChanges();
        }
        
    }

}
