using System.Collections.Generic;
using Megaman.Database;
using Megaman.Dtos;
using Megaman.Models;
using Microsoft.AspNetCore.Mvc;


namespace Megaman.Services
{
    public class RobotServices : IRobotServices
    {
        private readonly IRobotRepository _repository;

        public RobotServices(IRobotRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Robot> SearchAll(){
            return _repository.GetAllRobots();
        }

        public RobotReadDTO SearchById(int id){

            var robot = _repository.GetRobotById(id);
            RobotReadDTO robotDTO = null;

            if (robot != null){

                robotDTO = new RobotReadDTO(){
                    Id = robot.Id,
                    Code = robot.Code,
                    HP = robot.HP,
                    Name = robot.Name,
                    Picture = robot.Picture
                };

            }

            return robotDTO;

        }

    }
}