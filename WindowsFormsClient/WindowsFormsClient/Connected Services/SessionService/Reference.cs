﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.SessionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SessionService.ISessionService")]
    public interface ISessionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionService/GetCount", ReplyAction="http://tempuri.org/ISessionService/GetCountResponse")]
        int GetCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionService/GetCount", ReplyAction="http://tempuri.org/ISessionService/GetCountResponse")]
        System.Threading.Tasks.Task<int> GetCountAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISessionServiceChannel : WindowsFormsClient.SessionService.ISessionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SessionServiceClient : System.ServiceModel.ClientBase<WindowsFormsClient.SessionService.ISessionService>, WindowsFormsClient.SessionService.ISessionService {
        
        public SessionServiceClient() {
        }
        
        public SessionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SessionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetCount() {
            return base.Channel.GetCount();
        }
        
        public System.Threading.Tasks.Task<int> GetCountAsync() {
            return base.Channel.GetCountAsync();
        }
    }
}