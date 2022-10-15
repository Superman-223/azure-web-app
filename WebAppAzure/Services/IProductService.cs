using System.Collections.Generic;
using WebAppAzure.Models;

namespace WebAppAzure.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}