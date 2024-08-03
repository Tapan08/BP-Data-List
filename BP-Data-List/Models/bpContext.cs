using Microsoft.EntityFrameworkCore;

namespace TPAssignment_1.Models
{
    public class bpContext : DbContext
    {
        public bpContext(DbContextOptions<bpContext> options)
        : base(options)
        { }

        public DbSet<BP> BloodPressures { get; set; } = null!;

        public DbSet<Position> Position { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Position>().HasData(
                new Position { PositionId = "S", Name = "Standing" },
                new Position { PositionId = "S1", Name = "Siting" },
                new Position { PositionId = "L", Name = "Lying Down" }
                );

            modelBuilder.Entity<BP>().HasData(

                    new BP
                    {
                        Id = 1,
                        systolic = 120,
                        diastolicValues = 80,
                        PositionId = "S",
                        DateCreated = DateTime.UtcNow,

                    },



                    new BP
                    {
                        Id = 2,
                        systolic = 100,
                        diastolicValues = 60,
                        PositionId = "S1",
                        DateCreated = DateTime.UtcNow,



                    },



                    new BP
                    {
                        Id = 3,
                        systolic = 140,
                        diastolicValues = 100,
                        PositionId = "L",
                        DateCreated = DateTime.UtcNow,

                    }



                );
        }
    }
}
