﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerInformationInformationSchedular.ServerInformationReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerInformationReference.IServerInformationSetter")]
    public interface IServerInformationSetter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerInformationSetter/AddServer", ReplyAction="http://tempuri.org/IServerInformationSetter/AddServerResponse")]
        void AddServer(string hostName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerInformationSetter/AddServer", ReplyAction="http://tempuri.org/IServerInformationSetter/AddServerResponse")]
        System.Threading.Tasks.Task AddServerAsync(string hostName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerInformationSetter/SetServerInformation", ReplyAction="http://tempuri.org/IServerInformationSetter/SetServerInformationResponse")]
        void SetServerInformation(ServerInformationShared.ServerInformation serverInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerInformationSetter/SetServerInformation", ReplyAction="http://tempuri.org/IServerInformationSetter/SetServerInformationResponse")]
        System.Threading.Tasks.Task SetServerInformationAsync(ServerInformationShared.ServerInformation serverInformation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerInformationSetterChannel : ServerInformationInformationSchedular.ServerInformationReference.IServerInformationSetter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerInformationSetterClient : System.ServiceModel.ClientBase<ServerInformationInformationSchedular.ServerInformationReference.IServerInformationSetter>, ServerInformationInformationSchedular.ServerInformationReference.IServerInformationSetter {
        
        public ServerInformationSetterClient() {
        }
        
        public ServerInformationSetterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerInformationSetterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerInformationSetterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerInformationSetterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddServer(string hostName) {
            base.Channel.AddServer(hostName);
        }
        
        public System.Threading.Tasks.Task AddServerAsync(string hostName) {
            return base.Channel.AddServerAsync(hostName);
        }
        
        public void SetServerInformation(ServerInformationShared.ServerInformation serverInformation) {
            base.Channel.SetServerInformation(serverInformation);
        }
        
        public System.Threading.Tasks.Task SetServerInformationAsync(ServerInformationShared.ServerInformation serverInformation) {
            return base.Channel.SetServerInformationAsync(serverInformation);
        }
    }
}
