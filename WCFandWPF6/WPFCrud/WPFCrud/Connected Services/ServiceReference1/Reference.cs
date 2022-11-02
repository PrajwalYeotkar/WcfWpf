﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFCrud.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfCrud")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MobileNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MobileNumber {
            get {
                return this.MobileNumberField;
            }
            set {
                if ((this.MobileNumberField.Equals(value) != true)) {
                    this.MobileNumberField = value;
                    this.RaisePropertyChanged("MobileNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPerson", ReplyAction="http://tempuri.org/IService1/GetPersonResponse")]
        WPFCrud.ServiceReference1.Person[] GetPerson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPerson", ReplyAction="http://tempuri.org/IService1/GetPersonResponse")]
        System.Threading.Tasks.Task<WPFCrud.ServiceReference1.Person[]> GetPersonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        void InsertPerson(WPFCrud.ServiceReference1.Person pobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPerson", ReplyAction="http://tempuri.org/IService1/InsertPersonResponse")]
        System.Threading.Tasks.Task InsertPersonAsync(WPFCrud.ServiceReference1.Person pobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        void UpdatePerson(WPFCrud.ServiceReference1.Person pobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePerson", ReplyAction="http://tempuri.org/IService1/UpdatePersonResponse")]
        System.Threading.Tasks.Task UpdatePersonAsync(WPFCrud.ServiceReference1.Person pobj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        void DeletePerson(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePerson", ReplyAction="http://tempuri.org/IService1/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/conv", ReplyAction="http://tempuri.org/IService1/convResponse")]
        WPFCrud.ServiceReference1.Person conv(int id, int mobilenumber, string name, string address, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/conv", ReplyAction="http://tempuri.org/IService1/convResponse")]
        System.Threading.Tasks.Task<WPFCrud.ServiceReference1.Person> convAsync(int id, int mobilenumber, string name, string address, string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WPFCrud.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WPFCrud.ServiceReference1.IService1>, WPFCrud.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WPFCrud.ServiceReference1.Person[] GetPerson() {
            return base.Channel.GetPerson();
        }
        
        public System.Threading.Tasks.Task<WPFCrud.ServiceReference1.Person[]> GetPersonAsync() {
            return base.Channel.GetPersonAsync();
        }
        
        public void InsertPerson(WPFCrud.ServiceReference1.Person pobj) {
            base.Channel.InsertPerson(pobj);
        }
        
        public System.Threading.Tasks.Task InsertPersonAsync(WPFCrud.ServiceReference1.Person pobj) {
            return base.Channel.InsertPersonAsync(pobj);
        }
        
        public void UpdatePerson(WPFCrud.ServiceReference1.Person pobj) {
            base.Channel.UpdatePerson(pobj);
        }
        
        public System.Threading.Tasks.Task UpdatePersonAsync(WPFCrud.ServiceReference1.Person pobj) {
            return base.Channel.UpdatePersonAsync(pobj);
        }
        
        public void DeletePerson(int Id) {
            base.Channel.DeletePerson(Id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int Id) {
            return base.Channel.DeletePersonAsync(Id);
        }
        
        public WPFCrud.ServiceReference1.Person conv(int id, int mobilenumber, string name, string address, string email) {
            return base.Channel.conv(id, mobilenumber, name, address, email);
        }
        
        public System.Threading.Tasks.Task<WPFCrud.ServiceReference1.Person> convAsync(int id, int mobilenumber, string name, string address, string email) {
            return base.Channel.convAsync(id, mobilenumber, name, address, email);
        }
    }
}
