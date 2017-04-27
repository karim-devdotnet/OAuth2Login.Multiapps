<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="d0ed9acb-0435-4532-afdd-b5115bc4d562" namespace="OAuth2Login.Configuration" xmlSchemaNamespace="urn:OAuth2Login.Configuration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="OAuth2LoginConfig" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="oAuth2LoginConfig">
      <elementProperties>
        <elementProperty name="Web" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="web" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/WebConfiguration" />
          </type>
        </elementProperty>
        <elementProperty name="OAuth" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="oauth" isReadOnly="true">
          <type>
            <configurationElementCollectionMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/OAuth" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElement name="WebConfiguration">
      <attributeProperties>
        <attributeProperty name="AcceptedRedirectUrl" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="acceptedRedirectUrl" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="FailedRedirectUrl" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="failedRedirectUrl" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Proxy" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="proxy" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElementCollection name="OAuth" xmlItemName="app" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/OAuthConfig" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="OAuthSettingsConfig">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="ClientId" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="clientid" isReadOnly="true">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="ClientSecret" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="clientsecret" isReadOnly="true">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="CallbackUrl" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="callbackUrl" isReadOnly="false" defaultValue="&quot;oob&quot;">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Scope" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="scope" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Endpoint" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="endpoint" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="OAuthConfig">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="true">
          <type>
            <externalTypeMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="OAuthSettings" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="oAuthSettings" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/OAuthSettings" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationElement>
    <configurationElementCollection name="OAuthSettings" xmlItemName="add" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/d0ed9acb-0435-4532-afdd-b5115bc4d562/OAuthSettingsConfig" />
      </itemType>
    </configurationElementCollection>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>