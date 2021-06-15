using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRoboDanceChallenge.Models;

namespace TheRoboDanceChallenge.Database
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly DatabaseContext _context;

        public DataAccessProvider(DatabaseContext context)
        {
            _context = context;
        }

        public void AddRobot(Robot robot)
        {
            _context.Robots.Add(robot);
            _context.SaveChanges();
        }

        public void DeleteRobot(int id)
        {
            var entry = _context.Robots.First(r => r.Id == id);
            _context.Robots.Remove(entry);
            _context.SaveChanges();
        }

        public Robot GetRobotById(int id)
        {
            return _context.Robots.First(r => r.Id == id);
        }

        public List<Robot> GetRobots()
        {
            return _context.Robots.ToList();
        }

        public void UpdateRobot(Robot robot)
        {
            _context.Robots.Update(robot);
            _context.SaveChanges();
        }
    }
}
