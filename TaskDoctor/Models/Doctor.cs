namespace TaskDoctor.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Img { get; set; }
        public virtual ICollection<Patient> Patients { get; } = new List<Patient>();
    }
}
