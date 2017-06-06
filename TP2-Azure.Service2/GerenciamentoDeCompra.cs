using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3_Azure.Domain;
using Tp3_Azure.Data;

namespace TP2_Azure.Service2
{
    public class GerenciamentoDeCompra : IGerenciamentoDeCompra_V1, IGerenciamentoDeCompra_V2
    {
        CloudQueue queue;
        public GerenciamentoDeCompra()
        {
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            queue = queueClient.GetQueueReference("pedidos");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();
        }
        
        public Guid RealizarPedido(Produto p)
        {

            Pedido pedido = new Pedido();
            pedido.Produtos.Add(p);
            Tp3_Azure.Data.PedidoDao dao = new PedidoDao();
            dao.Add(pedido);

            var json = JsonConvert.SerializeObject(pedido);

            CloudQueueMessage message = new CloudQueueMessage(json);
            queue.AddMessage(message);
            return pedido.PedidoId;

        }

        public Guid RealizarPedido(List<Produto> p)
        {
            Pedido pedido = new Pedido();
            pedido.Produtos = p;
            PedidoDao dao = new PedidoDao();
            dao.Add(pedido);
            CloudQueueMessage message = new CloudQueueMessage(pedido.PedidoId.ToString());
            queue.AddMessage(message);
            return pedido.PedidoId;
        }
    }
}
