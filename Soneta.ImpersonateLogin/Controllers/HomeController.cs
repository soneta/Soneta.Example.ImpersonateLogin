using System;
using System.Web.Mvc;
using System.Configuration;
using Newtonsoft.Json;
using System.ServiceModel;

namespace Soneta.ImpersonateLogin.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost,
         AllowAnonymous]
        public ActionResult Login365() {
            ActionResult result = null;
            var db = ConfigurationManager.AppSettings["enova365Db"];
            var key = ConfigurationManager.AppSettings["enova365Key"];
            var user = ConfigurationManager.AppSettings["enova365User"];
            var url = ConfigurationManager.AppSettings["enova365Service"];

            try {
                var tokenInfo = new ServiceReference1.GenerateTokenInfo {
                    User = user,
                    DbName = db,
                    Key = key
                };

                var binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
                var endpoint = new EndpointAddress(url + "/Business/TokenService.svc");

                var bus = new ServiceReference1.TokenServiceClient(binding, endpoint);
                var tokenResult = bus.GenerateToken(tokenInfo);
                if (tokenResult.IsAuthenticated) {
                    return new JsonNetResult(new {
                        Token = tokenResult.Token,
                        Db = db
                    });
                }

                result = new JsonNetResult(new {
                    ErrorHandle = !String.IsNullOrEmpty(tokenResult.ExceptionMessage) ? 
                                tokenResult.ExceptionMessage : 
                                "Niepoprawne dane logowania"
                });
            }
            catch (Exception exc) {
                result = new JsonNetResult(new { ErrorHandle = exc.Message });
            }
            return result;
        }
    }

    public class JsonNetResult : ActionResult {
        private object _obj { get; set; }
        public JsonNetResult(object obj) {
            _obj = obj;
        }

        public override void ExecuteResult(ControllerContext context) {
            context.HttpContext.Response.AddHeader("content-type", "application/json");
            context.HttpContext.Response.Write(JsonConvert.SerializeObject(_obj, Formatting.None, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore }));
        }
    }

}