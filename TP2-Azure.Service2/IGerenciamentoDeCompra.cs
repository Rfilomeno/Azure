using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Tp3_Azure.Domain;

namespace TP2_Azure.Service2
{
    [ServiceContract(Name = "GerenciamentoDeCompra", Namespace = "http://gerenciamentodecompra.com/v1/")]
    public interface IGerenciamentoDeCompra_V1
    {
        [OperationContract]
        Guid RealizarPedido(Produto p);
    }

    [ServiceContract(Name = "GerenciamentoDeCompra", Namespace = "http://gerenciamentodecompra.com/v2/")]
    public interface IGerenciamentoDeCompra_V2
    {

        [OperationContract]
        Guid RealizarPedido(List<Produto> p);
    }
}
