using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppAzure.Models;
using WebAppAzure.Services;

namespace WebAppAzure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _proService;
        public List<Product> products;

        public IndexModel(IProductService proService)
        {
            _proService = proService;
        }

        public void OnGet()
        {
            products = _proService.GetProducts();
        }
    }
}
