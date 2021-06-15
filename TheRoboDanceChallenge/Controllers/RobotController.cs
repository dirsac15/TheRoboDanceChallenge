using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheRoboDanceChallenge.Models;

namespace TheRoboDanceChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotController : ControllerBase
    {
        [HttpGet]
        [Route("getRobots")]
        public IEnumerable<Robot> GetRobots()
        {
            return (IEnumerable<Robot>)Ok();
        }

        [HttpGet]
        [Route("getRobotById")]
        public IEnumerable<Robot> GetRobotById(int id)
        {
            return (IEnumerable<Robot>)Ok();
        }

        [HttpPost]
        [Route("createRobot")]
        public IEnumerable<Robot> CreateRobot(string name, string powermove, int experience)
        {
            return (IEnumerable<Robot>)Ok();
        }

        [HttpPost]
        [Route("editRobot")]
        public IEnumerable<Robot> EditRobot(int id)
        {
            return (IEnumerable<Robot>)Ok();
        }
    }
}
