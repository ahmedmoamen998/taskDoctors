using TaskDoctor.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskDoctor.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var doctors = new List<Doctor>
            {
            new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
            new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
            new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
             new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
            new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" },
            };
            modelBuilder.Entity<Doctor>().HasData(doctors);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
"Data Source=.\\NEWMSSQLSERVER;" +
     "Initial Catalog=FirstMvcTask;" +
     "Integrated Security=True;" +
     "TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
