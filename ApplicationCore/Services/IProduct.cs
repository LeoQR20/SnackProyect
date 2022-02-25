using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Models;

namespace ApplicationCore.Services
{
    interface IProduct
    {
        Product GetProduct(int ID);
        void DeleteProduct();
        Product Save(Product product);
    }
}
