using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCurrencyConverter.Models;
using WebCurrencyConverter.Services;

namespace WebCurrencyConverter.Controllers
{
    [Route("/currency")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly CurrencyService _service;

        public CurrencyController(CurrencyService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IEnumerable<Currency> Get()
        {
            return _service.List();
        }
    }
}