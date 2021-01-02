using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCLearning.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCLearning.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentBLL _bll;

        public DepartmentsController(IDepartmentBLL bll)
        {
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
        }

        public IActionResult Index()
        {
            var departments = _bll.GetAll();
            return View(departments);
        }
    }
}
// Written from inside Ashok branch.