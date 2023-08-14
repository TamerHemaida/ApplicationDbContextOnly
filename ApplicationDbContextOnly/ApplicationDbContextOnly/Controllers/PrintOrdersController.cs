using ApplicationDbContextOnly.Data;
using ApplicationDbContextOnly.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApplicationDbContextOnly.Controllers
{
    public class PrintOrdersController : Controller
    {
        private readonly ApplicationDbContext context;
        public PrintOrdersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Create(List<EnglishWord> model)
        {
            if (model is null || model.Count == 0)
            {
                model = new() { new EnglishWord { Id = 0, Word = "" } };
                return View(model);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Review(List<EnglishWord> model)
        {
            var content = new byte[model[0].Image.Length];
            string JsonFile = JsonConvert.SerializeObject(content);
            HttpContext.Session.SetString("JsonFile", JsonFile);
            return PartialView("_Words", model);
        }

        [HttpPost]
        public IActionResult SaveOrder(List<EnglishWord> model)
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult AddWord(List<EnglishWord> model)
        {
            string JsonWords = JsonConvert.SerializeObject(model);
            string JsonWordss = JsonConvert.SerializeObject(model);
            HttpContext.Session.SetString("JsonWords", JsonWords);
            return PartialView("_Words", model);
        }
    }
}
