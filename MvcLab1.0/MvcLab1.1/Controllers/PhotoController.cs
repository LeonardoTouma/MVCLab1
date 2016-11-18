using MvcLab1._1.Models;
using System.IO;
using System.Web.Mvc;

namespace MvcLab1._1.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Photo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Photo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Photo/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(Photo photo)
        {
            try
            {
                foreach (var file in photo.Files)
                {
                    if (file.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Content/Images"), filename);
                        file.SaveAs(path);
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Photo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Photo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Photo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Photo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
