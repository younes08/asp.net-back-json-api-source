using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Livre
    {
        public int LivreID { get; set; }
        public String nom { get; set; }
        public double price { get; set; }
        public String urlImg { get; set; }
    }
}
