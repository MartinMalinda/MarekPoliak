using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webshop.Models;
using System.Linq;

namespace Webshop.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Filter = Request.Query["filter"];
            model.Search = Request.Query["search"];
            if (model.Filter != null)
            {
                switch (model.Filter)
                {
                    case "cheap":
                        model.List = model.List.OrderBy(i => Convert.ToInt32(i.Attributes[2])).ToList();
                        break;
                    case "expensive":
                        model.List = model.List.OrderByDescending(i => Convert.ToInt32(i.Attributes[2])).ToList();
                        break;
                    case "available":
                        model.List = model.List.Where(i => Convert.ToInt32(i.Attributes[3]) > 0).ToList();
                        break;
                    case "nike":
                        model.List = model.List.Where(i => i.Attributes[0].ToLower().Contains("nike") || i.Attributes[1].ToLower().Contains("nike")).ToList();
                        break;
                }
            }
            if (model.Search != null)
            {
                model.List = model.List.Where(i => i.Attributes.Any(a => a.Contains(model.Search))).ToList();
            }
            return View(model);
        }
    }
}