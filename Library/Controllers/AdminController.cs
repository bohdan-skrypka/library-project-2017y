using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // страница не найдена
        public ActionResult NotFound()
        {
            return View();
        }

        // таблица пользователей без возможности редактирования
        public ActionResult BasicTable()
        {
            return View();
        }

        // таблица пользователей для редактирования пользователей
        public ActionResult ResponsiveTable()
        {
            return View();
        }

        public ActionResult Mail()
        {
            return View();
        }
        public ActionResult MailResponsive()
        {
            return View();
        }
        public ActionResult VectorMaps()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}