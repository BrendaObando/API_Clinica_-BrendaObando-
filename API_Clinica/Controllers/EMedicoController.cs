using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Clinica.Controllers
{
    public class EMedicoController : Controller
    {
        // GET: EMedicoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EMedicoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EMedicoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMedicoController/Create
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

        // GET: EMedicoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EMedicoController/Edit/5
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

        // GET: EMedicoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EMedicoController/Delete/5
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
