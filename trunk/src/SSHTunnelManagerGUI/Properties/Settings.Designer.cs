﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSHTunnelManagerGUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StartSingleInstanceOnly {
            get {
                return ((bool)(this["StartSingleInstanceOnly"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EncryptedStorageFile {
            get {
                return ((string)(this["EncryptedStorageFile"]));
            }
            set {
                this["EncryptedStorageFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EncryptedStoragePassword {
            get {
                return ((string)(this["EncryptedStoragePassword"]));
            }
            set {
                this["EncryptedStoragePassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Config_RestartEnabled {
            get {
                return ((bool)(this["Config_RestartEnabled"]));
            }
            set {
                this["Config_RestartEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int Config_MaxAttemptsCount {
            get {
                return ((int)(this["Config_MaxAttemptsCount"]));
            }
            set {
                this["Config_MaxAttemptsCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int Config_RestartDelay {
            get {
                return ((int)(this["Config_RestartDelay"]));
            }
            set {
                this["Config_RestartDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Config_TraceDebug {
            get {
                return ((bool)(this["Config_TraceDebug"]));
            }
            set {
                this["Config_TraceDebug"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Config_AfterMaxAttemptsMakeDelay {
            get {
                return ((bool)(this["Config_AfterMaxAttemptsMakeDelay"]));
            }
            set {
                this["Config_AfterMaxAttemptsMakeDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Config_RestartHostsWithWarnings {
            get {
                return ((bool)(this["Config_RestartHostsWithWarnings"]));
            }
            set {
                this["Config_RestartHostsWithWarnings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public int Config_RestartHostsWithWarningsInterval {
            get {
                return ((int)(this["Config_RestartHostsWithWarningsInterval"]));
            }
            set {
                this["Config_RestartHostsWithWarningsInterval"] = value;
            }
        }
    }
}