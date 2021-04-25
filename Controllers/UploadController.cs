using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAnalysis.Models;

namespace TechnicalAnalysis.Controllers
{
    public class UploadController : Controller
    {
        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }


        //
        [HttpPost]
        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            return Ok();
        }
    }
}
