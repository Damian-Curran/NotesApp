﻿#pragma checksum "C:\Users\Damian Curran\Documents\Visual Studio 2015\Projects\Notes\Notes\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0AAE65794B84DD9577E0ED2582CD3E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notes
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class MainPage_obj7_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::ViewModels.NoteViewModel dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj7;

            private MainPage_obj7_BindingsTracking bindingsTracking;

            public MainPage_obj7_Bindings()
            {
                this.bindingsTracking = new MainPage_obj7_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::ViewModels.NoteViewModel data = args.NewValue as global::ViewModels.NoteViewModel;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::ViewModels.NoteViewModel was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::ViewModels.NoteViewModel);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.TextBlock)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ViewModels.NoteViewModel) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj7_Bindings

            public void SetDataRoot(global::ViewModels.NoteViewModel newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ViewModels.NoteViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteName(obj.NoteName, phase);
                    }
                }
            }
            private void Update_NoteName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7.Target as global::Windows.UI.Xaml.Controls.TextBlock, obj, null);
                }
            }

            private class MainPage_obj7_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj7_Bindings> WeakRefToBindingObj; 

                public MainPage_obj7_BindingsTracking(MainPage_obj7_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj7_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj7_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::ViewModels.NoteViewModel obj = sender as global::ViewModels.NoteViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_NoteName(obj.NoteName, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "NoteName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteName(obj.NoteName, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::ViewModels.NoteViewModel obj)
                {
                    MainPage_obj7_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Notes.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj3;
            private global::Windows.UI.Xaml.Controls.Button obj4;
            private global::Windows.UI.Xaml.Controls.ListView obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj2).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.NoteHandler.SelectedNote.NoteName = (this.obj2).Text;
                                }
                            };
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj3).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.NoteHandler.SelectedNote.NoteDes = (this.obj3).Text;
                                }
                            };
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.NoteHandler.Delete();
                        };
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        (this.obj5).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.NoteHandler.SelectedIndex = (this.obj5).SelectedIndex;
                                }
                            });
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.NoteHandler.Add();
                        };
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::Notes.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Notes.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteHandler(obj.NoteHandler, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler(phase);
                    }
                }
            }
            private void Update_NoteHandler(global::ViewModels.NoteHandlerViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_NoteHandler(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteHandler_SelectedNote(obj.SelectedNote, phase);
                        this.Update_NoteHandler_Notes(obj.Notes, phase);
                        this.Update_NoteHandler_SelectedIndex(obj.SelectedIndex, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler_SelectedNote(phase);
                    }
                }
            }
            private void Update_NoteHandler_SelectedNote(global::ViewModels.NoteViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_NoteHandler_SelectedNote(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteHandler_SelectedNote_NoteName(obj.NoteName, phase);
                        this.Update_NoteHandler_SelectedNote_NoteDes(obj.NoteDes, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler_SelectedNote_NoteName(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler_SelectedNote_NoteDes(phase);
                    }
                }
            }
            private void Update_NoteHandler_SelectedNote_NoteName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, obj, null);
                }
            }
            private void Update_NoteHandler_SelectedNote_NoteDes(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }
            private void Update_NoteHandler_Notes(global::System.Collections.ObjectModel.ObservableCollection<global::ViewModels.NoteViewModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                }
            }
            private void Update_NoteHandler_SelectedIndex(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj5, obj);
                }
            }

            private void UpdateFallback_NoteHandler(int phase)
            {
                this.UpdateFallback_NoteHandler_SelectedNote(phase);
            }

            private void UpdateFallback_NoteHandler_SelectedNote(int phase)
            {
                this.UpdateFallback_NoteHandler_SelectedNote_NoteName(phase);
                this.UpdateFallback_NoteHandler_SelectedNote_NoteDes(phase);
            }

            private void UpdateFallback_NoteHandler_SelectedNote_NoteName(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, "", null);
                }
            }

            private void UpdateFallback_NoteHandler_SelectedNote_NoteDes(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, "", null);
                }
            }

            private class MainPage_obj1_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj1_Bindings> WeakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_NoteHandler(null);
                    UpdateChildListeners_NoteHandler_SelectedNote(null);
                }

                public void PropertyChanged_NoteHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::ViewModels.NoteHandlerViewModel obj = sender as global::ViewModels.NoteHandlerViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_NoteHandler_SelectedNote(obj.SelectedNote, DATA_CHANGED);
                                    bindings.Update_NoteHandler_Notes(obj.Notes, DATA_CHANGED);
                                    bindings.Update_NoteHandler_SelectedIndex(obj.SelectedIndex, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_NoteHandler_SelectedNote(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SelectedNote":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedNote(obj.SelectedNote, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_NoteHandler_SelectedNote(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Notes":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_Notes(obj.Notes, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedIndex(obj.SelectedIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::ViewModels.NoteHandlerViewModel cache_NoteHandler = null;
                public void UpdateChildListeners_NoteHandler(global::ViewModels.NoteHandlerViewModel obj)
                {
                    if (obj != cache_NoteHandler)
                    {
                        if (cache_NoteHandler != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_NoteHandler).PropertyChanged -= PropertyChanged_NoteHandler;
                            cache_NoteHandler = null;
                        }
                        if (obj != null)
                        {
                            cache_NoteHandler = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_NoteHandler;
                        }
                    }
                }
                public void PropertyChanged_NoteHandler_SelectedNote(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::ViewModels.NoteViewModel obj = sender as global::ViewModels.NoteViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_NoteHandler_SelectedNote_NoteName(obj.NoteName, DATA_CHANGED);
                                    bindings.Update_NoteHandler_SelectedNote_NoteDes(obj.NoteDes, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_NoteHandler_SelectedNote_NoteName(DATA_CHANGED);
                                bindings.UpdateFallback_NoteHandler_SelectedNote_NoteDes(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "NoteName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedNote_NoteName(obj.NoteName, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_NoteHandler_SelectedNote_NoteName(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "NoteDes":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedNote_NoteDes(obj.NoteDes, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_NoteHandler_SelectedNote_NoteDes(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::ViewModels.NoteViewModel cache_NoteHandler_SelectedNote = null;
                public void UpdateChildListeners_NoteHandler_SelectedNote(global::ViewModels.NoteViewModel obj)
                {
                    if (obj != cache_NoteHandler_SelectedNote)
                    {
                        if (cache_NoteHandler_SelectedNote != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_NoteHandler_SelectedNote).PropertyChanged -= PropertyChanged_NoteHandler_SelectedNote;
                            cache_NoteHandler_SelectedNote = null;
                        }
                        if (obj != null)
                        {
                            cache_NoteHandler_SelectedNote = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_NoteHandler_SelectedNote;
                        }
                    }
                }
                public void PropertyChanged_NoteHandler_Notes(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::ViewModels.NoteViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::ViewModels.NoteViewModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_NoteHandler_Notes(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::ViewModels.NoteViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::ViewModels.NoteViewModel>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.MainList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    MainPage_obj7_Bindings bindings = new MainPage_obj7_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::ViewModels.NoteViewModel) element7.DataContext);
                    element7.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element7, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

