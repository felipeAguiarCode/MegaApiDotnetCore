using System.Collections.Generic;
using System.Linq;
using Megaman.Models;

namespace Megaman.Database
{
    public class SqlRobotRepository : IRobotRepository
    {
        private readonly RobotsContext _context;

        public SqlRobotRepository(RobotsContext context)
        {
            _context = context;
        }

        public void AddRobot(Robot robot)
        {
           if(robot == null)
           {
             throw new System.ArgumentNullException(nameof(robot));
           }

           _context.Robots.Add(robot);
        }

        public IEnumerable<Robot> GetAllRobots()
        {
            return _context.Robots.ToList();
        }

        public Robot GetRobotById(int id)
        {
            return _context.Robots.FirstOrDefault( x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}