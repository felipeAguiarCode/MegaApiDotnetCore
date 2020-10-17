using System.Collections.Generic;
using Megaman.Dtos;
using Megaman.Models;

namespace Megaman.Services
{
    public interface IRobotServices
    {
         IEnumerable<Robot> SearchAll();

        RobotReadDTO SearchById(int id);
         

    }
}