﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationTier.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/DataService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        PresentationTier.ServiceReference1.CompositeType GetDataUsingDataContract(PresentationTier.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertarEstadoEnlace", ReplyAction="http://tempuri.org/IService1/insertarEstadoEnlaceResponse")]
        int insertarEstadoEnlace(int id_estado_enlace, double porcent_pings_perd, int tiempo_monitoreo, int fk_id_farm, string ip_farm, string nombre_farm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/obtenerEstados", ReplyAction="http://tempuri.org/IService1/obtenerEstadosResponse")]
        DataEntityTier.intermitenciaDataSet.Estado_EnlaceDataTable obtenerEstados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/modificarEstadoEnlace", ReplyAction="http://tempuri.org/IService1/modificarEstadoEnlaceResponse")]
        int modificarEstadoEnlace(int id_estado_enlace, double porcent_pings_perd, int tiempo_monitoreo, int fk_id_farm, string ip_farm, string nombre_farm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/eliminarEstadoEnlace", ReplyAction="http://tempuri.org/IService1/eliminarEstadoEnlaceResponse")]
        int eliminarEstadoEnlace();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertarFarmacia", ReplyAction="http://tempuri.org/IService1/insertarFarmaciaResponse")]
        int insertarFarmacia(int id_farmacia, string nombre_farmacia, string ip_farmacia, string rec_alerta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/obtenerFarmacias", ReplyAction="http://tempuri.org/IService1/obtenerFarmaciasResponse")]
        DataEntityTier.intermitenciaDataSet.Info_FarmaciaDataTable obtenerFarmacias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/modificarFarmacia", ReplyAction="http://tempuri.org/IService1/modificarFarmaciaResponse")]
        int modificarFarmacia(int codigoFarmacia, string nombreFarmacia, string ipFarmacia, string rec_alerta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : PresentationTier.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<PresentationTier.ServiceReference1.IService1>, PresentationTier.ServiceReference1.IService1 {
        
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
        
        public PresentationTier.ServiceReference1.CompositeType GetDataUsingDataContract(PresentationTier.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public int insertarEstadoEnlace(int id_estado_enlace, double porcent_pings_perd, int tiempo_monitoreo, int fk_id_farm, string ip_farm, string nombre_farm) {
            return base.Channel.insertarEstadoEnlace(id_estado_enlace, porcent_pings_perd, tiempo_monitoreo, fk_id_farm, ip_farm, nombre_farm);
        }
        
        public DataEntityTier.intermitenciaDataSet.Estado_EnlaceDataTable obtenerEstados() {
            return base.Channel.obtenerEstados();
        }
        
        public int modificarEstadoEnlace(int id_estado_enlace, double porcent_pings_perd, int tiempo_monitoreo, int fk_id_farm, string ip_farm, string nombre_farm) {
            return base.Channel.modificarEstadoEnlace(id_estado_enlace, porcent_pings_perd, tiempo_monitoreo, fk_id_farm, ip_farm, nombre_farm);
        }
        
        public int eliminarEstadoEnlace() {
            return base.Channel.eliminarEstadoEnlace();
        }
        
        public int insertarFarmacia(int id_farmacia, string nombre_farmacia, string ip_farmacia, string rec_alerta) {
            return base.Channel.insertarFarmacia(id_farmacia, nombre_farmacia, ip_farmacia, rec_alerta);
        }
        
        public DataEntityTier.intermitenciaDataSet.Info_FarmaciaDataTable obtenerFarmacias() {
            return base.Channel.obtenerFarmacias();
        }
        
        public int modificarFarmacia(int codigoFarmacia, string nombreFarmacia, string ipFarmacia, string rec_alerta) {
            return base.Channel.modificarFarmacia(codigoFarmacia, nombreFarmacia, ipFarmacia, rec_alerta);
        }
    }
}
