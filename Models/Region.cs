using System.ComponentModel.DataAnnotations;

namespace ServerGame106.Models
{
    public class Region
    {
        public int RegionID { get; set; }
        [Required]

        public string Name { get; set; }
    }
}
