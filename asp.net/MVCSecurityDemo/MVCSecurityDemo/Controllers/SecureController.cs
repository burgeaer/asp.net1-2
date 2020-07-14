using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSecurityDemo.Controllers
{
    public class SecureController : Controller
    {
        // GET: Secure
        [Authorize(Users ="aeryn.burgess@yahoo.com")]
        public ContentResult Secure()
        {
            return Content("Secret informations here");
        }
        [AllowAnonymous]
        public ContentResult PublicInfo() {
            return Content("Public informations here");
        }
    }
}