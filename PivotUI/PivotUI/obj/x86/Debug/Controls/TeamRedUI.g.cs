﻿#pragma checksum "C:\Users\Labeeb Ali\Documents\GitHub\UI_Solution_Labeeb\PivotUI\PivotUI\Controls\TeamRedUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "392726A3BCD4727225E7837226B80CE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PivotUI.Controls
{
    partial class TeamRedUI : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 33: // Controls\TeamRedUI.xaml line 353
                {
                    this.First = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 34: // Controls\TeamRedUI.xaml line 359
                {
                    this.Ima = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 35: // Controls\TeamRedUI.xaml line 399
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.Button_Click;
                }
                break;
            case 36: // Controls\TeamRedUI.xaml line 418
                {
                    this.RedList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.RedList).SelectionChanged += this.RedList_SelectionChanged;
                }
                break;
            case 39: // Controls\TeamRedUI.xaml line 435
                {
                    global::Windows.UI.Xaml.Controls.Button element39 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element39).Click += this.Button_Click_1;
                }
                break;
            case 40: // Controls\TeamRedUI.xaml line 475
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element40 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element40).Click += this.MuteStatus_Click;
                }
                break;
            case 41: // Controls\TeamRedUI.xaml line 476
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element41 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element41).Click += this.ChainStatus_Click;
                }
                break;
            case 42: // Controls\TeamRedUI.xaml line 477
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element42 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element42).Click += this.HostStatus_Click;
                }
                break;
            case 45: // Controls\TeamRedUI.xaml line 406
                {
                    this.btSettings = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 46: // Controls\TeamRedUI.xaml line 403
                {
                    this.ChainSettings = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 47: // Controls\TeamRedUI.xaml line 404
                {
                    this.SettingsText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

