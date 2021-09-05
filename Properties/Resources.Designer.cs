﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinMemoryCleaner.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinMemoryCleaner.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cleaned.
        /// </summary>
        public static string LogCleaned {
            get {
                return ResourceManager.GetString("LogCleaned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not save LOG: {0} (Exception: {1}).
        /// </summary>
        public static string LogHelperCanNotSaveLogException {
            get {
                return ResourceManager.GetString("LogHelperCanNotSaveLogException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started.
        /// </summary>
        public static string LogStarted {
            get {
                return ResourceManager.GetString("LogStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clean up memory.
        /// </summary>
        public static string MainViewCleanUpMemoryText {
            get {
                return ResourceManager.GetString("MainViewCleanUpMemoryText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation requires administrator privileges ({0}).
        /// </summary>
        public static string MemoryHelperAdminPrivilegeRequired {
            get {
                return ResourceManager.GetString("MemoryHelperAdminPrivilegeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Combined Page List.
        /// </summary>
        public static string MemoryHelperCombinedPageList {
            get {
                return ResourceManager.GetString("MemoryHelperCombinedPageList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} clean is not supported on this operating system version.
        /// </summary>
        public static string MemoryHelperFeatureIsNotSupported {
            get {
                return ResourceManager.GetString("MemoryHelperFeatureIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Standby List (Low Priority).
        /// </summary>
        public static string MemoryHelperLowPriorityStandbyList {
            get {
                return ResourceManager.GetString("MemoryHelperLowPriorityStandbyList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modified Page List.
        /// </summary>
        public static string MemoryHelperModifiedPageList {
            get {
                return ResourceManager.GetString("MemoryHelperModifiedPageList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processes Working Set.
        /// </summary>
        public static string MemoryHelperProcessesWorkingSet {
            get {
                return ResourceManager.GetString("MemoryHelperProcessesWorkingSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Standby List.
        /// </summary>
        public static string MemoryHelperStandbyList {
            get {
                return ResourceManager.GetString("MemoryHelperStandbyList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System Working Set.
        /// </summary>
        public static string MemoryHelperSystemWorkingSet {
            get {
                return ResourceManager.GetString("MemoryHelperSystemWorkingSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About.
        /// </summary>
        public static string SettingAbout {
            get {
                return ResourceManager.GetString("SettingAbout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log.
        /// </summary>
        public static string SettingLog {
            get {
                return ResourceManager.GetString("SettingLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Memory Areas.
        /// </summary>
        public static string SettingMemoryAreas {
            get {
                return ResourceManager.GetString("SettingMemoryAreas", resourceCulture);
            }
        }
    }
}
