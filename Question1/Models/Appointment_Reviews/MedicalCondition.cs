

namespace Question1.Models.Appointment_Reviews
{
    public class MedicalCondition
    {
        public MedicalCondition()
        {
        }

        public MedicalCondition(string name, Patient patient)
        {
            Name = name;
            Patient = patient;
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
