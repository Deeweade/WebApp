﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonsFromDatabase", ReplyAction="http://tempuri.org/IService1/GetPersonsFromDatabaseResponse")]
        System.Data.DataTable GetPersonsFromDatabase(string letter, bool isFirstLetter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPersonsFromDatabase", ReplyAction="http://tempuri.org/IService1/GetPersonsFromDatabaseResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetPersonsFromDatabaseAsync(string letter, bool isFirstLetter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestConnection", ReplyAction="http://tempuri.org/IService1/TestConnectionResponse")]
        string[] TestConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TestConnection", ReplyAction="http://tempuri.org/IService1/TestConnectionResponse")]
        System.Threading.Tasks.Task<string[]> TestConnectionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApp.ServiceReference1.IService1>, WebApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetPersonsFromDatabase(string letter, bool isFirstLetter) {
            return base.Channel.GetPersonsFromDatabase(letter, isFirstLetter);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetPersonsFromDatabaseAsync(string letter, bool isFirstLetter) {
            return base.Channel.GetPersonsFromDatabaseAsync(letter, isFirstLetter);
        }
        
        public string[] TestConnection() {
            return base.Channel.TestConnection();
        }
        
        public System.Threading.Tasks.Task<string[]> TestConnectionAsync() {
            return base.Channel.TestConnectionAsync();
        }
    }
}
