namespace TaskDoctor.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
            public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; } = null!;

        public TimeOnly Time { get; set; }
        public DateTime Date{ get; set; }
    }
}
