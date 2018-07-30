using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities;

namespace Project.Repositories.Management
{
    public interface IStoreRepository
    {
        Product Add(Product product);
        Product Update(Product product);
        Product Remove(Product product);
        List<Product> List(Product product);
    }
}
