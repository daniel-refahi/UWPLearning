﻿#pragma checksum "C:\Users\DanielRefahi\Documents\GitHub\UWPLearning\LearningUWP\LearningUWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "112F88A47D5E0D15A05EA8E2153E6E33"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearningUWP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Click += this.DetailBt_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3:
                {
                    this.LiveTileToggleBt = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                }
                break;
            case 4:
                {
                    this.__ShowMenuAppBarB = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 52 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.__ShowMenuAppBarB).Click += this.uiPracticePageBt_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.aboutPageBt = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.aboutPageBt).Click += this.aboutPageBt_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.appBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 7:
                {
                    this.__MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.LoadingState = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 9:
                {
                    this.ScreenSize = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 10:
                {
                    this.Small = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 11:
                {
                    this.Normall = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 12:
                {
                    this.Loading = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 13:
                {
                    this.Loaded = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 14:
                {
                    this.Error = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 15:
                {
                    this.splitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 16:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 17:
                {
                    this.stackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 18:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.progressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 20:
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 21:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

