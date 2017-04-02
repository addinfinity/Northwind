using NorthwindApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NorthwindApi.Controllers
{
    [RoutePrefix("api/data")]
    public class ValuesController : ApiController
    {       

        // GET api/values
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1","value2"};
        }

        // GET api/data/categories
        [Route("categories")]
        [HttpGet]
        public IEnumerable<string> GetCategories()
        {
            NorthwindEntities context = new NorthwindEntities();

            return context.Categories.Select(c=>c.CategoryName);
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
