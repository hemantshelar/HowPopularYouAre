using Framework;
using HowPopularYouAreUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HowPopularYouAreUI.Controllers
{
    public class PopularityFinderController : Controller
    {
        //Helper 
        private List<SelectListItem> GetProviderList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            int nIndex = 0;

            
            PopularityFinderProviders p = new PopularityFinderProviders();
            var listOfProviders = p.GetPopularityFinderProviders(false);
            foreach (var item in listOfProviders)
            {
                list.Add(new SelectListItem { Value = nIndex.ToString(), Text = item.DisplayName });
                nIndex++;
            }
            return list;
        }

        // GET: PopularityFinder
        public ActionResult Index()
        {
            PopularityFinderProvidersModel model = new PopularityFinderProvidersModel();
            model.SelectedID = -1;
            var result = GetProviderList();
            model.Providers = new SelectList(result, "Value", "Text");
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PopularityFinderProvidersModel model)
        {
            var result = GetProviderList();
            model.Providers = new SelectList(result, "Value", "Text");

            model.Result = "Please wait we are searching your result for provider : " + model.SelectedID.ToString();
            return View(model);

        }

        // GET: PopularityFinder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PopularityFinder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PopularityFinder/Create
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

        // GET: PopularityFinder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PopularityFinder/Edit/5
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

        // GET: PopularityFinder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PopularityFinder/Delete/5
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
