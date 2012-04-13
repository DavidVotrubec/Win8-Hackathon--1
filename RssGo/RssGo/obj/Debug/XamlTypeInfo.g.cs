﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml;
using RssGo.XamlTypeInfo;

namespace RssGo
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]
    public partial class App : IXamlMetadataProvider
    {
        private XamlTypeInfoProvider _provider;

        public IXamlType GetXamlType(Type type)
        {
            if(_provider == null)
            {
                _provider = new XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public IXamlType GetXamlType(String typeName)
        {
            if(_provider == null)
            {
                _provider = new XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(typeName);
        }

        public XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new XmlnsDefinition[0];
        }
    }
}

namespace RssGo.XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public IXamlType GetXamlTypeByType(Type type)
        {
            string standardName;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                return GetXamlTypeByName(standardName);
            }
            return GetXamlTypeByName(type.FullName);
        }

        public IXamlType GetXamlTypeByName(string typeName)
        {
            if (String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        Dictionary<string, IXamlType> _xamlTypes = new Dictionary<string, IXamlType>();
        Dictionary<string, IXamlMember> _xamlMembers = new Dictionary<string, IXamlMember>();
        Dictionary<Type, string> _xamlTypeToStandardName = new Dictionary<Type, string>();

        private void AddToMapOfTypeToStandardName(Type t, String str)
        {
            String test;
            if(!_xamlTypeToStandardName.TryGetValue(t, out test))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_FeedDataSource() { return new RssGo.FeedDataSource(); }

        private object Activate_1_ObservableCollection() { return new System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>(); }

        private object Activate_2_Collection() { return new System.Collections.ObjectModel.Collection<RssGo.FeedData>(); }

        private object Activate_3_FeedData() { return new RssGo.FeedData(); }

        private object Activate_6_List() { return new System.Collections.Generic.List<RssGo.FeedItem>(); }

        private object Activate_7_FeedItem() { return new RssGo.FeedItem(); }

        private object Activate_9_DateConverter() { return new RssGo.DateConverter(); }

        private object Activate_10_LayoutAwarePage() { return new RssGo.Common.LayoutAwarePage(); }

        private object Activate_11_BlankPage() { return new RssGo.BlankPage(); }

        private object Activate_12_ItemsPage1() { return new RssGo.ItemsPage1(); }

        private void VectorAdd_1_ObservableCollection(object instance, object item)
        {
            var collection = (System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>)instance;
            var newItem = (RssGo.FeedData)item;
            collection.Add(newItem);
        }

        private void VectorAdd_2_Collection(object instance, object item)
        {
            var collection = (System.Collections.ObjectModel.Collection<RssGo.FeedData>)instance;
            var newItem = (RssGo.FeedData)item;
            collection.Add(newItem);
        }

        private void VectorAdd_6_List(object instance, object item)
        {
            var collection = (System.Collections.Generic.List<RssGo.FeedItem>)instance;
            var newItem = (RssGo.FeedItem)item;
            collection.Add(newItem);
        }


        private IXamlType CreateXamlType(string typeName)
        {
            XamlSystemBaseType xamlType = null;
            XamlUserType userType;

            switch (typeName)
            {
            case "System.Object":
            case "Object":
                xamlType = new XamlSystemBaseType(typeName, typeof(System.Object));
                break;

            case "System.String":
            case "String":
                xamlType = new XamlSystemBaseType(typeName, typeof(System.String));
                break;

            case "Windows.UI.Xaml.Controls.RichTextBlock":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.RichTextBlock));
                break;

            case "Windows.UI.Xaml.Controls.TextBlock":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.TextBlock));
                break;

            case "Windows.UI.Xaml.Controls.Button":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.Button));
                break;

            case "Windows.UI.Xaml.Controls.RadioButton":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.RadioButton));
                break;

            case "Windows.UI.Xaml.Controls.GridViewItem":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.GridViewItem));
                break;

            case "Windows.UI.Xaml.Controls.ScrollViewer":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.ScrollViewer));
                break;

            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.UserControl));
                break;

            case "System.Boolean":
            case "Boolean":
                xamlType = new XamlSystemBaseType(typeName, typeof(System.Boolean));
                break;

            case "Windows.UI.Xaml.Controls.ListViewItem":
                xamlType = new XamlSystemBaseType(typeName, typeof(Windows.UI.Xaml.Controls.ListViewItem));
                break;

            case "RssGo.FeedDataSource":
                userType = new XamlUserType(this, typeName, typeof(RssGo.FeedDataSource), GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_FeedDataSource;
                userType.AddMemberName("Feeds", "RssGo.FeedDataSource.Feeds");
                AddToMapOfTypeToStandardName(typeof(System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>),
                                             "System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>");
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>), GetXamlTypeByName("System.Collections.ObjectModel.Collection<RssGo.FeedData>"));
                userType.Activator = Activate_1_ObservableCollection;
                userType.CollectionAdd = VectorAdd_1_ObservableCollection;
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.Collection<RssGo.FeedData>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.ObjectModel.Collection<RssGo.FeedData>), GetXamlTypeByName("Object"));
                userType.Activator = Activate_2_Collection;
                userType.CollectionAdd = VectorAdd_2_Collection;
                xamlType = userType;
                break;

            case "RssGo.FeedData":
                userType = new XamlUserType(this, typeName, typeof(RssGo.FeedData), GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_FeedData;
                userType.AddMemberName("Title", "RssGo.FeedData.Title");
                userType.AddMemberName("Description", "RssGo.FeedData.Description");
                userType.AddMemberName("PubDate", "RssGo.FeedData.PubDate");
                userType.AddMemberName("Items", "RssGo.FeedData.Items");
                AddToMapOfTypeToStandardName(typeof(System.Collections.Generic.List<RssGo.FeedItem>),
                                             "System.Collections.Generic.List<RssGo.FeedItem>");
                xamlType = userType;
                break;

            case "System.DateTime":
                userType = new XamlUserType(this, typeName, typeof(System.DateTime), GetXamlTypeByName("System.ValueType"));
                xamlType = userType;
                break;

            case "System.ValueType":
                userType = new XamlUserType(this, typeName, typeof(System.ValueType), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "System.Collections.Generic.List<RssGo.FeedItem>":
                userType = new XamlUserType(this, typeName, typeof(System.Collections.Generic.List<RssGo.FeedItem>), GetXamlTypeByName("Object"));
                userType.Activator = Activate_6_List;
                userType.CollectionAdd = VectorAdd_6_List;
                xamlType = userType;
                break;

            case "RssGo.FeedItem":
                userType = new XamlUserType(this, typeName, typeof(RssGo.FeedItem), GetXamlTypeByName("Object"));
                userType.Activator = Activate_7_FeedItem;
                userType.AddMemberName("Title", "RssGo.FeedItem.Title");
                userType.AddMemberName("Author", "RssGo.FeedItem.Author");
                userType.AddMemberName("Content", "RssGo.FeedItem.Content");
                userType.AddMemberName("PubDate", "RssGo.FeedItem.PubDate");
                userType.AddMemberName("Link", "RssGo.FeedItem.Link");
                xamlType = userType;
                break;

            case "System.Uri":
                userType = new XamlUserType(this, typeName, typeof(System.Uri), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "RssGo.DateConverter":
                userType = new XamlUserType(this, typeName, typeof(RssGo.DateConverter), GetXamlTypeByName("Object"));
                userType.Activator = Activate_9_DateConverter;
                xamlType = userType;
                break;

            case "RssGo.Common.LayoutAwarePage":
                userType = new XamlUserType(this, typeName, typeof(RssGo.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_LayoutAwarePage;
                userType.AddMemberName("UseFilledStateForNarrowWindow", "RssGo.Common.LayoutAwarePage.UseFilledStateForNarrowWindow");
                xamlType = userType;
                break;

            case "RssGo.BlankPage":
                userType = new XamlUserType(this, typeName, typeof(RssGo.BlankPage), GetXamlTypeByName("RssGo.Common.LayoutAwarePage"));
                userType.Activator = Activate_11_BlankPage;
                xamlType = userType;
                break;

            case "RssGo.ItemsPage1":
                userType = new XamlUserType(this, typeName, typeof(RssGo.ItemsPage1), GetXamlTypeByName("RssGo.Common.LayoutAwarePage"));
                userType.Activator = Activate_12_ItemsPage1;
                xamlType = userType;
                break;

            }
            return xamlType;
        }


        private object get_0_FeedDataSource_Feeds(object instance)
        {
            var that = (RssGo.FeedDataSource)instance;
            return that.Feeds;
        }
        private object get_1_FeedData_Title(object instance)
        {
            var that = (RssGo.FeedData)instance;
            return that.Title;
        }
        private void set_1_FeedData_Title(object instance, object Value)
        {
            var that = (RssGo.FeedData)instance;
            that.Title = (System.String)Value;
        }
        private object get_2_FeedData_Description(object instance)
        {
            var that = (RssGo.FeedData)instance;
            return that.Description;
        }
        private void set_2_FeedData_Description(object instance, object Value)
        {
            var that = (RssGo.FeedData)instance;
            that.Description = (System.String)Value;
        }
        private object get_3_FeedData_PubDate(object instance)
        {
            var that = (RssGo.FeedData)instance;
            return that.PubDate;
        }
        private void set_3_FeedData_PubDate(object instance, object Value)
        {
            var that = (RssGo.FeedData)instance;
            that.PubDate = (System.DateTime)Value;
        }
        private object get_4_FeedData_Items(object instance)
        {
            var that = (RssGo.FeedData)instance;
            return that.Items;
        }
        private object get_5_FeedItem_Title(object instance)
        {
            var that = (RssGo.FeedItem)instance;
            return that.Title;
        }
        private void set_5_FeedItem_Title(object instance, object Value)
        {
            var that = (RssGo.FeedItem)instance;
            that.Title = (System.String)Value;
        }
        private object get_6_FeedItem_Author(object instance)
        {
            var that = (RssGo.FeedItem)instance;
            return that.Author;
        }
        private void set_6_FeedItem_Author(object instance, object Value)
        {
            var that = (RssGo.FeedItem)instance;
            that.Author = (System.String)Value;
        }
        private object get_7_FeedItem_Content(object instance)
        {
            var that = (RssGo.FeedItem)instance;
            return that.Content;
        }
        private void set_7_FeedItem_Content(object instance, object Value)
        {
            var that = (RssGo.FeedItem)instance;
            that.Content = (System.String)Value;
        }
        private object get_8_FeedItem_PubDate(object instance)
        {
            var that = (RssGo.FeedItem)instance;
            return that.PubDate;
        }
        private void set_8_FeedItem_PubDate(object instance, object Value)
        {
            var that = (RssGo.FeedItem)instance;
            that.PubDate = (System.DateTime)Value;
        }
        private object get_9_FeedItem_Link(object instance)
        {
            var that = (RssGo.FeedItem)instance;
            return that.Link;
        }
        private void set_9_FeedItem_Link(object instance, object Value)
        {
            var that = (RssGo.FeedItem)instance;
            that.Link = (System.Uri)Value;
        }
        private object get_10_LayoutAwarePage_UseFilledStateForNarrowWindow(object instance)
        {
            var that = (RssGo.Common.LayoutAwarePage)instance;
            return that.UseFilledStateForNarrowWindow;
        }
        private void set_10_LayoutAwarePage_UseFilledStateForNarrowWindow(object instance, object Value)
        {
            var that = (RssGo.Common.LayoutAwarePage)instance;
            that.UseFilledStateForNarrowWindow = (System.Boolean)Value;
        }

        private IXamlMember CreateXamlMember(string longMemberName)
        {
            XamlMember xamlMember = null;
            XamlUserType userType;

            switch (longMemberName)
            {
            case "RssGo.FeedDataSource.Feeds":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedDataSource");
                xamlMember = new XamlMember(this, "Feeds", "System.Collections.ObjectModel.ObservableCollection<RssGo.FeedData>");
                xamlMember.Getter = get_0_FeedDataSource_Feeds;
                xamlMember.SetIsReadOnly();
                break;
            case "RssGo.FeedData.Title":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedData");
                xamlMember = new XamlMember(this, "Title", "String");
                xamlMember.Getter = get_1_FeedData_Title;
                xamlMember.Setter = set_1_FeedData_Title;
                break;
            case "RssGo.FeedData.Description":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedData");
                xamlMember = new XamlMember(this, "Description", "String");
                xamlMember.Getter = get_2_FeedData_Description;
                xamlMember.Setter = set_2_FeedData_Description;
                break;
            case "RssGo.FeedData.PubDate":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedData");
                xamlMember = new XamlMember(this, "PubDate", "System.DateTime");
                xamlMember.Getter = get_3_FeedData_PubDate;
                xamlMember.Setter = set_3_FeedData_PubDate;
                break;
            case "RssGo.FeedData.Items":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedData");
                xamlMember = new XamlMember(this, "Items", "System.Collections.Generic.List<RssGo.FeedItem>");
                xamlMember.Getter = get_4_FeedData_Items;
                xamlMember.SetIsReadOnly();
                break;
            case "RssGo.FeedItem.Title":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedItem");
                xamlMember = new XamlMember(this, "Title", "String");
                xamlMember.Getter = get_5_FeedItem_Title;
                xamlMember.Setter = set_5_FeedItem_Title;
                break;
            case "RssGo.FeedItem.Author":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedItem");
                xamlMember = new XamlMember(this, "Author", "String");
                xamlMember.Getter = get_6_FeedItem_Author;
                xamlMember.Setter = set_6_FeedItem_Author;
                break;
            case "RssGo.FeedItem.Content":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedItem");
                xamlMember = new XamlMember(this, "Content", "String");
                xamlMember.Getter = get_7_FeedItem_Content;
                xamlMember.Setter = set_7_FeedItem_Content;
                break;
            case "RssGo.FeedItem.PubDate":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedItem");
                xamlMember = new XamlMember(this, "PubDate", "System.DateTime");
                xamlMember.Getter = get_8_FeedItem_PubDate;
                xamlMember.Setter = set_8_FeedItem_PubDate;
                break;
            case "RssGo.FeedItem.Link":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.FeedItem");
                xamlMember = new XamlMember(this, "Link", "System.Uri");
                xamlMember.Getter = get_9_FeedItem_Link;
                xamlMember.Setter = set_9_FeedItem_Link;
                break;
            case "RssGo.Common.LayoutAwarePage.UseFilledStateForNarrowWindow":
                userType = (XamlUserType)GetXamlTypeByName("RssGo.Common.LayoutAwarePage");
                xamlMember = new XamlMember(this, "UseFilledStateForNarrowWindow", "Boolean");
                xamlMember.Getter = get_10_LayoutAwarePage_UseFilledStateForNarrowWindow;
                xamlMember.Setter = set_10_LayoutAwarePage_UseFilledStateForNarrowWindow;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : IXamlType
    {
        string _fullName;
        Type _underlyingType;

        public XamlSystemBaseType(string fullName, Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public IXamlType BaseType { get { throw new NotImplementedException(); } }
        virtual public IXamlMember ContentProperty { get { throw new NotImplementedException(); } }
        virtual public IXamlMember GetMember(string name) { throw new NotImplementedException(); }
        virtual public bool IsArray { get { throw new NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new NotImplementedException(); } }
        virtual public IXamlType ItemType { get { throw new NotImplementedException(); } }
        virtual public IXamlType KeyType { get { throw new NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new NotImplementedException(); }
        virtual public void RunInitializer()   { throw new NotImplementedException(); }
        virtual public object CreateFromString(String input)   { throw new NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : XamlSystemBaseType
    {
        XamlTypeInfoProvider _provider;
        IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        Dictionary<string, string> _memberNames;
        Dictionary<string, object> _enumValues;

        public XamlUserType(XamlTypeInfoProvider provider, string fullName, Type fullType, IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public Object CreateFromString(String input)
        {
            if (_enumValues != null)
            {
                Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = Convert.ToInt32(valuePart.Trim());
                            }
                            catch( FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( String.Compare(valuePart.Trim(), key, System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( FormatException )
                    {
                        throw new ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName, string longName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new Dictionary<string,string>();
            }
            _memberNames.Add(shortName, longName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : IXamlMember
    {
        XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new InvalidOperationException("SetValue");
        }
    }
}


