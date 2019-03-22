using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testDataAccess;

namespace TestWebservice.Controllers
{
    public class testsController : ApiController
    {
        public IEnumerable<site> Get()
        {
            using (sensordataEntities entities = new sensordataEntities())
            {
                return entities.sites.ToList();
            }
        }
    }
}
