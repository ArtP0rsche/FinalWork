﻿#pragma checksum "..\..\..\..\Pages\ClientPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "332D22DD110B1F4856AD613D8442B23696CE1536"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FragrantWorld.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FragrantWorld.Pages {
    
    
    /// <summary>
    /// ClientPage
    /// </summary>
    public partial class ClientPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userInfoTextBlock;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitSystemButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortProductsComboBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox discountRangeComboBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hintSearchTextBlock;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock countProductsTextBlock;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showOrderButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox productsListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FragrantWorld;component/pages/clientpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ClientPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.userInfoTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.exitSystemButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Pages\ClientPage.xaml"
            this.exitSystemButton.Click += new System.Windows.RoutedEventHandler(this.ExitSystemButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sortProductsComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\..\Pages\ClientPage.xaml"
            this.sortProductsComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortProductsComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.discountRangeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\..\Pages\ClientPage.xaml"
            this.discountRangeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DiscountRangeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Pages\ClientPage.xaml"
            this.searchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.hintSearchTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.countProductsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.showOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Pages\ClientPage.xaml"
            this.showOrderButton.Click += new System.Windows.RoutedEventHandler(this.ShowOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.productsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 42 "..\..\..\..\Pages\ClientPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AddOrderMenuItem_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

