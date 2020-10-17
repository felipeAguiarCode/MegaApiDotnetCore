using Megaman.Models;
using Microsoft.EntityFrameworkCore;

namespace Megaman.Database
{
    public class RobotsContext: DbContext
    {
        public RobotsContext(DbContextOptions<RobotsContext> options):base(options){

        }

        public DbSet<Robot> Robots { get; set; }

    }
}