﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3521
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsComponents {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NewsComponents.SR", typeof(SR).Assembly);
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
        ///   Looks up a localized string similar to An error has occured downloading the enclosure:
        ///
        ///{0}.
        /// </summary>
        internal static string ExceptionDownloadingEnclosure {
            get {
                return ResourceManager.GetString("ExceptionDownloadingEnclosure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Facebook subscriptions file has been tampered with and cannot be loaded. Delete Facebook as a feed source and add it again from &quot;Synchronize Feeds&quot; to fix this problem..
        /// </summary>
        internal static string ExceptionFacebookFeedlistCorrupted {
            get {
                return ResourceManager.GetString("ExceptionFacebookFeedlistCorrupted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to News Feed.
        /// </summary>
        internal static string FacebookNewsFeedTitle {
            get {
                return ResourceManager.GetString("FacebookNewsFeedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to facebook.
        /// </summary>
        internal static string FacebookStyleSheet {
            get {
                return ResourceManager.GetString("FacebookStyleSheet", resourceCulture);
            }
        }
    }
}