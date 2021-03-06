﻿#pragma checksum "C:\Users\ShiJiong\Documents\Visual Studio 2017\Projects\RPiCognitiveService\RPiCognitiveService\FacePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D33FABEA86A201B0315AA32E82F17A57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPiCognitiveService
{
    partial class FacePage : 
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
                    this.spMain = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.stpPreview = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.grdPicker = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.ringLoading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 5:
                {
                    this.txtLocation = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.gridEmotions = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.gridFaces = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.lstFiles = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 97 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstFiles).KeyUp += this.lstFiles_KeyUp;
                    #line 97 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstFiles).DoubleTapped += this.lstFiles_DoubleTapped;
                    #line default
                }
                break;
            case 9:
                {
                    this.lblBreadcrumb = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.btnSelect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 93 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSelect).Click += this.btnSelect_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 94 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.ImageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.PhotoCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 14:
                {
                    this.captureImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 15:
                {
                    this.PreviewTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.PreviewCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 17:
                {
                    this.previewElement = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 18:
                {
                    this.imgPhoto = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 44 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgPhoto).ImageOpened += this.imgPhoto_ImageOpened;
                    #line 45 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgPhoto).Tapped += this.cvasMain_Tapped;
                    #line default
                }
                break;
            case 19:
                {
                    this.cvasMain = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                    #line 52 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.cvasMain).SizeChanged += this.cvasMain_SizeChanged;
                    #line 53 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Canvas)this.cvasMain).Tapped += this.cvasMain_Tapped;
                    #line default
                }
                break;
            case 20:
                {
                    this.emotionData = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 21:
                {
                    this.txtFileName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 30 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtFileName).TextChanged += this.txtFileName_TextChanged;
                    #line default
                }
                break;
            case 22:
                {
                    this.btnOpen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOpen).Click += this.btnOpen_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.btnBrowse = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBrowse).Click += this.btnBrowse_Click;
                    #line default
                }
                break;
            case 24:
                {
                    this.btnClear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnClear).Click += this.btnClear_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.btnShow = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnShow).Click += this.btnShow_Click;
                    #line default
                }
                break;
            case 26:
                {
                    this.btnTakePhoto = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\FacePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnTakePhoto).Click += this.takePhoto_Click;
                    #line default
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

