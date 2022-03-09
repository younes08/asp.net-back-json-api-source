using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private DataContext dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext d)
        {
            dataContext = d;
            _logger = logger;
        }

        public void OnGet()
        {
            var livre = new Livre() { nom = "Livre test" };
            dataContext.Livres.Add(livre);
            dataContext.SaveChanges();
        }
    }
}
