using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n00000001Assignment1.Controllers
{
    public class TimesTenController : ApiController
    {

        //GET api/TimesTen/4 --> 40
        public int Get(int id)
        {
            int product = id * 10;
            return product;
        }

        //POST api/TimesTen --> "Secret POST method"
        public string Post()
        {

            return "Secret POST method!";
        }

    }
}
