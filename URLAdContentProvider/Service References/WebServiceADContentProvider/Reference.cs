﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace URLAdContentProvider.WebServiceADContentProvider {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceADContentProvider.WebServiceADContentProviderSoap")]
    public interface WebServiceADContentProviderSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMultimediaObjectBytes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int GetMultimediaObjectBytes(string sessionId, int id, string Data0, string Data1, string Data2, string Data3, System.DateTime date, int requestType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMultimediaObjectBytes", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetMultimediaObjectBytesAsync(string sessionId, int id, string Data0, string Data1, string Data2, string Data3, System.DateTime date, int requestType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMultimediaObject", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetMultimediaObject(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMultimediaObject", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetMultimediaObjectAsync(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultimediaObjectUrlClicked", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MultimediaObjectUrlClicked(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request, int id, int statusCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultimediaObjectUrlClicked", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MultimediaObjectUrlClickedAsync(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request, int id, int statusCode);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMultimediaObject_Request : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string data0Field;
        
        private string data1Field;
        
        private string data2Field;
        
        private string data3Field;
        
        private string sessionIdField;
        
        private int requestSourceField;
        
        private System.DateTime requestDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Data0 {
            get {
                return this.data0Field;
            }
            set {
                this.data0Field = value;
                this.RaisePropertyChanged("Data0");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Data1 {
            get {
                return this.data1Field;
            }
            set {
                this.data1Field = value;
                this.RaisePropertyChanged("Data1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Data2 {
            get {
                return this.data2Field;
            }
            set {
                this.data2Field = value;
                this.RaisePropertyChanged("Data2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Data3 {
            get {
                return this.data3Field;
            }
            set {
                this.data3Field = value;
                this.RaisePropertyChanged("Data3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string SessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
                this.RaisePropertyChanged("SessionId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int RequestSource {
            get {
                return this.requestSourceField;
            }
            set {
                this.requestSourceField = value;
                this.RaisePropertyChanged("RequestSource");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public System.DateTime RequestDate {
            get {
                return this.requestDateField;
            }
            set {
                this.requestDateField = value;
                this.RaisePropertyChanged("RequestDate");
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
    public interface WebServiceADContentProviderSoapChannel : URLAdContentProvider.WebServiceADContentProvider.WebServiceADContentProviderSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceADContentProviderSoapClient : System.ServiceModel.ClientBase<URLAdContentProvider.WebServiceADContentProvider.WebServiceADContentProviderSoap>, URLAdContentProvider.WebServiceADContentProvider.WebServiceADContentProviderSoap {
        
        public WebServiceADContentProviderSoapClient() {
        }
        
        public WebServiceADContentProviderSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceADContentProviderSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceADContentProviderSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceADContentProviderSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetMultimediaObjectBytes(string sessionId, int id, string Data0, string Data1, string Data2, string Data3, System.DateTime date, int requestType) {
            return base.Channel.GetMultimediaObjectBytes(sessionId, id, Data0, Data1, Data2, Data3, date, requestType);
        }
        
        public System.Threading.Tasks.Task<int> GetMultimediaObjectBytesAsync(string sessionId, int id, string Data0, string Data1, string Data2, string Data3, System.DateTime date, int requestType) {
            return base.Channel.GetMultimediaObjectBytesAsync(sessionId, id, Data0, Data1, Data2, Data3, date, requestType);
        }
        
        public string GetMultimediaObject(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request) {
            return base.Channel.GetMultimediaObject(request);
        }
        
        public System.Threading.Tasks.Task<string> GetMultimediaObjectAsync(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request) {
            return base.Channel.GetMultimediaObjectAsync(request);
        }
        
        public string MultimediaObjectUrlClicked(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request, int id, int statusCode) {
            return base.Channel.MultimediaObjectUrlClicked(request, id, statusCode);
        }
        
        public System.Threading.Tasks.Task<string> MultimediaObjectUrlClickedAsync(URLAdContentProvider.WebServiceADContentProvider.GetMultimediaObject_Request request, int id, int statusCode) {
            return base.Channel.MultimediaObjectUrlClickedAsync(request, id, statusCode);
        }
    }
}
