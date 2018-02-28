using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebLanguage.Helper;

namespace WebLanguage.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = null;


            if (ControllerContext.RouteData.Values["lang"] != null)
            {
                cultureName = ControllerContext.RouteData.Values["lang"].ToString();
            }
            else
            {
                // Attempt to read the culture cookie from Request
                HttpCookie cultureCookie = Request.Cookies["_culture"];
                if (cultureCookie != null)
                    cultureName = cultureCookie.Value;
                else
                    cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ?
                        Request.UserLanguages[0] :  // obtain it from HTTP header AcceptLanguages
                        null;

            }


    
            // Validate culture name
            cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe



            // Modify current thread's cultures           
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;


            ControllerContext.RouteData.Values["lang"] = cultureName;


            return base.BeginExecuteCore(callback, state);
        }

    }
}