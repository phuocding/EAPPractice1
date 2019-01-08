using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAP_Exam.Data
{
    public class ExchangeAPIContext : DbContext
    {
        public ExchangeAPIContext(DbContextOptions<ExchangeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ExchangeRatio> ExchangeRatio { get; set; }
    }
}
