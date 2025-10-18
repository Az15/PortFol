using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortFol.Controllers
{
    public class StackController : Controller
    {
        // GET: StackController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StackController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StackController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StackController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
