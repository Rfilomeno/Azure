using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3_Azure.Data;
using Tp3_Azure.Domain;
using Tp3_Azure.Service.Models;

namespace Tp3_Azure.Service.Helper
{
    public class FilaHelper
    {
        CloudQueue queue;
        ProdutoDao dao;
        public FilaHelper()
        {
            this.dao = new ProdutoDao();
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            queue = queueClient.GetQueueReference("produtos");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();
        }

        public void AdicionarProduto(Produto p)
        {
            ProdutoViewModel pvm = new ProdutoViewModel()
            {
                ProdutoId = p.ProdutoId,
                Nome = p.Nome,
                Categoria = p.Categoria,
                Quantidade = p.Quantidade,
                Preco = p.Preco,
                Flag = "Adicionar"
            };

            var json = JsonConvert.SerializeObject(pvm);

            CloudQueueMessage message = new CloudQueueMessage(json);
            queue.AddMessage(message);
        }

        public void EditarProduto(Produto p)
        {
            ProdutoViewModel pvm = new ProdutoViewModel()
            {
                ProdutoId = p.ProdutoId,
                Nome = p.Nome,
                Categoria = p.Categoria,
                Quantidade = p.Quantidade,
                Preco = p.Preco,
                Flag = "Editar"
            };

            var json = JsonConvert.SerializeObject(pvm);

            CloudQueueMessage message = new CloudQueueMessage(json);
            queue.AddMessage(message);
        }

        public void DeletarProduto(Guid p)
        {
            ProdutoViewModel pvm = new ProdutoViewModel()
            {
                ProdutoId = p,
                Nome = "",
                Categoria = "",
                Quantidade = 0,
                Preco = "",
                Flag = "Deletar"
            };

            var json = JsonConvert.SerializeObject(pvm);

            CloudQueueMessage message = new CloudQueueMessage(json);
            queue.AddMessage(message);
        }

        public void Executar()
        {

            foreach (CloudQueueMessage message in queue.GetMessages(20, TimeSpan.FromMinutes(5)))
            {
                var message1 = message.AsString;
                ProdutoViewModel pvm = JsonConvert.DeserializeObject<ProdutoViewModel>(message1);
                Produto p = new Produto()
                {
                    ProdutoId = pvm.ProdutoId,
                    Nome = pvm.Nome,
                    Categoria = pvm.Categoria,
                    Preco = pvm.Preco,
                    Quantidade = pvm.Quantidade
                };

                switch (pvm.Flag)
                {
                    case "Adicionar":
                        dao.Add(p);
                        break;
                    case "Editar":
                        dao.Edit(p.ProdutoId, p);
                        break;
                    case "Deletar":
                        dao.Delete(p.ProdutoId);
                        break;
                }

                queue.DeleteMessage(message);
            }
        }

        public int? TamanhoDaFila()
        {
            queue.FetchAttributes();

            // Retrieve the cached approximate message count.
            int? cachedMessageCount = queue.ApproximateMessageCount;
            
            // Display number of messages.
            return cachedMessageCount;
        }

    }
}
