﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9164
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfApp2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PrajwalContact", Namespace="http://schemas.datacontract.org/2004/07/WcfApp2")]
    public partial class PrajwalContact : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string GenderField;
        
        private int IdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender
        {
            get
            {
                return this.GenderField;
            }
            set
            {
                this.GenderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPrajwalService")]
public interface IPrajwalService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrajwalService/Insert", ReplyAction="http://tempuri.org/IPrajwalService/InsertResponse")]
    int Insert(WcfApp2.PrajwalContact GenderPar);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IPrajwalServiceChannel : IPrajwalService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class PrajwalServiceClient : System.ServiceModel.ClientBase<IPrajwalService>, IPrajwalService
{
    
    public PrajwalServiceClient()
    {
    }
    
    public PrajwalServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PrajwalServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PrajwalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PrajwalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int Insert(WcfApp2.PrajwalContact GenderPar)
    {
        return base.Channel.Insert(GenderPar);
    }
}
