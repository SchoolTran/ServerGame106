using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerGame106.Models;
using System.ComponentModel.DataAnnotations;

namespace ServerGame106.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<GameLevel> GameLevel { get; set; }

        public DbSet<Region> Region { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<LevelResult> LevelResult { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameLevel>().HasData(
                new GameLevel { LevelID = 1, title = "Cấp độ 1" },
                new GameLevel { LevelID = 2, title = "Cấp độ 2" },
                new GameLevel { LevelID = 3, title = "Cấp độ 3" }
            );

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionID = 1, Name = "Đồng bằng sông hồng" },
                new Region { RegionID = 2, Name = "Đồng bằng sông cuu long" }
             );
            modelBuilder.Entity<Question>().HasData(
            new Question
            {
                QuestionID = 1,
                ContentQuestion = "Câu hỏi 1",
                Answer = "Đáp án 1",
                Option1 = "Đáp án 1",
                Option2 = "Đáp án 2",
                Option3 = "Đáp án 3",
                Option4 = "Đáp án 4",
                LevelID = 1
            },
            new Question
            {
                QuestionID = 2,
                ContentQuestion = "Câu hỏi 2",
                Answer = "Đáp án 2",
                Option1 = "Đáp án 1",
                Option2 = "Đáp án 2",
                Option3 = "Đáp án 3",
                Option4 = "Đáp án 4",
                LevelID = 2
            }
            );
        }
    }
}
