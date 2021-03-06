﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC5WinAuth.Controllers
{
    public class HomeController : baseController
    {
        /// <summary>
        /// Home page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            string ret = System.Web.HttpContext.Current?.User?.Identity?.Name;
            if (string.IsNullOrEmpty(ret))
            {
                ret = "No User Found";
            }
            Models.UserDTO mdl = new Models.UserDTO() { UserName = ret };
            return View("Index", mdl);
        }
    }
}