using JobSearchA00222002.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchA00222002.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Context _context;


        public IndexModel(ILogger<IndexModel> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            ViewData["DecCount"] = _context.UserJobDescriptions.Count();
            ViewData["DecList"] = _context.UserJobDescriptions.Take(5).ToList();
        }
    }
}
