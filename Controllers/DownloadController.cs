using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Core.Factory;
using TechnicalAnalysis.Models;

namespace TechnicalAnalysis.Controllers
{
    public class DownloadController : Controller
    {
        // GET: DownloadController
        public ActionResult Index()
        {
            return View();
        }
        static List<DigitalContractModel> _digitalContractModels()
        {
            return new List<DigitalContractModel> {
                DummyData.DummyDigitalContract(),
                DummyData.DummyDigitalContract(),
                DummyData.DummyDigitalContract(),
            };
        }

        public IActionResult Download()
        {
            return View(_digitalContractModels());
        }

        public IActionResult Details(int Id)
        {
            var contract = _digitalContractModels().FirstOrDefault(item => item.Id.Equals(Id));
            return View(contract);
        }

        // GET: DownloadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DownloadController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DownloadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DownloadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DownloadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DownloadController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
