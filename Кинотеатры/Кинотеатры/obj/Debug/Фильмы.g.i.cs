﻿#pragma checksum "..\..\Фильмы.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00C7D2DBA9BE6331C72EBF14D270C3314C51997ABA60EA9D816666B6B7B000C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using Кинотератры;


namespace Кинотератры {
    
    
    /// <summary>
    /// Фильмы
    /// </summary>
    public partial class Фильмы : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FilmsData;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rejisor;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox genre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox time;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox year;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox made;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenreBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ActorBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Фильмы.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ActorList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Кинотеатры;component/%d0%a4%d0%b8%d0%bb%d1%8c%d0%bc%d1%8b.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Фильмы.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\Фильмы.xaml"
            ((Кинотератры.Фильмы)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilmsData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rejisor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.genre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.time = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.year = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.made = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.GenreBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\Фильмы.xaml"
            this.GenreBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GenreBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ActorBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\Фильмы.xaml"
            this.ActorBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ActorBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ActorList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            
            #line 28 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 29 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 32 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_7);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 33 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 34 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 35 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 38 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_3);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 39 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_4);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 40 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_5);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 41 "..\..\Фильмы.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_6);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

