﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppProcessGo1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NumberModel", Namespace="http://schemas.datacontract.org/2004/07/WebAppProcessGo1.Models")]
    [System.SerializableAttribute()]
    public partial class NumberModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RandomNumber1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RandomNumber2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RandomNumber3Field;
        
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
        public int RandomNumber1 {
            get {
                return this.RandomNumber1Field;
            }
            set {
                if ((this.RandomNumber1Field.Equals(value) != true)) {
                    this.RandomNumber1Field = value;
                    this.RaisePropertyChanged("RandomNumber1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RandomNumber2 {
            get {
                return this.RandomNumber2Field;
            }
            set {
                if ((this.RandomNumber2Field.Equals(value) != true)) {
                    this.RandomNumber2Field = value;
                    this.RaisePropertyChanged("RandomNumber2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RandomNumber3 {
            get {
                return this.RandomNumber3Field;
            }
            set {
                if ((this.RandomNumber3Field.Equals(value) != true)) {
                    this.RandomNumber3Field = value;
                    this.RaisePropertyChanged("RandomNumber3");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRandomNumberGeneratorService")]
    public interface IRandomNumberGeneratorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomNumberGeneratorService/GetRandomNumbers", ReplyAction="http://tempuri.org/IRandomNumberGeneratorService/GetRandomNumbersResponse")]
        WebAppProcessGo1.ServiceReference1.NumberModel GetRandomNumbers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRandomNumberGeneratorService/GetRandomNumbers", ReplyAction="http://tempuri.org/IRandomNumberGeneratorService/GetRandomNumbersResponse")]
        System.Threading.Tasks.Task<WebAppProcessGo1.ServiceReference1.NumberModel> GetRandomNumbersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRandomNumberGeneratorServiceChannel : WebAppProcessGo1.ServiceReference1.IRandomNumberGeneratorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RandomNumberGeneratorServiceClient : System.ServiceModel.ClientBase<WebAppProcessGo1.ServiceReference1.IRandomNumberGeneratorService>, WebAppProcessGo1.ServiceReference1.IRandomNumberGeneratorService {
        
        public RandomNumberGeneratorServiceClient() {
        }
        
        public RandomNumberGeneratorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RandomNumberGeneratorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomNumberGeneratorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RandomNumberGeneratorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebAppProcessGo1.ServiceReference1.NumberModel GetRandomNumbers() {
            return base.Channel.GetRandomNumbers();
        }
        
        public System.Threading.Tasks.Task<WebAppProcessGo1.ServiceReference1.NumberModel> GetRandomNumbersAsync() {
            return base.Channel.GetRandomNumbersAsync();
        }
    }
}
