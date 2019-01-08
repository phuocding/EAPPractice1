using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP_Exam.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EAP_Exam.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExchangeAPIController : ControllerBase
    {
        private readonly ExchangeAPIContext _context;

        public ExchangeAPIController(ExchangeAPIContext context)
        {
            _context = context;
        }
        public IActionResult CurrencyIndex()
        {
            var currency = _context.ExchangeRatio.ToList();
            return new JsonResult(currency);
        }
    }
}
