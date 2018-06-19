using Core.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebArchitecture.Controllers
{
    public class MathematicsController : Controller
    {
        private readonly IMathematicsService _MathematicsService;
        public MathematicsController(IMathematicsService MathematicsService)
        {
            _MathematicsService = MathematicsService;
        }



        // GET: Mathemeatics
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int num1, int num2)
        {
            var ans = _MathematicsService.Add(num1, num2);
            ViewBag.Ans= "Your answer is" + ans;
            return View("Index");
        }
    }
}