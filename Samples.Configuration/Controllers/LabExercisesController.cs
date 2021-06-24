using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Samples.Configuration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Configuration.Controllers
{
    public class LabExercisesController : Controller
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;

        public LabExercisesController(ILogger<ConfigDebugController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult ConfigAccessInView()
        {
            return View();
        }

        public IActionResult ConfigAccessInController()
        {
            LabExerciseViewModel model = new LabExerciseViewModel();

            //TODO: populate model with environment message from configuration


            return View(model);
        }

    }
}
