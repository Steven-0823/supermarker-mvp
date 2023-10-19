using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Models
{
    internal interface IProductRepository
    {
        void add(ProductModel productModel);
        void Edit(ProductModel productModel);
        void delete(ProductModel productModel);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValvue(string value);
    }
}
