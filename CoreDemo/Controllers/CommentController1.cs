﻿using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog()
        {
            return PartialView();
        }
    }
}
