using OAuth2Login.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2Login.Core
{
    public class Oauth2LoginFactory
    {
        public static T CreateClient<T>(string configName) where T : AbstractClientProvider, new()
        {
            if (String.IsNullOrEmpty(configName))
                throw new Exception("Invalid configuration name");

            var ccRoot =
                ConfigurationManager.GetSection("oauth2.login.configuration") as OAuthConfigurationSection;

            if (ccRoot != null)
            {
                var ccWebElem = ccRoot.WebConfiguration;

                IEnumerator configurationReader = ccRoot.OAuthVClientConfigurations.GetEnumerator();

                OAuthConfigurationElement ccOauth = null;
                while (configurationReader.MoveNext())
                {
                    var currentOauthElement = configurationReader.Current as OAuthConfigurationElement;
                    if (currentOauthElement != null && currentOauthElement.Name == configName)
                    {
                        ccOauth = currentOauthElement;
                        break;
                    }
                }

                if (ccOauth != null)
                {
                    var constructorParams = new object[]
                    {
                        ccWebElem,
                        ccOauth
                    };
                    var client = (T)Activator.CreateInstance(typeof(T), constructorParams);

                    return client;
                }
                else
                {
                    throw new Exception("ERROR: [MultiOAuthFactroy] ConfigurationName is not found!");
                }

            }
            return default(T);
        }

        public static T CreateClient<T>(string appName,string configName) where T : AbstractClientProvider, new()
        {
            if (String.IsNullOrEmpty(appName))
                throw new Exception("ERROR: AppName cannot be null!");
            if (String.IsNullOrEmpty(configName))
                throw new Exception("ERROR: ConfigName cannot be null!");

            var ccRoot = OAuth2LoginConfig.Instance;

            if (ccRoot != null)
            {
                WebConfiguration ccWebElem =  ccRoot.Web;
                OAuthConfig ccAppElem = OAuth2LoginConfig.Instance.OAuth.GetItemByKey(appName);
                if(ccAppElem == null)
                    throw new Exception($"ERROR: AppName[{appName}] in OAuth2Login.Configuartion is not found!");

                OAuthSettingsConfig ccOauth = ccAppElem.OAuthSettings.GetItemByKey(configName);

                if (ccOauth == null)
                    throw new Exception($"ERROR: ConfigurationName[{configName}] in OAuth2Login.Configuartion is not found!");

                var constructorParams = new object[]
                {
                    ccWebElem,
                    ccOauth
                };
                var client = (T)Activator.CreateInstance(typeof(T), constructorParams);

                return client;

            }

            return default(T);
        }
    }
}
