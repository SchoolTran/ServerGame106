using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerGame106.Models
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        [Required]

        public string ContentQuestion { get; set; }
        [Required]

        public string Answer { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }
        [ForeignKey("Level")]

        public int LevelID { get; set; }

    }
}
