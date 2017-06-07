using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3_Azure.Data;
using Tp3_Azure.Domain;
using Tp3_Azure.Service.Helper;

namespace Tp3_Azure.Service
{
    public class GerenciamentoDeProdutoService : IGerenciamentoDeProdutoService
    {
        ProdutoDao dao;
        FilaHelper fila;
        public GerenciamentoDeProdutoService()
        {
            this.dao = new ProdutoDao();
            this.fila = new FilaHelper();
        }

        public void Create(Produto p)
        {
            fila.AdicionarProduto(p);
            //dao.Add(p); //é Realizado ao executar a fila
        }

        public void Delete(Guid produtoId)
        {
            fila.DeletarProduto(produtoId);
            // dao.Delete(produtoId); //é Realizado ao executar a fila
        }

        public void Edit(Guid produtoId, Produto p)
        {
            fila.EditarProduto(p);
            //dao.Edit(produtoId, p); //é Realizado ao executar a fila
        }

        public Produto Get(string nome)
        {
            return dao.Get(nome);
        }

        public IList<Produto> GetAll()
        {
            return dao.GetAll();
        }

        public void ExecutarFila()
        {
            fila.Executar();
        }
    }
}
