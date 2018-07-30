using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities;
using Project.Repositories.Management;

namespace Project.Domain.Management
{
    public class Store : IStore
    {
        private readonly IStoreRepository _store;

        public Store(IStoreRepository store)
        {
            this._store = store;
        }

        public Product Add(Product product)
        {
            return _store.Add(product);
        }

        public List<Product> List(Product product)
        {
            return _store.List(product);
        }

        public Product Remove(Product product)
        {
            return _store.Remove(product);
        }

        public Product Update(Product product)
        {
            return _store.Update(product);
        }
    }
}
