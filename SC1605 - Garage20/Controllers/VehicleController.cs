using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using SC1605___Garage20.Models;
using SC1605___Garage20.Repositories;

namespace SC1605___Garage20.Controllers
{
    public class VehicleController : Controller
    {
        private readonly VehicleRepository _vehicleRepository = new VehicleRepository();

        //// GET: Vehicle
        //public ActionResult Index()
        //{
        //    return View(_vehicleRepository.GetAll());
        //}

        // GET: Vehicle
        public ActionResult Index(IEnumerable<Vehicle> vehicles)
        {
            return View(vehicles ?? _vehicleRepository.GetAll());
        }

        // GET: Vehicle
        [HttpPost]
        public ActionResult Index(string SearchTerm)
        {
            var findings = _vehicleRepository.Find(SearchTerm);
            return findings == null ? View() : View(findings);
        }


        // GET: Vehicle/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var vehicle = _vehicleRepository.Get(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicle/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,Owner,RegistrationNumber,Color,NumberOfWheels,VehicleType,ParkedDate,EndParkedDate")] Vehicle vehicle)
        {
            if (!ModelState.IsValid) return View(vehicle);

            if (_vehicleRepository.Add(vehicle))
            {
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var vehicle = _vehicleRepository.Get(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,Owner,RegistrationNumber,Color,NumberOfWheels,VehicleType,ParkedDate,EndParkedDate")] Vehicle vehicle)
        {
            if (!ModelState.IsValid) return View(vehicle);

            if (_vehicleRepository.Edit(vehicle))
            {
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var vehicle = _vehicleRepository.Get(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (_vehicleRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _vehicleRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}