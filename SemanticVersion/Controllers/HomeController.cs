using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SemanticVersion.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SemanticVersion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Return software list into view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(SoftwareManager.GetAllSoftware());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// TextBox search action
        /// </summary>
        /// <param name="searchModel">The search model object that uses</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Search(SoftwareSearchModel searchModel)
        {
            List<Software> softwareList = new List<Software>(SoftwareManager.GetAllSoftware());  //get the software list.

            searchModel.softwareList = getSoftwareList(searchModel.SearchText);  //get the software filtered based on search text

            return View("Index", searchModel);  //return to controller.
        }

        private List<Software> getSoftwareList(string searchText)
        {
            List<Software> softwareSearchResults = new List<Software>();

            return softwareSearchResults;
        }
    }
}
