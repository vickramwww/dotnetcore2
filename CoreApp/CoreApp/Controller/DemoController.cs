﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreApp.Controllers
{
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public IActionResult Get([FromQuery]int id,string query)
        {
            return new OkObjectResult(new Demo { Id = id, Text = "demo" + id });
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Demo value)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { id = value.Id, value });

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string val)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class Demo
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string Text { get; set; }
    }
}
