﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Archery.Models;

namespace Archery.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
			ViewBag.Nom = "Toto";
			ViewData["Nom"] = "Toto";
			ViewData["Title"] = "Accueil";
			TempData["Erreur"] = "Il y a un Erreur";
			TempData["Success"] = "Action Success";
            return View();
        }
		
		[Route ("a-propos")]			//Pour marcher le chemin comme localhoste:(58482/a-propos
		public ActionResult About()
		{
			var info = new Info()
			{
			DevName = "Gtm",
			ContactMail="Gtm@gmail.com",
			CreatedDate= DateTime.Now			
			};			
			return View(info);
		}
    }

}