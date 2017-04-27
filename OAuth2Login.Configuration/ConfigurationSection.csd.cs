//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuth2Login.Configuration
{
    
    
    /// <summary>
    /// The OAuth2LoginConfig Configuration Section.
    /// </summary>
    public partial class OAuth2LoginConfig : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the OAuth2LoginConfig Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string OAuth2LoginConfigSectionName = "oAuth2LoginConfig";
        
        /// <summary>
        /// The XML path of the OAuth2LoginConfig Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string OAuth2LoginConfigSectionPath = "oAuth2LoginConfig";
        
        /// <summary>
        /// Gets the OAuth2LoginConfig instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public static global::OAuth2Login.Configuration.OAuth2LoginConfig Instance
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuth2LoginConfig)(global::System.Configuration.ConfigurationManager.GetSection(global::OAuth2Login.Configuration.OAuth2LoginConfig.OAuth2LoginConfigSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuth2LoginConfig.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuth2LoginConfig.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Web Property
        /// <summary>
        /// The XML name of the <see cref="Web"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string WebPropertyName = "web";
        
        /// <summary>
        /// Gets or sets the Web.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Web.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuth2LoginConfig.WebPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::OAuth2Login.Configuration.WebConfiguration Web
        {
            get
            {
                return ((global::OAuth2Login.Configuration.WebConfiguration)(base[global::OAuth2Login.Configuration.OAuth2LoginConfig.WebPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.OAuth2LoginConfig.WebPropertyName] = value;
            }
        }
        #endregion
        
        #region OAuth Property
        /// <summary>
        /// The XML name of the <see cref="OAuth"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string OAuthPropertyName = "oauth";
        
        /// <summary>
        /// Gets the OAuth.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The OAuth.")]
        [global::System.ComponentModel.ReadOnlyAttribute(true)]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuth2LoginConfig.OAuthPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::OAuth2Login.Configuration.OAuth OAuth
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuth)(base[global::OAuth2Login.Configuration.OAuth2LoginConfig.OAuthPropertyName]));
            }
        }
        #endregion
    }
}
namespace OAuth2Login.Configuration
{
    
    
    /// <summary>
    /// The WebConfiguration Configuration Element.
    /// </summary>
    public partial class WebConfiguration : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region AcceptedRedirectUrl Property
        /// <summary>
        /// The XML name of the <see cref="AcceptedRedirectUrl"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string AcceptedRedirectUrlPropertyName = "acceptedRedirectUrl";
        
