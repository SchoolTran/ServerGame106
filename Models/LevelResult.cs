using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerGame106.Models
{
    public class LevelResult
    {
        [Key]
        public int QuizResultID { get; set; }
        [ForeignKey("User")]

        public string UserID { get; set; }
        [ForeignKey("Level")]
        public int LevelID { get; set; }
        public int Score { get; set; }
        public DateOnly CompletionDate { get; set; }

    }
}
