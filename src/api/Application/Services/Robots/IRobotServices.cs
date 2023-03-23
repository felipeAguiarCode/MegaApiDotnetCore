using System.Collections.Generic;
using Megaman.Dtos;
using Api.Domain.Entities;

namespace Api.App.Services
{
    public interface IRobotServices
    {
         IEnumerable<Robot> SearchAll();

        RobotReadDTO SearchById(int id);
         

    }
}