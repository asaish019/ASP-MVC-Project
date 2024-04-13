using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application_MVC_Form.Models;

namespace Application_MVC_Form.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult HomePage()
        {
            return View(); 
         
        }

        [HttpPost] //Displays submitted data 
        public ActionResult FormData(Form form)
        {
            if (ModelState.IsValid)
            {
                
                return View(form);
            }

            // Return To HomePage
            return RedirectToAction("HomePage");
        }
    }
}