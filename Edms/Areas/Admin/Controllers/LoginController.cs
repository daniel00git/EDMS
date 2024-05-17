using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Edms.Areas.Admin.Controllers
{
  public class LoginController : Controller
  {
    // GET: Admin/Login
    public ActionResult Index()
    {
      UserModel dto = new UserModel();
      return View(dto);
    }
    [HttpPost]

    public ActionResult Index(UserModel dto)
    {
      return View(dto);
    }
  }
}
