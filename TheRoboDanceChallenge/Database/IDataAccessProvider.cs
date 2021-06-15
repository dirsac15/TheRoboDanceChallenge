using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRoboDanceChallenge.Models;

namespace TheRoboDanceChallenge.Database
{
    public interface IDataAccessProvider 
    {
        void AddRobot(Robot robot);
        void UpdateRobot(Robot robot);
        void DeleteRobot(int id);
        Robot GetRobotById(int id);
        List<Robot> GetRobots();
    }
}
