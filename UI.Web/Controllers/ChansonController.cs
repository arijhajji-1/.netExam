using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class ChansonController : Controller

    {
       IServiceArtiste ServiceArtiste;
        IServiceChanson serviceChanson;
        public ChansonController(IServiceArtiste ServiceArtiste, IServiceChanson serviceChanson)
        {
            this.serviceChanson = serviceChanson;
            this.ServiceArtiste = ServiceArtiste;
        }
        // GET: ChansonController
        public ActionResult Index()
        {
            return View(serviceChanson.GetMany().OrderBy(c => c.vueyt));

        }

        // GET: ChansonController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: ChansonController/Create
        public ActionResult Create()
        {
            ViewBag.artisteFK = new SelectList(ServiceArtiste.GetMany(), "artisteId", "nom");
            return View();
        }

        // POST: ChansonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(chanson collection)
        {
            try
            {
                serviceChanson.Add(collection);
                serviceChanson.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChansonController/Edit/5
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

        // GET: ChansonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChansonController/Delete/5
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
