using ApplicationDbContextOnly.Data;
using ApplicationDbContextOnly.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace ApplicationDbContextOnly.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {

            return View(GetEmployeeViewModels(t => t.Email != "ds@c.com"));
        }

        #region Words
        public IActionResult GetTime()
        {
            return new PartialViewResult
            {
                ViewName = "_HelloWorldPartial",
                ViewData = this.ViewData
            };
        }

        public IActionResult Words()
        {
            return View(context.EnglishWords.Where(c => c.DifficultyLevel.Contains("E")).Take(10).ToList());
        }

        [HttpPost]
        public IActionResult SearchWords(string word)
        {
            var result = context.EnglishWords.Where(c => c.Word.Contains(word)).ToList();
            return PartialView("_ResultWords", result);
        }


        [HttpPost]
        public IActionResult ChangeDifficultyLevel(int wordId, string DifficultyLevel)
        {
            var word = context.EnglishWords.Where(c => c.Id == wordId).FirstOrDefault();
            if (word is null)
                return BadRequest();

            word.DifficultyLevel = DifficultyLevel;

            if (context.SaveChanges() == 1)
                return Ok(word);

            return BadRequest(word);
        }
        #endregion

        public IActionResult Privacy()
        {
            string list = HttpContext.Session.GetString("JsonFile");
            if (list == null)
            {
                return RedirectToAction("Index", "PrintOrders");
            }
            List<EnglishWord> model = JsonConvert.DeserializeObject<List<EnglishWord>>(list);
            if (model is null)
            {
                model = new List<EnglishWord>();
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<PrintOrderModelView> GetEmployeeViewModels(Expression<Func<PrintOrderModelView, bool>> filter)
        {
            var employeeViewModel = context.Users
                .Join(
                context.Employees,
                user => user.Id,
                emp => emp.UserId,
                (user, emp) => new
                {
                    emp.UserId,
                    user.Email,
                    emp.EmployeeId,
                    emp.EmployeeName,
                    emp.Mobile,
                    emp.IsDepartmentManager,
                    emp.MajorId,
                    emp.JobId,
                    emp.DepartmentId,
                })
                .Join(
                context.Departments,
                emp => emp.DepartmentId,
                dept => dept.DepartmentId,
                (emp, dept) => new
                {
                    emp.UserId,
                    emp.Email,
                    emp.EmployeeId,
                    emp.EmployeeName,
                    emp.Mobile,
                    emp.IsDepartmentManager,
                    emp.MajorId,
                    emp.JobId,
                    dept.Gender,
                    dept.EducationPath,
                    dept.Complex,
                    dept.Stage,
                    dept.DepartmentName
                })

                .Join(
                context.Majors,
                emp => emp.MajorId,
                major => major.MajorId,
                (emp, major) => new
                {
                    emp.UserId,
                    emp.Email,
                    emp.EmployeeId,
                    emp.EmployeeName,
                    emp.Mobile,
                    emp.IsDepartmentManager,
                    emp.JobId,
                    emp.Gender,
                    emp.EducationPath,
                    emp.Complex,
                    emp.Stage,
                    emp.DepartmentName,
                    major.MajorArName
                })
                .Join(
                context.Jobs,
                emp => emp.JobId,
                job => job.JobId,
                (emp, job) => new
                {
                    emp.UserId,
                    emp.Email,
                    emp.EmployeeId,
                    emp.EmployeeName,
                    emp.Mobile,
                    emp.IsDepartmentManager,
                    emp.JobId,
                    emp.Gender,
                    emp.EducationPath,
                    emp.Complex,
                    emp.Stage,
                    emp.DepartmentName,
                    emp.MajorArName,
                    job.JobArName
                })
                 .Join(
                context.PrintOrders,
                emp => emp.EmployeeId,
                printOrders => printOrders.EmployeeId,
                (emp, printOrders) => new
                {
                    emp.UserId,
                    emp.Email,
                    emp.EmployeeId,
                    emp.EmployeeName,
                    emp.Mobile,
                    emp.IsDepartmentManager,
                    emp.Gender,
                    emp.EducationPath,
                    emp.Complex,
                    emp.Stage,
                    emp.DepartmentName,
                    emp.MajorArName,
                    printOrders.PhotoCopyCenterId,
                    printOrders.PrintOrderName,
                    printOrders.OrderRegisterDate,
                    printOrders.PageSize,
                    printOrders.DepartmentManagerDecision,
                    printOrders.DepartmentManagerLastActionDate
                })
                 .Join(
                context.PhotoCopyCenters,
                printOrders => printOrders.PhotoCopyCenterId,
                photoCopyCenters => photoCopyCenters.PhotoCopyCenterId,
                (printOrders, photoCopyCenters) => new PrintOrderModelView()
                {
                    Id = printOrders.UserId,
                    Email = printOrders.Email,
                    Mobile = printOrders.Mobile,
                    Name = printOrders.EmployeeName,
                    //printOrders.EmployeeId,
                    //printOrders.IsDepartmentManager,
                    //printOrders.Gender,
                    //printOrders.EducationPath,
                    Complex = printOrders.Complex,
                    Stage = printOrders.Stage,
                    //printOrders.DepartmentName,
                    //printOrders.MajorArName,
                    //printOrders.PhotoCopyCenterId,
                    //printOrders.PrintOrderName,
                    //printOrders.OrderRegisterDate,
                    //printOrders.PageSize,
                    //printOrders.DepartmentManagerDecision,
                    //printOrders.DepartmentManagerLastActionDate,
                    //photoCopyCentersUserId = photoCopyCenters.UserId,
                    //photoCopyCenters.Name,
                    //photoCopyCenters.Address
                }).Where(filter).ToList();

            //var result = context.PrintOrderModelView.FromSqlRaw("GetAll").ToList();
            return employeeViewModel;
            //return result;
        }
    }
}
