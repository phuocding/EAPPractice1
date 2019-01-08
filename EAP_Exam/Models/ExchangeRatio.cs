using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EAP_Exam.Data
{
    public class ExchangeRatio
    {
        [Key]
        public string Id { get; set; }
        public float Ratio { get; set; }
    }
}
