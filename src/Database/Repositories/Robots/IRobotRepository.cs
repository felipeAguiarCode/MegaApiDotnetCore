using System.Collections.Generic;
using Megaman.Models;

namespace Megaman.Database
{
    public interface IRobotRepository
    {
        bool SaveChanges();

        IEnumerable<Robot> GetAllRobots();
        
        Robot GetRobotById(int id);

        void AddRobot(Robot robot);
        
    }
}