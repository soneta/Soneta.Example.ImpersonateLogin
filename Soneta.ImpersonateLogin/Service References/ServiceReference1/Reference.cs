﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Soneta.ImpersonateLogin.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateTokenInfo", Namespace="http://schemas.datacontract.org/2004/07/Soneta.Net.Types")]
    [System.SerializableAttribute()]
    public partial class GenerateTokenInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Soneta.ImpersonateLogin.ServiceReference1.ConnectionInfo ConnectionInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DbNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
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
        public Soneta.ImpersonateLogin.ServiceReference1.ConnectionInfo ConnectionInfo {
            get {
                return this.ConnectionInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ConnectionInfoField, value) != true)) {
                    this.ConnectionInfoField = value;
                    this.RaisePropertyChanged("ConnectionInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DbName {
            get {
                return this.DbNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DbNameField, value) != true)) {
                    this.DbNameField = value;
                    this.RaisePropertyChanged("DbName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectionInfo", Namespace="http://schemas.datacontract.org/2004/07/Soneta.Net.Types")]
    [System.SerializableAttribute()]
    public partial class ConnectionInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatabaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerTypeField;
        
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
        public string Database {
            get {
                return this.DatabaseField;
            }
            set {
                if ((object.ReferenceEquals(this.DatabaseField, value) != true)) {
                    this.DatabaseField = value;
                    this.RaisePropertyChanged("Database");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operator {
            get {
                return this.OperatorField;
            }
            set {
                if ((object.ReferenceEquals(this.OperatorField, value) != true)) {
                    this.OperatorField = value;
                    this.RaisePropertyChanged("Operator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Server {
            get {
                return this.ServerField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerField, value) != true)) {
                    this.ServerField = value;
                    this.RaisePropertyChanged("Server");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerType {
            get {
                return this.ServerTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerTypeField, value) != true)) {
                    this.ServerTypeField = value;
                    this.RaisePropertyChanged("ServerType");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateTokenResult", Namespace="http://schemas.datacontract.org/2004/07/Soneta.Net.Types")]
    [System.SerializableAttribute()]
    public partial class GenerateTokenResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DbNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAuthenticatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
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
        public string DbName {
            get {
                return this.DbNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DbNameField, value) != true)) {
                    this.DbNameField = value;
                    this.RaisePropertyChanged("DbName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionMessage {
            get {
                return this.ExceptionMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMessageField, value) != true)) {
                    this.ExceptionMessageField = value;
                    this.RaisePropertyChanged("ExceptionMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAuthenticated {
            get {
                return this.IsAuthenticatedField;
            }
            set {
                if ((this.IsAuthenticatedField.Equals(value) != true)) {
                    this.IsAuthenticatedField = value;
                    this.RaisePropertyChanged("IsAuthenticated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITokenService")]
    public interface ITokenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITokenService/GenerateToken", ReplyAction="http://tempuri.org/ITokenService/GenerateTokenResponse")]
        Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenResult GenerateToken(Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenInfo tokenInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITokenService/GenerateToken", ReplyAction="http://tempuri.org/ITokenService/GenerateTokenResponse")]
        System.Threading.Tasks.Task<Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenResult> GenerateTokenAsync(Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenInfo tokenInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITokenServiceChannel : Soneta.ImpersonateLogin.ServiceReference1.ITokenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TokenServiceClient : System.ServiceModel.ClientBase<Soneta.ImpersonateLogin.ServiceReference1.ITokenService>, Soneta.ImpersonateLogin.ServiceReference1.ITokenService {
        
        public TokenServiceClient() {
        }
        
        public TokenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TokenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TokenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TokenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenResult GenerateToken(Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenInfo tokenInfo) {
            return base.Channel.GenerateToken(tokenInfo);
        }
        
        public System.Threading.Tasks.Task<Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenResult> GenerateTokenAsync(Soneta.ImpersonateLogin.ServiceReference1.GenerateTokenInfo tokenInfo) {
            return base.Channel.GenerateTokenAsync(tokenInfo);
        }
    }
}
