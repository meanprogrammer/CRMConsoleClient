﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmConsoleClient.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://adbcrm.apphb.com/BaselineProjectionService.svc")]
        public string CrmConsoleClient_BPService_BaselineProjectionService {
            get {
                return ((string)(this["CrmConsoleClient_BPService_BaselineProjectionService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://dynamicscrmproxy.apphb.com/Services/AccountService.svc")]
        public string CrmConsoleClient_AccountService_AccountService {
            get {
                return ((string)(this["CrmConsoleClient_AccountService_AccountService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:57324/Services/OpportunityService.svc")]
        public string CrmConsoleClient_LocalOpportunityService_OpportunityService {
            get {
                return ((string)(this["CrmConsoleClient_LocalOpportunityService_OpportunityService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://dynamicscrmproxy.apphb.com/Services/OpportunityService.svc")]
        public string CrmConsoleClient_OpportunityService_OpportunityService {
            get {
                return ((string)(this["CrmConsoleClient_OpportunityService_OpportunityService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://dynamicscrmproxy.apphb.com/Services/ConnectionService.svc")]
        public string CrmConsoleClient_ProjectTeamService_ConnectionService {
            get {
                return ((string)(this["CrmConsoleClient_ProjectTeamService_ConnectionService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://dynamicscrmproxy.apphb.com/Services/DMFService.svc")]
        public string CrmConsoleClient_DMFService_DMFService {
            get {
                return ((string)(this["CrmConsoleClient_DMFService_DMFService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://dynamicscrmproxy.apphb.com/Services/CovenantService.svc")]
        public string CrmConsoleClient_CovenantService_CovenantService {
            get {
                return ((string)(this["CrmConsoleClient_CovenantService_CovenantService"]));
            }
        }
    }
}
