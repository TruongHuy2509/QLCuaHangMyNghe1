using QLCuaHangMyNghe1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCuaHangMyNghe1.Controllers
{
    public class danhmucController : Controller
    {
        // GET: Danhmuc
        QLbanhang db = new QLbanhang();
        // GET: Danhmuc
        public ActionResult danhmucpartial()
        {
            var danhmuc = db.LoaiHangs.ToList();
            return PartialView(danhmuc);

        }

    }
}