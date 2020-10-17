using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Megaman.Models
{
    [Table("tblRobots")]
    public class Robot
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }
        
        public int HP { get; set; }
        
        [MaxLength(200)]
        public string Picture { get; set; }
    }
}