        /// <summary>
        /// Gets or sets the AcceptedRedirectUrl.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The AcceptedRedirectUrl.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.WebConfiguration.AcceptedRedirectUrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string AcceptedRedirectUrl
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.WebConfiguration.AcceptedRedirectUrlPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.WebConfiguration.AcceptedRedirectUrlPropertyName] = value;
            }
        }
        #endregion
        
        #region FailedRedirectUrl Property
        /// <summary>
        /// The XML name of the <see cref="FailedRedirectUrl"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string FailedRedirectUrlPropertyName = "failedRedirectUrl";
        
        /// <summary>
        /// Gets or sets the FailedRedirectUrl.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The FailedRedirectUrl.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.WebConfiguration.FailedRedirectUrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string FailedRedirectUrl
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.WebConfiguration.FailedRedirectUrlPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.WebConfiguration.FailedRedirectUrlPropertyName] = value;
            }
        }
        #endregion
        
        #region Proxy Property
        /// <summary>
        /// The XML name of the <see cref="Proxy"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ProxyPropertyName = "proxy";
        
        /// <summary>
        /// Gets or sets the Proxy.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Proxy.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.WebConfiguration.ProxyPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Proxy
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.WebConfiguration.ProxyPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.WebConfiguration.ProxyPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace OAuth2Login.Configuration
{
    
    
    /// <summary>
    /// A collection of OAuthConfig instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::OAuth2Login.Configuration.OAuthConfig), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::OAuth2Login.Configuration.OAuth.OAuthConfigPropertyName)]
    public partial class OAuth : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string OAuthConfigPropertyName = "app";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override string ElementName
        {
            get
            {
                return global::OAuth2Login.Configuration.OAuth.OAuthConfigPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::OAuth2Login.Configuration.OAuth.OAuthConfigPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::OAuth2Login.Configuration.OAuthConfig)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::OAuth2Login.Configuration.OAuthConfig"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::OAuth2Login.Configuration.OAuthConfig"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::OAuth2Login.Configuration.OAuthConfig();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthConfig this[int index]
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuthConfig)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthConfig this[object name]
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuthConfig)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="app">The <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public void Add(global::OAuth2Login.Configuration.OAuthConfig app)
        {
            base.BaseAdd(app);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="app">The <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public void Remove(global::OAuth2Login.Configuration.OAuthConfig app)
        {
            base.BaseRemove(this.GetElementKey(app));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthConfig GetItemAt(int index)
        {
            return ((global::OAuth2Login.Configuration.OAuthConfig)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::OAuth2Login.Configuration.OAuthConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthConfig GetItemByKey(string name)
        {
            return ((global::OAuth2Login.Configuration.OAuthConfig)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace OAuth2Login.Configuration
{
    
    
    /// <summary>
    /// The OAuthSettingsConfig Configuration Element.
    /// </summary>
    public partial class OAuthSettingsConfig : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthSettingsConfig.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthSettingsConfig.NamePropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.OAuthSettingsConfig.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region ClientId Property
        /// <summary>
        /// The XML name of the <see cref="ClientId"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ClientIdPropertyName = "clientid";
        
        /// <summary>
        /// Gets the ClientId.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The ClientId.")]
        [global::System.ComponentModel.ReadOnlyAttribute(true)]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthSettingsConfig.ClientIdPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string ClientId
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthSettingsConfig.ClientIdPropertyName]));
            }
        }
        #endregion
        
        #region ClientSecret Property
        /// <summary>
        /// The XML name of the <see cref="ClientSecret"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ClientSecretPropertyName = "clientsecret";
        
        /// <summary>
        /// Gets the ClientSecret.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The ClientSecret.")]
        [global::System.ComponentModel.ReadOnlyAttribute(true)]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthSettingsConfig.ClientSecretPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string ClientSecret
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthSettingsConfig.ClientSecretPropertyName]));
            }
        }
        #endregion
        
        #region CallbackUrl Property
        /// <summary>
        /// The XML name of the <see cref="CallbackUrl"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string CallbackUrlPropertyName = "callbackUrl";
        
        /// <summary>
        /// Gets or sets the CallbackUrl.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The CallbackUrl.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthSettingsConfig.CallbackUrlPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue="oob")]
        public virtual string CallbackUrl
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthSettingsConfig.CallbackUrlPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.OAuthSettingsConfig.CallbackUrlPropertyName] = value;
            }
        }
        #endregion
        
        #region Scope Property
        /// <summary>
        /// The XML name of the <see cref="Scope"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ScopePropertyName = "scope";
        
        /// <summary>
        /// Gets or sets the Scope.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Scope.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthSettingsConfig.ScopePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Scope
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthSettingsConfig.ScopePropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.OAuthSettingsConfig.ScopePropertyName] = value;
            }
        }
        #endregion
        
        #region Endpoint Property
        /// <summary>
        /// The XML name of the <see cref="Endpoint"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string EndpointPropertyName = "endpoint";
        
        /// <summary>
        /// Gets or sets the Endpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Endpoint.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthSettingsConfig.EndpointPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Endpoint
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthSettingsConfig.EndpointPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.OAuthSettingsConfig.EndpointPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace OAuth2Login.Configuration
{
    
    
    /// <summary>
    /// The OAuthConfig Configuration Element.
    /// </summary>
    public partial class OAuthConfig : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.ComponentModel.ReadOnlyAttribute(true)]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthConfig.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::OAuth2Login.Configuration.OAuthConfig.NamePropertyName]));
            }
        }
        #endregion
        
        #region OAuthSettings Property
        /// <summary>
        /// The XML name of the <see cref="OAuthSettings"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string OAuthSettingsPropertyName = "oAuthSettings";
        
        /// <summary>
        /// Gets or sets the OAuthSettings.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The OAuthSettings.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::OAuth2Login.Configuration.OAuthConfig.OAuthSettingsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::OAuth2Login.Configuration.OAuthSettings OAuthSettings
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuthSettings)(base[global::OAuth2Login.Configuration.OAuthConfig.OAuthSettingsPropertyName]));
            }
            set
            {
                base[global::OAuth2Login.Configuration.OAuthConfig.OAuthSettingsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace OAuth2Login.Configuration
{
    
    
    /// <summary>
    /// A collection of OAuthSettingsConfig instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::OAuth2Login.Configuration.OAuthSettingsConfig), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::OAuth2Login.Configuration.OAuthSettings.OAuthSettingsConfigPropertyName)]
    public partial class OAuthSettings : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string OAuthSettingsConfigPropertyName = "add";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override string ElementName
        {
            get
            {
                return global::OAuth2Login.Configuration.OAuthSettings.OAuthSettingsConfigPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::OAuth2Login.Configuration.OAuthSettings.OAuthSettingsConfigPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::OAuth2Login.Configuration.OAuthSettingsConfig)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::OAuth2Login.Configuration.OAuthSettingsConfig();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthSettingsConfig this[int index]
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuthSettingsConfig)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthSettingsConfig this[object name]
        {
            get
            {
                return ((global::OAuth2Login.Configuration.OAuthSettingsConfig)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="add">The <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public void Add(global::OAuth2Login.Configuration.OAuthSettingsConfig add)
        {
            base.BaseAdd(add);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="add">The <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public void Remove(global::OAuth2Login.Configuration.OAuthSettingsConfig add)
        {
            base.BaseRemove(this.GetElementKey(add));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthSettingsConfig GetItemAt(int index)
        {
            return ((global::OAuth2Login.Configuration.OAuthSettingsConfig)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::OAuth2Login.Configuration.OAuthSettingsConfig"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::OAuth2Login.Configuration.OAuthSettingsConfig GetItemByKey(string name)
        {
            return ((global::OAuth2Login.Configuration.OAuthSettingsConfig)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}