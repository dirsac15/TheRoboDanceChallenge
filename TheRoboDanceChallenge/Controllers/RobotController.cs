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
