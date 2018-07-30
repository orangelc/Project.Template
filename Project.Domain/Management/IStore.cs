using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Management
{
    public interface IStore
    {
        Product Add(Product product);
        Product Update(Product product);
        Product Remove(Product product);
        List<Product> List(Product product);
    }
}
