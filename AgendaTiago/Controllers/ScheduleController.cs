using AgendaTiago.Business;
using AgendaTiago.Database;
using AgendaTiago.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaTiago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleLogic _logic;

        public ScheduleController(IScheduleLogic logic)
        {
            _logic = logic;
        }
        
        // GET: api/<SheduleController>
        [HttpGet]
        public IEnumerable<Schedule> GetAllPerson()
        {
            try
            {
                return _logic.GetAllPeople();
            }
            catch { throw; }
        }

        // POST api/<SheduleController>
        [HttpPost]
        public IActionResult AddNewPerson([FromBody]Schedule person)
        {
            try
            {
                _logic.AddPerson(person);
                return Ok();
            }
            catch { throw; }
        }

        // PUT api/<SheduleController>/5
        [HttpPut]
        public IActionResult Put([FromBody]Schedule person)
        {
            try
            {
                _logic.UpdatePerson(person);
                return Ok();
            }
            catch { throw; }
        }

        // DELETE api/<SheduleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Not a valid person id");

                _logic.DeletePerson(id);

                return Ok();
            }
            catch { throw; }
        }
    }
}
