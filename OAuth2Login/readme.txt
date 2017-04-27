-----------------------------------------------------------------
------------------------ OAuth2Login ----------------------------
-----------------------------------------------------------------

Step1: Add the nuget paket "OAuth2Login"
Step2: Update the parameters in the added Configuration Section "oAuth2LoginConfig" and replace the following variables with the right values
- acceptedRedirectUrl
- failedRedirectUrl
- clientid
- clientsecret
- callbackUrl
- scope
- ...

------------------------------------------------------------------
----------------- Examplpe of integration-------------------------
------------------------------------------------------------------

1. Create Controller
------------------------------------------------------------------
public class AccountController : Controller
    {

        public ActionResult Login(string id,string appName)
        {
            string absoluteUri = string.Format("{0}://{1}", Request.Url.Scheme, Request.Url.Authority);
            var service = BaseOauth2Service.GetService(appName,id, absoluteUri);

            if (service != null)
            {
                var url = service.BeginAuthentication();
                return Redirect(url);
            }
            else
            {
                return RedirectToAction("LoginFail");
            }
        }

        public ActionResult Callback(string id,string appName)
        {
            string absoluteUri = string.Format("{0}://{1}", Request.Url.Scheme, Request.Url.Authority);
            var service = BaseOauth2Service.GetService(appName,id, absoluteUri);

            if (service != null)
            {
                BaseUserData userData = null;
                var redirectUrl = service.ValidateLogin(Request);

                switch (id)
                {
                    case "Facebook":
                        userData = service.GetUserInfo<FacebookUserData>();
                        break;
                    case "Google":
                        userData = service.GetUserInfo<GoogleUserData>();
                        break;
                    case "Twitter":
                        userData = service.GetUserInfo<TwitterUserData>();
                        break;
                }

                if (redirectUrl != null)
                {
                    return Redirect(redirectUrl);
                }

                return RedirectToAction("LoginSuccess");

            }
            else
            {
                return RedirectToAction("LoginFail");
            }
        }

        public ActionResult LoginFail()
        {
            return View();
        }

        public ActionResult LoginSuccess()
        {
            return View();
        }
    }

2. Create View with some links as for exemple:
------------------------------------------------------------------
<a href="/Account/Login/Facebook?appName=autoprofi" class="btn btn-default" >Facebook</a>
<a href="/Account/Login/Google?appName=autoprofi" class="btn btn-default" >GooglePlus</a>

