﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerInformationInformationSchedular.ServerHealthReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerHealthReference.IServerHealth")]
    public interface IServerHealth {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerHealth/GetServerInformation", ReplyAction="http://tempuri.org/IServerHealth/GetServerInformationResponse")]
        ServerInformationShared.ServerInformation GetServerInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerHealth/GetServerInformation", ReplyAction="http://tempuri.org/IServerHealth/GetServerInformationResponse")]
        System.Threading.Tasks.Task<ServerInformationShared.ServerInformation> GetServerInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerHealthChannel : ServerInformationInformationSchedular.ServerHealthReference.IServerHealth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerHealthClient : System.ServiceModel.ClientBase<ServerInformationInformationSchedular.ServerHealthReference.IServerHealth>, ServerInformationInformationSchedular.ServerHealthReference.IServerHealth {
        
        public ServerHealthClient() {
        }
        
        public ServerHealthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerHealthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerHealthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerHealthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServerInformationShared.ServerInformation GetServerInformation() {
            return base.Channel.GetServerInformation();
        }
        
        public System.Threading.Tasks.Task<ServerInformationShared.ServerInformation> GetServerInformationAsync() {
            return base.Channel.GetServerInformationAsync();
        }
    }
}