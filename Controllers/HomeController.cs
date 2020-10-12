using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using dotnet_technical_test.Controllers.Utility;
using dotnet_technical_test.Models;
using dotnet_technical_test.Models.Constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace dotnet_technical_test.Controllers
{
    /// <summary>
    /// A controller had to be created as the stub project
    /// followed the MVC pattern. Therefore the Home folder
    /// has been renamed to Views and slightly re-organised.
    /// Startup.cs had to be amended to map the controllers
    /// and endpoints.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        /// Executes a get request to the ExchangeRate API.
        /// </summary>
        /// <param name="currency">The request payload passed in by the client.</param>
        /// <returns>A double representing the conversion result.</returns>
        public object GetCurrency(Currency currency)
        {
            // Get result from exchangerate API (docs here https://www.exchangerate-api.com/docs/c-sharp-currency-api).
            try
            {
                // Prepare the URl.
                string URLString = $"https://v6.exchangerate-api.com/v6/{DotNetConstants.EXCHANGE_RATE_API_KEY}/latest/{currency.SourceCurrency}";
                using var webClient = new WebClient();
                // Get the json result from the API.
                var json = webClient.DownloadString(URLString);

                // Convert it into the ExchangeResult object using NewtonSoft.
                ExchangeResult result = JsonConvert.DeserializeObject<ExchangeResult>(json);

                // Compute the conversion and return the result.
                return ExchangeUtility.Convert(currency, result);
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
