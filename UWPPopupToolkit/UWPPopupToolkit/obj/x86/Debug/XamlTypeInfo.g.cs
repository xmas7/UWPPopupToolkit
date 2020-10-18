﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace UWPPopupToolkit
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            var userXamlType = xamlType as global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType;
            if(xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
            {
                global::Windows.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForType(type);
                if (libXamlType != null)
                {
                    if(libXamlType.IsConstructible || xamlType == null)
                    {
                        xamlType = libXamlType;
                    }
                }
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            var userXamlType = xamlType as global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType;
            if(xamlType == null || (userXamlType != null && userXamlType.IsReturnTypeStub && !userXamlType.IsLocalType))
            {
                global::Windows.UI.Xaml.Markup.IXamlType libXamlType = CheckOtherMetadataProvidersForName(typeName);
                if (libXamlType != null)
                {
                    if(libXamlType.IsConstructible || xamlType == null)
                    {
                        xamlType = libXamlType;
                    }
                }
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
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

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[18];
            _typeNameTable[0] = "UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[2] = "Double";
            _typeNameTable[3] = "Guid";
            _typeNameTable[4] = "System.ValueType";
            _typeNameTable[5] = "Object";
            _typeNameTable[6] = "Windows.UI.Xaml.Duration";
            _typeNameTable[7] = "UWPPopupToolkit.ListPage";
            _typeNameTable[8] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[9] = "UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.Grid";
            _typeNameTable[11] = "Windows.UI.Xaml.Controls.Panel";
            _typeNameTable[12] = "String";
            _typeNameTable[13] = "UWPPopupToolkit.MainPage";
            _typeNameTable[14] = "Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions";
            _typeNameTable[15] = "Int32";
            _typeNameTable[16] = "Windows.UI.Xaml.Controls.NavigationView";
            _typeNameTable[17] = "Boolean";

            _typeTable = new global::System.Type[18];
            _typeTable[0] = typeof(global::UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[2] = typeof(global::System.Double);
            _typeTable[3] = typeof(global::System.Guid);
            _typeTable[4] = typeof(global::System.ValueType);
            _typeTable[5] = typeof(global::System.Object);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Duration);
            _typeTable[7] = typeof(global::UWPPopupToolkit.ListPage);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[9] = typeof(global::UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.Grid);
            _typeTable[11] = typeof(global::Windows.UI.Xaml.Controls.Panel);
            _typeTable[12] = typeof(global::System.String);
            _typeTable[13] = typeof(global::UWPPopupToolkit.MainPage);
            _typeTable[14] = typeof(global::Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions);
            _typeTable[15] = typeof(global::System.Int32);
            _typeTable[16] = typeof(global::Windows.UI.Xaml.Controls.NavigationView);
            _typeTable[17] = typeof(global::System.Boolean);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_7_ListPage() { return new global::UWPPopupToolkit.ListPage(); }
        private object Activate_9_PopupPresenterHost() { return new global::UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost(); }
        private object Activate_13_MainPage() { return new global::UWPPopupToolkit.MainPage(); }
        private object Activate_14_NavigationViewExtensions() { return new global::Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.AddMemberName("PopupHeight");
                userType.AddMemberName("Identifier");
                userType.AddMemberName("AnimationDuration");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Double
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Guid
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  System.ValueType
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 5:   //  Object
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.UI.Xaml.Duration
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  UWPPopupToolkit.ListPage
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_ListPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Grid"));
                userType.Activator = Activate_9_PopupPresenterHost;
                userType.AddMemberName("Id");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Windows.UI.Xaml.Controls.Grid
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Windows.UI.Xaml.Controls.Panel
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 12:   //  String
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 13:   //  UWPPopupToolkit.MainPage
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions
                userType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_14_NavigationViewExtensions;
                userType.AddMemberName("SelectedIndex");
                userType.AddMemberName("CollapseOnClick");
                userType.SetIsBindable();
                xamlType = userType;
                break;

            case 15:   //  Int32
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 16:   //  Windows.UI.Xaml.Controls.NavigationView
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 17:   //  Boolean
                xamlType = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }

        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> _otherProviders;
        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> OtherProviders
        {
            get
            {
                if(_otherProviders == null)
                {
                    var otherProviders = new global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider>();
                    global::Windows.UI.Xaml.Markup.IXamlMetadataProvider provider;
                    provider = new global::Microsoft.Toolkit.Uwp.UI.Microsoft_Toolkit_Uwp_UI_XamlTypeInfo.XamlMetaDataProvider() as global::Windows.UI.Xaml.Markup.IXamlMetadataProvider;
                    otherProviders.Add(provider); 
                    _otherProviders = otherProviders;
                }
                return _otherProviders;
            }
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForName(string typeName)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            global::Windows.UI.Xaml.Markup.IXamlType foundXamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(typeName);
                if(xamlType != null)
                {
                    if(xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
                    {
                        return xamlType;
                    }
                    foundXamlType = xamlType;
                }
            }
            return foundXamlType;
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            global::Windows.UI.Xaml.Markup.IXamlType foundXamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(type);
                if(xamlType != null)
                {
                    if(xamlType.IsConstructible)    // not Constructible means it might be a Return Type Stub
                    {
                        return xamlType;
                    }
                    foundXamlType = xamlType;
                }
            }
            return foundXamlType;
        }

        private object get_0_SlideupPopup_PopupHeight(object instance)
        {
            var that = (global::UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup)instance;
            return that.PopupHeight;
        }
        private void set_0_SlideupPopup_PopupHeight(object instance, object Value)
        {
            var that = (global::UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup)instance;
            that.PopupHeight = (global::System.Double)Value;
        }
        private object get_1_SlideupPopup_Identifier(object instance)
        {
            var that = (global::UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup)instance;
            return that.Identifier;
        }
        private object get_2_SlideupPopup_AnimationDuration(object instance)
        {
            var that = (global::UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup)instance;
            return that.AnimationDuration;
        }
        private void set_2_SlideupPopup_AnimationDuration(object instance, object Value)
        {
            var that = (global::UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup)instance;
            that.AnimationDuration = (global::Windows.UI.Xaml.Duration)Value;
        }
        private object get_3_PopupPresenterHost_Id(object instance)
        {
            var that = (global::UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost)instance;
            return that.Id;
        }
        private void set_3_PopupPresenterHost_Id(object instance, object Value)
        {
            var that = (global::UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost)instance;
            that.Id = (global::System.String)Value;
        }
        private object get_4_NavigationViewExtensions_SelectedIndex(object instance)
        {
            return global::Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions.GetSelectedIndex((global::Windows.UI.Xaml.Controls.NavigationView)instance);
        }
        private void set_4_NavigationViewExtensions_SelectedIndex(object instance, object Value)
        {
            global::Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions.SetSelectedIndex((global::Windows.UI.Xaml.Controls.NavigationView)instance, (global::System.Int32)Value);
        }
        private object get_5_NavigationViewExtensions_CollapseOnClick(object instance)
        {
            return global::Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions.GetCollapseOnClick((global::Windows.UI.Xaml.Controls.NavigationView)instance);
        }
        private void set_5_NavigationViewExtensions_CollapseOnClick(object instance, object Value)
        {
            global::Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions.SetCollapseOnClick((global::Windows.UI.Xaml.Controls.NavigationView)instance, (global::System.Boolean)Value);
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember xamlMember = null;
            global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup.PopupHeight":
                userType = (global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup");
                xamlMember = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember(this, "PopupHeight", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_SlideupPopup_PopupHeight;
                xamlMember.Setter = set_0_SlideupPopup_PopupHeight;
                break;
            case "UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup.Identifier":
                userType = (global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup");
                xamlMember = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember(this, "Identifier", "Guid");
                xamlMember.Getter = get_1_SlideupPopup_Identifier;
                xamlMember.SetIsReadOnly();
                break;
            case "UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup.AnimationDuration":
                userType = (global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPopupToolkit.Controls.SlideupPopup.SlideupPopup");
                xamlMember = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember(this, "AnimationDuration", "Windows.UI.Xaml.Duration");
                xamlMember.Getter = get_2_SlideupPopup_AnimationDuration;
                xamlMember.Setter = set_2_SlideupPopup_AnimationDuration;
                break;
            case "UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost.Id":
                userType = (global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPopupToolkit.Controls.PopupPresenterHost.PopupPresenterHost");
                xamlMember = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember(this, "Id", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_PopupPresenterHost_Id;
                xamlMember.Setter = set_3_PopupPresenterHost_Id;
                break;
            case "Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions.SelectedIndex":
                userType = (global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions");
                xamlMember = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember(this, "SelectedIndex", "Int32");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.Controls.NavigationView");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_4_NavigationViewExtensions_SelectedIndex;
                xamlMember.Setter = set_4_NavigationViewExtensions_SelectedIndex;
                break;
            case "Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions.CollapseOnClick":
                userType = (global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Microsoft.Toolkit.Uwp.UI.Extensions.NavigationViewExtensions");
                xamlMember = new global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlMember(this, "CollapseOnClick", "Boolean");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.Controls.NavigationView");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_5_NavigationViewExtensions_CollapseOnClick;
                xamlMember.Setter = set_5_NavigationViewExtensions_CollapseOnClick;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlSystemBaseType
    {
        global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
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

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
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

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::UWPPopupToolkit.UWPPopupToolkit_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
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
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

