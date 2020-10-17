using System.Collections.Generic;
using Megaman.Dtos;
using Megaman.Services;
using Microsoft.AspNetCore.Mvc;

namespace Megaman.Controllers
{
    //api/v1/robots
    [ApiController]
    [Route("api/v1/robots")]
    public class RobotsController : ControllerBase
    {
        private readonly IRobotServices _services;
        public RobotsController(IRobotServices services)
        {
           _services = services;
        }

        //GET api/robots
        [HttpGet] 
        public ActionResult<IEnumerable<RobotReadDTO>> GetAllRobots()
        {
            var robotItems = _services.SearchAll();
            return Ok(robotItems);
        }

        //GET api/v1/robots/{id}
        [HttpGet]
        [Route("{id:int}")]
        public object GetCommandById([FromRoute]int id)
        {   
            var robot = _services.SearchById(id);

            if(robot != null)
                return Ok(robot);
            
                return NotFound( 
                        new { message = "Nenhum robo encontrado" }
                );
        }

        //POST api/v1/robots
        [HttpPost]
        public ActionResult RobotSend(){
            return Ok();
        }


    }
}