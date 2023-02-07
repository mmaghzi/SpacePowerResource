using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace SpacePowerResource.Areas.Admin.Controllers
{
    public class FacilitiesController : Controller
    {

        private IFacilitiyRepository facilityRepository;
        public FacilitiesController()
        {
            facilityRepository = new FacilityRepository();
        }

        // GET: Admin/Facilities
        public ActionResult Index(string query)
        {
            var tmp = from item in facilityRepository.GetAllFacilities() select item;
            if (!string.IsNullOrEmpty(query))
            {
                tmp = tmp.Where(f => f.FacilityOwner.Contains(query) || f.CityName.Contains(query) || f.StationName.Contains(query) ||
                f.FacilityName.Contains(query) || f.CurrentKind.Contains(query)).Distinct();
            }
       
            return View(tmp);
        }

        // GET: Admin/Facilities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilities facilities = facilityRepository.GetFacilityById(id.Value);
            if (facilities == null)
            {
                return HttpNotFound();
            }
            return View(facilities);
        }

        // GET: Admin/Facilities/Create
        public ActionResult Create()
        {
        //    List<SelectListItem> listTechonolgies = new List<SelectListItem>()
        //{
        //        new SelectListItem()  { Text = ".Net", Value = "0"           },
        //        new SelectListItem()  {  Text = "Java", Value = "1"          },
        //        new SelectListItem()  {  Text = "Javascript", Value = "2"    },
        //        new SelectListItem()  {  Text = "Angular", Value = "3"       },
        //        new SelectListItem()  {  Text = "WCF", Value = "4"           }
        //};
        //    ViewBag.Techonolgie = listTechonolgies;
            return View();
        }

        // POST: Admin/Facilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacilityId,FacilityOwner,CityName,StationName,Geography,FacilityName,FcilityPosition,OccupiedArea,FuseValue,CurrentKind,CurrentValue,PowerSource,Comments")] Facilities facilities)
        {
            if (ModelState.IsValid)
            {
                facilityRepository.InsertFacility(facilities);
                facilityRepository.Save();
                return RedirectToAction("Index");
            }

            return View(facilities);
        }

        // GET: Admin/Facilities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilities facilities = facilityRepository.GetFacilityById(id.Value);
            if (facilities == null)
            {
                return HttpNotFound();
            }
            return View(facilities);
        }

        // POST: Admin/Facilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacilityId,FacilityOwner,CityName,StationName,Geography,FacilityName,FcilityPosition,OccupiedArea,CurrentKind,CurrentValue,PowerSource,Comments")] Facilities facilities)
        {
            if (ModelState.IsValid)
            {
                facilityRepository.UpdateFacility(facilities);
                facilityRepository.Save();
                return RedirectToAction("Index");
            }
            return View(facilities);
        }

        // GET: Admin/Facilities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilities facilities = facilityRepository.GetFacilityById(id.Value);
            if (facilities == null)
            {
                return HttpNotFound();
            }
            return View(facilities);
        }

        // POST: Admin/Facilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            facilityRepository.DeleteFacility(id);
            facilityRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                facilityRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
