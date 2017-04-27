using OAuth2Login.Configuration;
using OAuth2Login.Core;

namespace OAuth2Login.Service
{
    public class WindowsLiveClient : AbstractClientProvider
    {
        public WindowsLiveClient()
        {
        }

        public WindowsLiveClient(OAuthWebConfigurationElement ccRoot, OAuthConfigurationElement ccOauth)
            : base(ccRoot, ccOauth)
        {
        }

        public WindowsLiveClient(WebConfiguration ccRoot, OAuthSettingsConfig ccOauth)
           : base(ccRoot, ccOauth)
        {
        }
    }
}