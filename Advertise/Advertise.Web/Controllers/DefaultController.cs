﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advertise.Web.Controllers
{
    public partial class DefaultController : Controller
    {
        // GET: Default
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}