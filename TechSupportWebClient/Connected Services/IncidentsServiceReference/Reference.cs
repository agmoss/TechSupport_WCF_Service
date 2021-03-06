﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechSupportWebClient.IncidentsServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Incidents", Namespace="http://schemas.datacontract.org/2004/07/TechSupportWcfService")]
    [System.SerializableAttribute()]
    public partial class Incidents : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateClosedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateOpenedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IncidentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TechIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public System.Nullable<int> CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateClosed {
            get {
                return this.DateClosedField;
            }
            set {
                if ((this.DateClosedField.Equals(value) != true)) {
                    this.DateClosedField = value;
                    this.RaisePropertyChanged("DateClosed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateOpened {
            get {
                return this.DateOpenedField;
            }
            set {
                if ((this.DateOpenedField.Equals(value) != true)) {
                    this.DateOpenedField = value;
                    this.RaisePropertyChanged("DateOpened");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IncidentID {
            get {
                return this.IncidentIDField;
            }
            set {
                if ((this.IncidentIDField.Equals(value) != true)) {
                    this.IncidentIDField = value;
                    this.RaisePropertyChanged("IncidentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCode {
            get {
                return this.ProductCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductCodeField, value) != true)) {
                    this.ProductCodeField = value;
                    this.RaisePropertyChanged("ProductCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TechID {
            get {
                return this.TechIDField;
            }
            set {
                if ((this.TechIDField.Equals(value) != true)) {
                    this.TechIDField = value;
                    this.RaisePropertyChanged("TechID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IncidentsServiceReference.IIncidentsService")]
    public interface IIncidentsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncidentsService/GetTechIncidents", ReplyAction="http://tempuri.org/IIncidentsService/GetTechIncidentsResponse")]
        TechSupportWebClient.IncidentsServiceReference.Incidents[] GetTechIncidents(int TechID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncidentsService/GetTechIncidents", ReplyAction="http://tempuri.org/IIncidentsService/GetTechIncidentsResponse")]
        System.Threading.Tasks.Task<TechSupportWebClient.IncidentsServiceReference.Incidents[]> GetTechIncidentsAsync(int TechID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncidentsService/GetCustomerIncidents", ReplyAction="http://tempuri.org/IIncidentsService/GetCustomerIncidentsResponse")]
        TechSupportWebClient.IncidentsServiceReference.Incidents[] GetCustomerIncidents(int CustomerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncidentsService/GetCustomerIncidents", ReplyAction="http://tempuri.org/IIncidentsService/GetCustomerIncidentsResponse")]
        System.Threading.Tasks.Task<TechSupportWebClient.IncidentsServiceReference.Incidents[]> GetCustomerIncidentsAsync(int CustomerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncidentsService/GetIDs", ReplyAction="http://tempuri.org/IIncidentsService/GetIDsResponse")]
        System.Nullable<int>[] GetIDs(bool idType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIncidentsService/GetIDs", ReplyAction="http://tempuri.org/IIncidentsService/GetIDsResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>[]> GetIDsAsync(bool idType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIncidentsServiceChannel : TechSupportWebClient.IncidentsServiceReference.IIncidentsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IncidentsServiceClient : System.ServiceModel.ClientBase<TechSupportWebClient.IncidentsServiceReference.IIncidentsService>, TechSupportWebClient.IncidentsServiceReference.IIncidentsService {
        
        public IncidentsServiceClient() {
        }
        
        public IncidentsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IncidentsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IncidentsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IncidentsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TechSupportWebClient.IncidentsServiceReference.Incidents[] GetTechIncidents(int TechID) {
            return base.Channel.GetTechIncidents(TechID);
        }
        
        public System.Threading.Tasks.Task<TechSupportWebClient.IncidentsServiceReference.Incidents[]> GetTechIncidentsAsync(int TechID) {
            return base.Channel.GetTechIncidentsAsync(TechID);
        }
        
        public TechSupportWebClient.IncidentsServiceReference.Incidents[] GetCustomerIncidents(int CustomerID) {
            return base.Channel.GetCustomerIncidents(CustomerID);
        }
        
        public System.Threading.Tasks.Task<TechSupportWebClient.IncidentsServiceReference.Incidents[]> GetCustomerIncidentsAsync(int CustomerID) {
            return base.Channel.GetCustomerIncidentsAsync(CustomerID);
        }
        
        public System.Nullable<int>[] GetIDs(bool idType) {
            return base.Channel.GetIDs(idType);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>[]> GetIDsAsync(bool idType) {
            return base.Channel.GetIDsAsync(idType);
        }
    }
}
