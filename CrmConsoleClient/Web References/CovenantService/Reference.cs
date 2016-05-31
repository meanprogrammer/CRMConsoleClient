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

namespace CrmConsoleClient.CovenantService {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICovenantService", Namespace="http://tempuri.org/")]
    public partial class CovenantService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllSOVCovenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOneSOVCovenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateSOVCovenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllNSOCovenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOneNSOCovenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateNSOCovenantOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CovenantService() {
            this.Url = global::CrmConsoleClient.Properties.Settings.Default.CrmConsoleClient_CovenantService_CovenantService;
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
        public event GetAllSOVCovenantCompletedEventHandler GetAllSOVCovenantCompleted;
        
        /// <remarks/>
        public event GetOneSOVCovenantCompletedEventHandler GetOneSOVCovenantCompleted;
        
        /// <remarks/>
        public event UpdateSOVCovenantCompletedEventHandler UpdateSOVCovenantCompleted;
        
        /// <remarks/>
        public event GetAllNSOCovenantCompletedEventHandler GetAllNSOCovenantCompleted;
        
        /// <remarks/>
        public event GetOneNSOCovenantCompletedEventHandler GetOneNSOCovenantCompleted;
        
        /// <remarks/>
        public event UpdateNSOCovenantCompletedEventHandler UpdateNSOCovenantCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICovenantService/GetAllSOVCovenant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/CRMProxyService.Entity")]
        public ProxySOVCovenant[] GetAllSOVCovenant() {
            object[] results = this.Invoke("GetAllSOVCovenant", new object[0]);
            return ((ProxySOVCovenant[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAllSOVCovenantAsync() {
            this.GetAllSOVCovenantAsync(null);
        }
        
        /// <remarks/>
        public void GetAllSOVCovenantAsync(object userState) {
            if ((this.GetAllSOVCovenantOperationCompleted == null)) {
                this.GetAllSOVCovenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllSOVCovenantOperationCompleted);
            }
            this.InvokeAsync("GetAllSOVCovenant", new object[0], this.GetAllSOVCovenantOperationCompleted, userState);
        }
        
        private void OnGetAllSOVCovenantOperationCompleted(object arg) {
            if ((this.GetAllSOVCovenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllSOVCovenantCompleted(this, new GetAllSOVCovenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICovenantService/GetOneSOVCovenant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ProxySOVCovenant GetOneSOVCovenant(string id) {
            object[] results = this.Invoke("GetOneSOVCovenant", new object[] {
                        id});
            return ((ProxySOVCovenant)(results[0]));
        }
        
        /// <remarks/>
        public void GetOneSOVCovenantAsync(string id) {
            this.GetOneSOVCovenantAsync(id, null);
        }
        
        /// <remarks/>
        public void GetOneSOVCovenantAsync(string id, object userState) {
            if ((this.GetOneSOVCovenantOperationCompleted == null)) {
                this.GetOneSOVCovenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOneSOVCovenantOperationCompleted);
            }
            this.InvokeAsync("GetOneSOVCovenant", new object[] {
                        id}, this.GetOneSOVCovenantOperationCompleted, userState);
        }
        
        private void OnGetOneSOVCovenantOperationCompleted(object arg) {
            if ((this.GetOneSOVCovenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOneSOVCovenantCompleted(this, new GetOneSOVCovenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICovenantService/UpdateSOVCovenant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateSOVCovenant([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ProxySOVCovenant covenant) {
            this.Invoke("UpdateSOVCovenant", new object[] {
                        covenant});
        }
        
        /// <remarks/>
        public void UpdateSOVCovenantAsync(ProxySOVCovenant covenant) {
            this.UpdateSOVCovenantAsync(covenant, null);
        }
        
        /// <remarks/>
        public void UpdateSOVCovenantAsync(ProxySOVCovenant covenant, object userState) {
            if ((this.UpdateSOVCovenantOperationCompleted == null)) {
                this.UpdateSOVCovenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateSOVCovenantOperationCompleted);
            }
            this.InvokeAsync("UpdateSOVCovenant", new object[] {
                        covenant}, this.UpdateSOVCovenantOperationCompleted, userState);
        }
        
        private void OnUpdateSOVCovenantOperationCompleted(object arg) {
            if ((this.UpdateSOVCovenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateSOVCovenantCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICovenantService/GetAllNSOCovenant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/CRMProxyService.Entity")]
        public ProxyNSOCovenant[] GetAllNSOCovenant() {
            object[] results = this.Invoke("GetAllNSOCovenant", new object[0]);
            return ((ProxyNSOCovenant[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAllNSOCovenantAsync() {
            this.GetAllNSOCovenantAsync(null);
        }
        
        /// <remarks/>
        public void GetAllNSOCovenantAsync(object userState) {
            if ((this.GetAllNSOCovenantOperationCompleted == null)) {
                this.GetAllNSOCovenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllNSOCovenantOperationCompleted);
            }
            this.InvokeAsync("GetAllNSOCovenant", new object[0], this.GetAllNSOCovenantOperationCompleted, userState);
        }
        
        private void OnGetAllNSOCovenantOperationCompleted(object arg) {
            if ((this.GetAllNSOCovenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllNSOCovenantCompleted(this, new GetAllNSOCovenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICovenantService/GetOneNSOCovenant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ProxyNSOCovenant GetOneNSOCovenant(string id) {
            object[] results = this.Invoke("GetOneNSOCovenant", new object[] {
                        id});
            return ((ProxyNSOCovenant)(results[0]));
        }
        
        /// <remarks/>
        public void GetOneNSOCovenantAsync(string id) {
            this.GetOneNSOCovenantAsync(id, null);
        }
        
        /// <remarks/>
        public void GetOneNSOCovenantAsync(string id, object userState) {
            if ((this.GetOneNSOCovenantOperationCompleted == null)) {
                this.GetOneNSOCovenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOneNSOCovenantOperationCompleted);
            }
            this.InvokeAsync("GetOneNSOCovenant", new object[] {
                        id}, this.GetOneNSOCovenantOperationCompleted, userState);
        }
        
        private void OnGetOneNSOCovenantOperationCompleted(object arg) {
            if ((this.GetOneNSOCovenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOneNSOCovenantCompleted(this, new GetOneNSOCovenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICovenantService/UpdateNSOCovenant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateNSOCovenant([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ProxyNSOCovenant covenant) {
            this.Invoke("UpdateNSOCovenant", new object[] {
                        covenant});
        }
        
        /// <remarks/>
        public void UpdateNSOCovenantAsync(ProxyNSOCovenant covenant) {
            this.UpdateNSOCovenantAsync(covenant, null);
        }
        
        /// <remarks/>
        public void UpdateNSOCovenantAsync(ProxyNSOCovenant covenant, object userState) {
            if ((this.UpdateNSOCovenantOperationCompleted == null)) {
                this.UpdateNSOCovenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateNSOCovenantOperationCompleted);
            }
            this.InvokeAsync("UpdateNSOCovenant", new object[] {
                        covenant}, this.UpdateNSOCovenantOperationCompleted, userState);
        }
        
        private void OnUpdateNSOCovenantOperationCompleted(object arg) {
            if ((this.UpdateNSOCovenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateNSOCovenantCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/CRMProxyService.Entity")]
    public partial class ProxySOVCovenant {
        
        private System.Nullable<double> agreementSectionNoField;
        
        private bool agreementSectionNoFieldSpecified;
        
        private System.Nullable<System.DateTime> compliedDateField;
        
        private bool compliedDateFieldSpecified;
        
        private string covenantDescriptionField;
        
        private string covenantIDField;
        
        private string covenantTypeField;
        
        private System.Nullable<System.DateTime> dueDateField;
        
        private bool dueDateFieldSpecified;
        
        private System.Nullable<System.DateTime> effectiveEndDateField;
        
        private bool effectiveEndDateFieldSpecified;
        
        private System.Nullable<System.DateTime> effectiveStartDateField;
        
        private bool effectiveStartDateFieldSpecified;
        
        private string idField;
        
        private string nameField;
        
        private System.Nullable<int> paragraphNoField;
        
        private bool paragraphNoFieldSpecified;
        
        private string parentIDField;
        
        private string parentIDStringField;
        
        private string ratingField;
        
        private System.Nullable<int> remarksField;
        
        private bool remarksFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> AgreementSectionNo {
            get {
                return this.agreementSectionNoField;
            }
            set {
                this.agreementSectionNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgreementSectionNoSpecified {
            get {
                return this.agreementSectionNoFieldSpecified;
            }
            set {
                this.agreementSectionNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> CompliedDate {
            get {
                return this.compliedDateField;
            }
            set {
                this.compliedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompliedDateSpecified {
            get {
                return this.compliedDateFieldSpecified;
            }
            set {
                this.compliedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CovenantDescription {
            get {
                return this.covenantDescriptionField;
            }
            set {
                this.covenantDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string CovenantID {
            get {
                return this.covenantIDField;
            }
            set {
                this.covenantIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CovenantType {
            get {
                return this.covenantTypeField;
            }
            set {
                this.covenantTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> EffectiveEndDate {
            get {
                return this.effectiveEndDateField;
            }
            set {
                this.effectiveEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveEndDateSpecified {
            get {
                return this.effectiveEndDateFieldSpecified;
            }
            set {
                this.effectiveEndDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> EffectiveStartDate {
            get {
                return this.effectiveStartDateField;
            }
            set {
                this.effectiveStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveStartDateSpecified {
            get {
                return this.effectiveStartDateFieldSpecified;
            }
            set {
                this.effectiveStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ID {
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> ParagraphNo {
            get {
                return this.paragraphNoField;
            }
            set {
                this.paragraphNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParagraphNoSpecified {
            get {
                return this.paragraphNoFieldSpecified;
            }
            set {
                this.paragraphNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ParentID {
            get {
                return this.parentIDField;
            }
            set {
                this.parentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ParentIDString {
            get {
                return this.parentIDStringField;
            }
            set {
                this.parentIDStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Rating {
            get {
                return this.ratingField;
            }
            set {
                this.ratingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> Remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemarksSpecified {
            get {
                return this.remarksFieldSpecified;
            }
            set {
                this.remarksFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/CRMProxyService.Entity")]
    public partial class ProxyNSOCovenant {
        
        private string compliedWithField;
        
        private System.Nullable<int> compliedWithIDField;
        
        private bool compliedWithIDFieldSpecified;
        
        private string covenantDescriptionField;
        
        private string covenantIDField;
        
        private string covenantTypeField;
        
        private System.Nullable<System.DateTime> dueDateField;
        
        private bool dueDateFieldSpecified;
        
        private string frequencyOfReviewField;
        
        private string idField;
        
        private string nameField;
        
        private string parentIDField;
        
        private string parentIDStringField;
        
        private string referenceField;
        
        private string remarksIssuesField;
        
        private string statusField;
        
        private System.Nullable<int> statusIDField;
        
        private bool statusIDFieldSpecified;
        
        private System.Nullable<System.DateTime> submissionDateField;
        
        private bool submissionDateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CompliedWith {
            get {
                return this.compliedWithField;
            }
            set {
                this.compliedWithField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> CompliedWithID {
            get {
                return this.compliedWithIDField;
            }
            set {
                this.compliedWithIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompliedWithIDSpecified {
            get {
                return this.compliedWithIDFieldSpecified;
            }
            set {
                this.compliedWithIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CovenantDescription {
            get {
                return this.covenantDescriptionField;
            }
            set {
                this.covenantDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string CovenantID {
            get {
                return this.covenantIDField;
            }
            set {
                this.covenantIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CovenantType {
            get {
                return this.covenantTypeField;
            }
            set {
                this.covenantTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DueDateSpecified {
            get {
                return this.dueDateFieldSpecified;
            }
            set {
                this.dueDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FrequencyOfReview {
            get {
                return this.frequencyOfReviewField;
            }
            set {
                this.frequencyOfReviewField = value;
            }
        }
        
        /// <remarks/>
        public string ID {
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
        
        /// <remarks/>
        public string ParentID {
            get {
                return this.parentIDField;
            }
            set {
                this.parentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ParentIDString {
            get {
                return this.parentIDStringField;
            }
            set {
                this.parentIDStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string RemarksIssues {
            get {
                return this.remarksIssuesField;
            }
            set {
                this.remarksIssuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> StatusID {
            get {
                return this.statusIDField;
            }
            set {
                this.statusIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusIDSpecified {
            get {
                return this.statusIDFieldSpecified;
            }
            set {
                this.statusIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> SubmissionDate {
            get {
                return this.submissionDateField;
            }
            set {
                this.submissionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubmissionDateSpecified {
            get {
                return this.submissionDateFieldSpecified;
            }
            set {
                this.submissionDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetAllSOVCovenantCompletedEventHandler(object sender, GetAllSOVCovenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllSOVCovenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllSOVCovenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProxySOVCovenant[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProxySOVCovenant[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetOneSOVCovenantCompletedEventHandler(object sender, GetOneSOVCovenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOneSOVCovenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOneSOVCovenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProxySOVCovenant Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProxySOVCovenant)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void UpdateSOVCovenantCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetAllNSOCovenantCompletedEventHandler(object sender, GetAllNSOCovenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllNSOCovenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllNSOCovenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProxyNSOCovenant[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProxyNSOCovenant[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetOneNSOCovenantCompletedEventHandler(object sender, GetOneNSOCovenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOneNSOCovenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOneNSOCovenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProxyNSOCovenant Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProxyNSOCovenant)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void UpdateNSOCovenantCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591