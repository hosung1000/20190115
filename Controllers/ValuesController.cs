using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Test;

namespace _20190115.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //Class1 c1 = new Class1();
            Database db = new Database();

//dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.13 설치 필요
            
            MySqlConnection conn = db.GetConnection();
            
            if(conn == null)
            {
                Console.WriteLine("conn == null");
            }
            else
            {
                Console.WriteLine("접속 성공");
            }
            
            
            Console.WriteLine("===========================");
            //Console.WriteLine(c1.GetInt());
            Console.WriteLine("===========================");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
