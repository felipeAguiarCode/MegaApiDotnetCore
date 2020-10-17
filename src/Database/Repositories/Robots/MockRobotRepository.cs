using System.Collections.Generic;
using Megaman.Models;

namespace Megaman.Database
{
    public class MockRobotRepository : IRobotRepository
    {
        public void AddRobot(Robot robot)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Robot> GetAllRobots()
        {
            var robots = new List<Robot>
            {
                new Robot{ 
                        Id =1,
                        Code = "DLN/DRN-003",
                        Name = "Cutman",
                        HP = 150,
                        Picture = "https://vignette.wikia.nocookie.net/megaman/images/2/22/Cutman.png"
                },
                new Robot{ 
                        Id =2,
                        Code = "112",
                        Name = "Gutman",
                        HP = 150,
                        Picture = ""
                },
                new Robot{ 
                        Id =2,
                        Code = "112",
                        Name = "Iceman",
                        HP = 150,
                        Picture = ""
                }
            };

            return robots;
        }

        public Robot GetRobotById(int id)
        {
            return new Robot{ 
                    Id =0,
                    Code = "112",
                    Name = "Cutman",
                    HP = 150,
                    Picture = "https://vignette.wikia.nocookie.net/megaman/images/2/22/Cutman.png"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }


}