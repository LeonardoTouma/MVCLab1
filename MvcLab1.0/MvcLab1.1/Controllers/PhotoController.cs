using MvcLab1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLab1._1.Controllers
{
    public class PhotoController : Controller
    {
        public static List<Photo> photolist = new List<Photo>();

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply(HttpPostedFileBase file, FormCollection form)
        {
            var filename = Guid.NewGuid().ToString() + file.FileName;
            var path = Server.MapPath("~/Content/Images" + filename);
            file.SaveAs(path);


            Photo photo = new Photo()
            {
                Path = path,
                Photoname = form["Photoname"],
                DatePosted = DateTime.Now,
                Description = form["Description"],

            };
            photolist.Add(photo);
            return View();
        }

        [HttpPost]
        public ActionResult ShowGallary()
        {
            return View(photolist);
        }
        public ActionResult Delete(Guid id)
        {
            var photo = photolist.Single(x => x.Id == id);
            photolist.Remove(photo);
            return RedirectToAction("ShowGallary", "Photo");
        }

    }
}
