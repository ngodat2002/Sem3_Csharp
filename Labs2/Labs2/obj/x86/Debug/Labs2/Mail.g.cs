#pragma checksum "C:\Users\Admin\source\SEM3\Labs2\Labs2\Labs2\Mail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D91258162BC2A61AA5AE1E67BB9D155CC012B07577126DC5A8BA28CD35D9289"
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
    partial class Mail : 
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
            case 2: // Labs2\Mail.xaml line 16
                {
                    this.MailFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // Labs2\Mail.xaml line 27
                {
                    this.txtFullname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Labs2\Mail.xaml line 28
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Labs2\Mail.xaml line 29
                {
                    this.txtPhone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Labs2\Mail.xaml line 19
                {
                    this.inputFullname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Labs2\Mail.xaml line 20
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Labs2\Mail.xaml line 21
                {
                    this.inputPhone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Labs2\Mail.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Submit;
                }
                break;
            case 10: // Labs2\Mail.xaml line 23
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

