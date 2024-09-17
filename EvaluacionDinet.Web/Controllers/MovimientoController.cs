using EvaluacionDinet.EntidadA;
using EvaluacionDinet.NegocioA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvaluacionDinet.Web.Controllers
{
    public class MovimientoController : Controller
    {
        // GET: Movimiento
        public ActionResult Index()
        {
            var movimientoBL = new MovimientoBL();
            var filtro = new FiltroMovimientoBE();
            List<MovimientoBE> listaMovimiento = movimientoBL.Buscar(filtro);
            return View(listaMovimiento);
        }

        // GET: Movimiento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movimiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movimiento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movimiento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movimiento/Edit/5
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

        // GET: Movimiento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movimiento/Delete/5
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
