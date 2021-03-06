﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tp3_Azure.Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGerenciamentoDeProdutoService")]
    public interface IGerenciamentoDeProdutoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Create", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/CreateResponse")]
        void Create(Tp3_Azure.Domain.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Create", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(Tp3_Azure.Domain.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Get", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/GetResponse")]
        Tp3_Azure.Domain.Produto Get(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Get", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/GetResponse")]
        System.Threading.Tasks.Task<Tp3_Azure.Domain.Produto> GetAsync(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/GetAll", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/GetAllResponse")]
        Tp3_Azure.Domain.Produto[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/GetAll", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/GetAllResponse")]
        System.Threading.Tasks.Task<Tp3_Azure.Domain.Produto[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Edit", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/EditResponse")]
        void Edit(System.Guid produtoId, Tp3_Azure.Domain.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Edit", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/EditResponse")]
        System.Threading.Tasks.Task EditAsync(System.Guid produtoId, Tp3_Azure.Domain.Produto p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Delete", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/DeleteResponse")]
        void Delete(System.Guid produtoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/Delete", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(System.Guid produtoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/ExecutarFila", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/ExecutarFilaResponse")]
        void ExecutarFila();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGerenciamentoDeProdutoService/ExecutarFila", ReplyAction="http://tempuri.org/IGerenciamentoDeProdutoService/ExecutarFilaResponse")]
        System.Threading.Tasks.Task ExecutarFilaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGerenciamentoDeProdutoServiceChannel : Tp3_Azure.Client.ServiceReference1.IGerenciamentoDeProdutoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GerenciamentoDeProdutoServiceClient : System.ServiceModel.ClientBase<Tp3_Azure.Client.ServiceReference1.IGerenciamentoDeProdutoService>, Tp3_Azure.Client.ServiceReference1.IGerenciamentoDeProdutoService {
        
        public GerenciamentoDeProdutoServiceClient() {
        }
        
        public GerenciamentoDeProdutoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GerenciamentoDeProdutoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GerenciamentoDeProdutoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GerenciamentoDeProdutoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(Tp3_Azure.Domain.Produto p) {
            base.Channel.Create(p);
        }
        
        public System.Threading.Tasks.Task CreateAsync(Tp3_Azure.Domain.Produto p) {
            return base.Channel.CreateAsync(p);
        }
        
        public Tp3_Azure.Domain.Produto Get(string nome) {
            return base.Channel.Get(nome);
        }
        
        public System.Threading.Tasks.Task<Tp3_Azure.Domain.Produto> GetAsync(string nome) {
            return base.Channel.GetAsync(nome);
        }
        
        public Tp3_Azure.Domain.Produto[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Tp3_Azure.Domain.Produto[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Edit(System.Guid produtoId, Tp3_Azure.Domain.Produto p) {
            base.Channel.Edit(produtoId, p);
        }
        
        public System.Threading.Tasks.Task EditAsync(System.Guid produtoId, Tp3_Azure.Domain.Produto p) {
            return base.Channel.EditAsync(produtoId, p);
        }
        
        public void Delete(System.Guid produtoId) {
            base.Channel.Delete(produtoId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(System.Guid produtoId) {
            return base.Channel.DeleteAsync(produtoId);
        }
        
        public void ExecutarFila() {
            base.Channel.ExecutarFila();
        }
        
        public System.Threading.Tasks.Task ExecutarFilaAsync() {
            return base.Channel.ExecutarFilaAsync();
        }
    }
}
