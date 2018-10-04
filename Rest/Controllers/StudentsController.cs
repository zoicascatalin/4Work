using Microsoft.Ajax.Utilities;
using Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest.Controllers
{

    public class StudentsController : ApiController
    {
		public static List<Students> stdList = new List<Students>();
        // GET: api/Students
        public IEnumerable<Students> Get()
        {
			return stdList;
        }

        // POST: api/Students
        public void Post([FromBody]Students value)
        {
			stdList.Add(value);
        }

    }
}
