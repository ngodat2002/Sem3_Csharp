﻿#pragma checksum "C:\Users\Admin\source\SEM3\Labs2\Labs2\Labs2\Contact.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "368F8D2533C61E9B6C8E813F71CDEFDA9E1310446F5CE847285474E69BC7E210"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Labs2.Labs2
{
    partial class Contact : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Labs2\Contact.xaml line 16
                {
                    this.ContactFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // Labs2\Contact.xaml line 27
                {
                    this.txtName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Labs2\Contact.xaml line 28
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Labs2\Contact.xaml line 29
                {
                    this.txtMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Labs2\Contact.xaml line 19
                {
                    this.inputFullname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Labs2\Contact.xaml line 20
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Labs2\Contact.xaml line 21
                {
                    this.inputMessage = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Labs2\Contact.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Submit;
                }
                break;
            case 10: // Labs2\Contact.xaml line 23
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Back;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
