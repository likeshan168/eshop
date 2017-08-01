using Nop.Plugin.Widgets.HelloWorld.Models;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Widgets.HelloWorld.Controllers
{
    public class WidgetsHelloWorldController: BasePluginController
    {
        public WidgetsHelloWorldController()
        {

        }
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            return View("~/Plugins/Widgets.HelloWorld/Views/WidgetsHelloWorld/Configure.cshtml");
        }
        [AdminAuthorize]
        [HttpPost]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            return Configure();
        }

        [ChildActionOnly]
        public ActionResult PublicInfo(string widgetZone, object additionalData = null)
        {
            return View("~/Plugins/Widgets.HelloWorld/Views/WidgetsHelloWorld/PublicInfo.cshtml", null);
        }
    }
}
