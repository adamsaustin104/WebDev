using System.Collections.Generic;
using CraftsDemo.WebSite.Models;
using CraftsDemo.WebSite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CraftsDemo.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService _jsonFileProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            _jsonFileProductService = productService;
        }

        public void OnGet()
        {
            Products = _jsonFileProductService.GetProducts();
        }
    }
}
