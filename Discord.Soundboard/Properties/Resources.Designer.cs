﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Discord.Soundboard.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Discord.Soundboard.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to failed to load the soundboard database.
        /// </summary>
        internal static string MessageDatabaseLoadFailed {
            get {
                return ResourceManager.GetString("MessageDatabaseLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to saving soundboard database....
        /// </summary>
        internal static string MessageDatabaseSaving {
            get {
                return ResourceManager.GetString("MessageDatabaseSaving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry I couldn&apos;t download &lt;{0}&gt;.
        /// </summary>
        internal static string MessageDownloadFailed {
            get {
                return ResourceManager.GetString("MessageDownloadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry I do not recognize the command &lt;{0}&gt;.
        /// </summary>
        internal static string MessageInvalidCommand {
            get {
                return ResourceManager.GetString("MessageInvalidCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry that file has an invalid filename.
        /// </summary>
        internal static string MessageInvalidFilename {
            get {
                return ResourceManager.GetString("MessageInvalidFilename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry that file is too large.
        /// </summary>
        internal static string MessageInvalidFileSize {
            get {
                return ResourceManager.GetString("MessageInvalidFileSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to failed to play &lt;{0}&gt;.
        /// </summary>
        internal static string MessagePlayingFailed {
            get {
                return ResourceManager.GetString("MessagePlayingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to playing &lt;{0}&gt;.
        /// </summary>
        internal static string MessagePlayingSound {
            get {
                return ResourceManager.GetString("MessagePlayingSound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry that sound already exists.
        /// </summary>
        internal static string MessageSoundExists {
            get {
                return ResourceManager.GetString("MessageSoundExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;{0}&gt; is ready.
        /// </summary>
        internal static string MessageSoundReady {
            get {
                return ResourceManager.GetString("MessageSoundReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry the file extension &lt;0&gt; is not supported.
        /// </summary>
        internal static string MessageUnsupportedFileExtension {
            get {
                return ResourceManager.GetString("MessageUnsupportedFileExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sorry that format is not supported.
        /// </summary>
        internal static string MessageUnsupportedFormat {
            get {
                return ResourceManager.GetString("MessageUnsupportedFormat", resourceCulture);
            }
        }
    }
}
