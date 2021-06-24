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
    public class ConfigDebugController : Controller
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private IConfigurationRoot _configRoot;

        public ConfigDebugController(ILogger<ConfigDebugController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _configRoot = (IConfigurationRoot)configuration;
        }

        public IActionResult ReadAll()
        {
            return View();
        }

        public IActionResult Providers()
        {
            List<string> providers = new List<string>();
            foreach (var provider in _configRoot.Providers.ToList())
            {
                providers.Add(provider.ToString());
            }
            return View(providers);
        }
    }
}
