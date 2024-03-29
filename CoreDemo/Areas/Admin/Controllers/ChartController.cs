﻿using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname ="Altın",
                categorycount = 8
            });
            list.Add(new CategoryClass
            {
                categoryname = "Eurobond",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Nasdaq",
                categorycount = 8
            });
            list.Add(new CategoryClass
            {
                categoryname = "Kripto",
                categorycount = 15
            });
            list.Add(new CategoryClass
            {
                categoryname = "Borsa İstanbul",
                categorycount = 5
            });
            return Json(new { jsonlist = list });
        }
    }
}
