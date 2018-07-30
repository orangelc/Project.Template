using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities;
using Project.Repositories.Management;

namespace Project.Infraestructure.Management
{
    public class StoreRepository : IStoreRepository
    {
        public Product Add(Product product)
        {
            return product;
        }

        public List<Product> List(Product product)
        {
            return new List<Product>
            {
                new Product{Id=1, Name="P001"},
                new Product{Id=2, Name="P002"},
                new Product{Id=3, Name="P003"},
                new Product{Id=4, Name="P004"},
                new Product{Id=5, Name="P005"}
            };
        }

        public Product Remove(Product product)
        {
            return product;
        }

        public Product Update(Product product)
        {
            return product;
        }
    }
}
