using Project.Application.Management;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IStoreApplication storeApplication;

        public ValuesController()
        {

        }

        public ValuesController(IStoreApplication storeApplication)
        {
            this.storeApplication = storeApplication;
        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", this.storeApplication.Add(new Product {Id=100, Name="PRUEBA DE ARQUITECTURA" }).Name };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
