﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace CrmConsoleClient.BPService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IBaselineProjectionService", Namespace="http://tempuri.org/")]
    public partial class BaselineProjectionService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllBaselineProjectionOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOneBaselineProjectionOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteBaselineProjectionOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateBaselineProjectionOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateBaselineProjectionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BaselineProjectionService() {
            this.Url = global::CrmConsoleClient.Properties.Settings.Default.CrmConsoleClient_BPService_BaselineProjectionService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAllBaselineProjectionCompletedEventHandler GetAllBaselineProjectionCompleted;
        
        /// <remarks/>
        public event GetOneBaselineProjectionCompletedEventHandler GetOneBaselineProjectionCompleted;
        
        /// <remarks/>
        public event DeleteBaselineProjectionCompletedEventHandler DeleteBaselineProjectionCompleted;
        
        /// <remarks/>
        public event CreateBaselineProjectionCompletedEventHandler CreateBaselineProjectionCompleted;
        
        /// <remarks/>
        public event UpdateBaselineProjectionCompletedEventHandler UpdateBaselineProjectionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IBaselineProjectionService/GetAllBaselineProjection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebAppWalkthrough")]
        public CustomBaselineProjection[] GetAllBaselineProjection() {
            object[] results = this.Invoke("GetAllBaselineProjection", new object[0]);
            return ((CustomBaselineProjection[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAllBaselineProjectionAsync() {
            this.GetAllBaselineProjectionAsync(null);
        }
        
        /// <remarks/>
        public void GetAllBaselineProjectionAsync(object userState) {
            if ((this.GetAllBaselineProjectionOperationCompleted == null)) {
                this.GetAllBaselineProjectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllBaselineProjectionOperationCompleted);
            }
            this.InvokeAsync("GetAllBaselineProjection", new object[0], this.GetAllBaselineProjectionOperationCompleted, userState);
        }
        
        private void OnGetAllBaselineProjectionOperationCompleted(object arg) {
            if ((this.GetAllBaselineProjectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllBaselineProjectionCompleted(this, new GetAllBaselineProjectionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IBaselineProjectionService/GetOneBaselineProjection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CustomBaselineProjection GetOneBaselineProjection(string id) {
            object[] results = this.Invoke("GetOneBaselineProjection", new object[] {
                        id});
            return ((CustomBaselineProjection)(results[0]));
        }
        
        /// <remarks/>
        public void GetOneBaselineProjectionAsync(string id) {
            this.GetOneBaselineProjectionAsync(id, null);
        }
        
        /// <remarks/>
        public void GetOneBaselineProjectionAsync(string id, object userState) {
            if ((this.GetOneBaselineProjectionOperationCompleted == null)) {
                this.GetOneBaselineProjectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOneBaselineProjectionOperationCompleted);
            }
            this.InvokeAsync("GetOneBaselineProjection", new object[] {
                        id}, this.GetOneBaselineProjectionOperationCompleted, userState);
        }
        
        private void OnGetOneBaselineProjectionOperationCompleted(object arg) {
            if ((this.GetOneBaselineProjectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOneBaselineProjectionCompleted(this, new GetOneBaselineProjectionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IBaselineProjectionService/DeleteBaselineProjection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteBaselineProjection(string id) {
            this.Invoke("DeleteBaselineProjection", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void DeleteBaselineProjectionAsync(string id) {
            this.DeleteBaselineProjectionAsync(id, null);
        }
        
        /// <remarks/>
        public void DeleteBaselineProjectionAsync(string id, object userState) {
            if ((this.DeleteBaselineProjectionOperationCompleted == null)) {
                this.DeleteBaselineProjectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteBaselineProjectionOperationCompleted);
            }
            this.InvokeAsync("DeleteBaselineProjection", new object[] {
                        id}, this.DeleteBaselineProjectionOperationCompleted, userState);
        }
        
        private void OnDeleteBaselineProjectionOperationCompleted(object arg) {
            if ((this.DeleteBaselineProjectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteBaselineProjectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IBaselineProjectionService/CreateBaselineProjection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateBaselineProjection([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CustomBaselineProjection bp) {
            this.Invoke("CreateBaselineProjection", new object[] {
                        bp});
        }
        
        /// <remarks/>
        public void CreateBaselineProjectionAsync(CustomBaselineProjection bp) {
            this.CreateBaselineProjectionAsync(bp, null);
        }
        
        /// <remarks/>
        public void CreateBaselineProjectionAsync(CustomBaselineProjection bp, object userState) {
            if ((this.CreateBaselineProjectionOperationCompleted == null)) {
                this.CreateBaselineProjectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateBaselineProjectionOperationCompleted);
            }
            this.InvokeAsync("CreateBaselineProjection", new object[] {
                        bp}, this.CreateBaselineProjectionOperationCompleted, userState);
        }
        
        private void OnCreateBaselineProjectionOperationCompleted(object arg) {
            if ((this.CreateBaselineProjectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateBaselineProjectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IBaselineProjectionService/UpdateBaselineProjection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateBaselineProjection([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CustomBaselineProjection bp) {
            this.Invoke("UpdateBaselineProjection", new object[] {
                        bp});
        }
        
        /// <remarks/>
        public void UpdateBaselineProjectionAsync(CustomBaselineProjection bp) {
            this.UpdateBaselineProjectionAsync(bp, null);
        }
        
        /// <remarks/>
        public void UpdateBaselineProjectionAsync(CustomBaselineProjection bp, object userState) {
            if ((this.UpdateBaselineProjectionOperationCompleted == null)) {
                this.UpdateBaselineProjectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateBaselineProjectionOperationCompleted);
            }
            this.InvokeAsync("UpdateBaselineProjection", new object[] {
                        bp}, this.UpdateBaselineProjectionOperationCompleted, userState);
        }
        
        private void OnUpdateBaselineProjectionOperationCompleted(object arg) {
            if ((this.UpdateBaselineProjectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateBaselineProjectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WebAppWalkthrough")]
    public partial class CustomBaselineProjection {
        
        private string idField;
        
        private string nameField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetAllBaselineProjectionCompletedEventHandler(object sender, GetAllBaselineProjectionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllBaselineProjectionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllBaselineProjectionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CustomBaselineProjection[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CustomBaselineProjection[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetOneBaselineProjectionCompletedEventHandler(object sender, GetOneBaselineProjectionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOneBaselineProjectionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOneBaselineProjectionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CustomBaselineProjection Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CustomBaselineProjection)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void DeleteBaselineProjectionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void CreateBaselineProjectionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void UpdateBaselineProjectionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591