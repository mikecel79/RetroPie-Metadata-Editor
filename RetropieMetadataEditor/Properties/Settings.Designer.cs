﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetropieMetadataEditor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\retropie\\roms\\{SYSTEM}")]
        public string PathRoms {
            get {
                return ((string)(this["PathRoms"]));
            }
            set {
                this["PathRoms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\retropie\\configs\\all\\emulationstation\\gamelists\\{SYSTEM}")]
        public string PathGamelists {
            get {
                return ((string)(this["PathGamelists"]));
            }
            set {
                this["PathGamelists"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\retropie\\configs\\all\\emulationstation\\downloaded_images\\{SYSTEM}")]
        public string PathImages {
            get {
                return ((string)(this["PathImages"]));
            }
            set {
                this["PathImages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%windir%\\system32\\mspaint.exe")]
        public string ImageEditingSoftware {
            get {
                return ((string)(this["ImageEditingSoftware"]));
            }
            set {
                this["ImageEditingSoftware"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-image")]
        public string ImageNameSuffix {
            get {
                return ((string)(this["ImageNameSuffix"]));
            }
            set {
                this["ImageNameSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/home/pi/.emulationstation/downloaded_images/{SYSTEM}")]
        public string PathImagesLocal {
            get {
                return ((string)(this["PathImagesLocal"]));
            }
            set {
                this["PathImagesLocal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files (x86)\\Jasc Software Inc\\Paint Shop Pro 9\\Paint Shop Pro 9.exe")]
        public string IES1 {
            get {
                return ((string)(this["IES1"]));
            }
            set {
                this["IES1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%windir%\\system32\\mspaint.exe")]
        public string IES2 {
            get {
                return ((string)(this["IES2"]));
            }
            set {
                this["IES2"] = value;
            }
        }
    }
}