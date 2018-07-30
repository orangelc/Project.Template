using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Project.Application.Management;
using Project.Domain.Management;
using Project.Infraestructure.Management;
using Project.Repositories.Management;

namespace Project.Integration.Management
{
    public class StoreModule : NinjectModule
    {
        public override void Load()
        {
            RegisterBindings();
        }

        private void RegisterBindings()
        {
            Bind<IStoreApplication>().To<StoreApplication>();
            Bind<IStore>().To<Store>();
            Bind<IStoreRepository>().To<StoreRepository>();
        }
    }
}
