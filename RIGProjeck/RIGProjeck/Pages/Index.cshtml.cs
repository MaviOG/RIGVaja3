using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using RIGProjeck.Class;
using System.Collections.Generic;

namespace RIGProjeck.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;



        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Username { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
