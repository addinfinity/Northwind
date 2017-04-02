﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthwindApi.Models;

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

        // GET api/values
        [Route("categories")]
        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            NorthwindEntities context = new NorthwindEntities();

            return context.Categories;
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