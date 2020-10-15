using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abastraction
{
    public interface IProductService
    {
        Task AddProduct(Product product);
    }
}
