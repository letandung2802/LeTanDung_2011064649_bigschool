using LeTanDung_2011064649_bigschool.Models;
using LeTanDung_2011064649_bigschool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeTanDung_2011064649_bigschool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dpcontext;
        public CoursesController()
        { 
            _dpcontext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dpcontext.categories.ToList()
            };
            return View(viewModel);
        }
    }
}