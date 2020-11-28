using MemberConsolePostbackAPI.Models;
using MemberConsolePostbackAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MemberConsolePostbackAPI.Controllers
{
    [RoutePrefix("api/moda")]
    public class ModaController : ApiController
    {
        private readonly IModaRepository modaRepository;

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create([FromBody]DataModel value)
        {
            try
            {
                bool statusValue = modaRepository.Insert(value);
                return Ok(statusValue);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPatch]
        [Route("{id:int}")]
        public IHttpActionResult Patch(int memberId, [FromBody]string value)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int memberId)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Update(int id, [FromBody] DataModel houseDto)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
