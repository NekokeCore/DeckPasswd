﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeckPasswd {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DeckPasswd.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 参数为空！请输入-h 或者 帮助参数来获取帮助 的本地化字符串。
        /// </summary>
        internal static string argsifempty {
            get {
                return ResourceManager.GetString("argsifempty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 NekokeCore @2022 的本地化字符串。
        /// </summary>
        internal static string auther {
            get {
                return ResourceManager.GetString("auther", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  _____            _    _____               _____ _______ ______ 
        ///|  __ \          | |  |  __ \             / ____|__   __|  ____|
        ///| |  | | ___  ___| | _| |  | | ___  ___  | |       | |  | |__   
        ///| |  | |/ _ \/ __| |/ / |  | |/ _ \/ __| | |       | |  |  __|  
        ///| |__| |  __/ (__|   &lt;| |__| |  __/\__ \ | |____   | |  | |     
        ///|_____/ \___|\___|_|\_\_____/ \___||___/  \_____|  |_|  |_| 的本地化字符串。
        /// </summary>
        internal static string banner {
            get {
                return ResourceManager.GetString("banner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 欢迎使用DeckDesCTF加解密工具
        ///--v  或  调试        开启debug输出
        ///-h 或  帮助           获取帮助
        ///-e 或  加密           加密字符串
        ///-d 或  解密          解密符串 的本地化字符串。
        /// </summary>
        internal static string help {
            get {
                return ResourceManager.GetString("help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Version 1.0.0 的本地化字符串。
        /// </summary>
        internal static string info {
            get {
                return ResourceManager.GetString("info", resourceCulture);
            }
        }
    }
}
