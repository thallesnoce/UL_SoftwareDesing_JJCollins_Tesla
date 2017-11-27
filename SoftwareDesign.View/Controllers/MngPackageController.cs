﻿using SoftwareDesign.ControllerLayer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SoftwareDesign.View.Controllers
{
    public class MngPackageController : Controller
    {
        /*
         * TN: Monica, You didnt create the pages to handle the Create/Update. You should create that for your use case.
         * 
         * As I mentioned in the email, try to use Scaffolding using the model PackageEntity
         * https://www.google.ie/search?q=scaffolding+mvc+example&oq=scaffolding+mvc&aqs=chrome.3.69i57j0l5.15013j0j7&sourceid=chrome&ie=UTF-8
         */
        // GET: MngPackage
        public ActionResult Index()
        {
            var managePackage = new ManagePackageBusinessLayer();
            var packages = managePackage.ListPackage();
            return View(packages);
        }

        // GET: MngPackage/Details/5
        public ActionResult Details(int packageId)
        {
            var package = new PackageBusinessLayer();
            package.ViewPackage(packageId);
            return View(package);
        }

        // GET: MngPackage/Create
        public ActionResult Create()
        {
            return View();
        }

        /*
         TN: You did right in call insertPackage.
         but the return should be Return View("Index")
         so, after create the package the user will be sent back to the first page with the list of packages
             */
        // POST: MngPackage/Create
        [HttpPost]
        public ActionResult Create(string Name, int PackageId, string Description, int Price, DateTime startDate, DateTime endDate)
        {
            var managePackage = new ManagePackageBusinessLayer();
            managePackage.AddPackage(Name, PackageId, Description, Price, startDate, endDate);
            return View("Index");
        }

        // GET: MngPackage/Edit/5
        public ActionResult Edit(string Name, int PackageId, string Description, int Price, DateTime startDate, DateTime endDate)
        {
            var managePackage = new ManagePackageBusinessLayer();
            managePackage.AddPackage(Name, PackageId, Description, Price, startDate, endDate);


            return View("Index");
        }
        /*
         * The EditPackage in businesslayer should be void.
         * The Return should be Return View("Index")
         */
        // POST: MngPackage/Edit/5
        [HttpPost]
        public ActionResult EditPackage(int PackageId)
        {

            return View();
        }

        // GET: MngPackage/Delete/5
        public ActionResult Delete(int packageId)
        {
            var managePackage = new ManagePackageBusinessLayer();
            managePackage.DeletePackage(packageId);

            var packages = managePackage.ListPackage();
            return View("Index", packages);
        }
    }
}
