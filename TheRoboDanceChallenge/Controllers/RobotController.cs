using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheRoboDanceChallenge.Database;
using TheRoboDanceChallenge.Models;

namespace TheRoboDanceChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public RobotController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        [Route("getRobots")]
        public IEnumerable<Robot> GetRobots()
        {
            return _dataAccessProvider.GetRobots();
        }

        [HttpGet]
        [Route("getRobotById")]
        public ActionResult<Robot> GetRobotById(int id)
        {
            try
            {
                return _dataAccessProvider.GetRobotById(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpPost]
        [Route("createRobot")]
        public ActionResult<Robot> CreateRobot(string name, string powermove, int experience)
        {
            try
            {
                var robot = new Robot()
                {
                    Name = name,
                    Powermove = powermove,
                    Experience = experience,
                    OutOfOrder = false,
                    Avatar = "https://robohash.org/" + name.Replace(" ", "-") + ".png"
                };
                _dataAccessProvider.AddRobot(robot);
                return robot;
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpPatch]
        [Route("editRobot")]
        public ActionResult<Robot> EditRobot(Robot robot)
        {
            try
            {
                _dataAccessProvider.UpdateRobot(robot);
                return robot;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("battle")]
        public ActionResult<String> Battle(int id1, int id2)
        {
            try
            {
                var robot1 = _dataAccessProvider.GetRobotById(id1);
                var robot2 = _dataAccessProvider.GetRobotById(id2);

                var battleResult = robot1.Experience - robot2.Experience;

                if (battleResult == 0)
                {
                    return "Draw!";
                }

                if (battleResult > 0)
                {
                    return robot1.Name + " wins the battle!";
                }

                return robot2.Name + " wins the battle!";
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }     

        [HttpDelete]
        [Route("deleteRobot")]
        public IActionResult DeleteRobot(int id)
        {
            try
            {
                _dataAccessProvider.DeleteRobot(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }
    }
}
