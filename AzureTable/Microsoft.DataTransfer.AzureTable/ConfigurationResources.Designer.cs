//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.AzureTable {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ConfigurationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigurationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.AzureTable.ConfigurationResources", typeof(ConfigurationResources).Assembly);
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
        ///   Looks up a localized string similar to Optional, default is 2MB. Specify the batch size in bytes.
        /// </summary>
        public static string BulkSink_MaxBatchSize {
            get {
                return ResourceManager.GetString("BulkSink_MaxBatchSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is 10MB. Approximate estimate of input bytes to buffer before flushing data to sink.
        /// </summary>
        public static string BulkSink_MaxInputBufferSize {
            get {
                return ResourceManager.GetString("BulkSink_MaxInputBufferSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is false. Specifies if existing values should be overwritten.
        /// </summary>
        public static string BulkSink_Overwrite {
            get {
                return ResourceManager.GetString("BulkSink_Overwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the name of the table to write to.
        /// </summary>
        public static string BulkSink_TableName {
            get {
                return ResourceManager.GetString("BulkSink_TableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, service defaults if not specified. Specifies throughput to configure for table.
        /// </summary>
        public static string BulkSink_Throughput {
            get {
                return ResourceManager.GetString("BulkSink_Throughput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string for the table endpoint.
        /// </summary>
        public static string ConnectionString {
            get {
                return ResourceManager.GetString("ConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Specifies which location mode to use when connecting to Azure Table storage: {1}.
        /// </summary>
        public static string LocationModeFormat {
            get {
                return ResourceManager.GetString("LocationModeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Filter string to apply.
        /// </summary>
        public static string Source_Filter {
            get {
                return ResourceManager.GetString("Source_Filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default {0}. Specifies which internal Azure Table fields should be preserve in the output: {1}.
        /// </summary>
        public static string Source_InternalFieldsFormat {
            get {
                return ResourceManager.GetString("Source_InternalFieldsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. List of columns to select.
        /// </summary>
        public static string Source_Projection {
            get {
                return ResourceManager.GetString("Source_Projection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name of the Azure Table.
        /// </summary>
        public static string Source_Table {
            get {
                return ResourceManager.GetString("Source_Table", resourceCulture);
            }
        }
    }
}
