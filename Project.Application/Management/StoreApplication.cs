using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Management;
using Project.Entities;

namespace Project.Application.Management
{
    public class StoreApplication : IStoreApplication
    {
        private readonly IStore _store;

        public StoreApplication(IStore store)
        {
            this._store = store;
        }

        public Product Add(Product product)
        {
            return this._store.Add(product);
        }

        public List<Product> List(Product product)
        {
            return this._store.List(product);
        }

        public Product Remove(Product product)
        {
            return this._store.Remove(product);
        }

        public Product Update(Product product)
        {
            return this._store.Update(product);
        }
    }
}
