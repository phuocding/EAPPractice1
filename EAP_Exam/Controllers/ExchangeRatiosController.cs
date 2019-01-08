using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EAP_Exam.Data;

namespace EAP_Exam.Controllers
{
    public class ExchangeRatiosController : Controller
    {
        private readonly ExchangeAPIContext _context;

        public ExchangeRatiosController(ExchangeAPIContext context)
        {
            _context = context;
        }

        // GET: ExchangeRatios
        public IActionResult Index()
        {
            return View();

        }
    }
}
