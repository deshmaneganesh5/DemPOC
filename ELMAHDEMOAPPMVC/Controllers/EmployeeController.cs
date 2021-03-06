﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ELMAHDEMOAPPMVC.Models;

namespace ELMAHDEMOAPPMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDB objEmpDB = new EmployeeDB();
            ModelState.Clear(); 
            return View(objEmpDB.getAllEmployees());
        }

        // GET: Employee/Details/5
        
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Employee/Create
        //[HttpPost]
        public ActionResult CreateNew(tblEmployee objEmpModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeDB objEmpDB = new EmployeeDB();

                    if(objEmpDB.addEmployees(objEmpModel))
                    {
                        ViewBag.Message = "Added successfully";
                        ModelState.Clear();
                    }

                   
                }

                return View();

            }

            catch(Exception ex)
            {
                ViewBag.Message = "Not Added successfully";
                return View();
            }

           
          

            
        }

        //// POST: Employee/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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

        public ActionResult validator()
        {

            return View();
        }
    }
}
