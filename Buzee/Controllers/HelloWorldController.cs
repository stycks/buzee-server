using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Buzee.Models;

namespace Buzee.Controllers
{
    public class HelloWorldController : ApiController
    {
        HelloWorld[] hellos = new HelloWorld[]
        {
            new HelloWorld { Id = 1, Name = "Tomato Soup" },
            new HelloWorld { Id = 2, Name = "Yo-yo" },
            new HelloWorld { Id = 3, Name = "Hammer" }
        };
        //a test

        public IEnumerable<HelloWorld> GetAllHellos()
        {
            return hellos;
        }

        public IHttpActionResult GetHellow(int id)
        {
            var hello = hellos.FirstOrDefault((p) => p.Id == id);
            if (hello == null)
            {
                return NotFound();
            }
            return Ok(hello);
        }
    }
}
