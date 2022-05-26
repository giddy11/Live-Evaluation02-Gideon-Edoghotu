
namespace Question1.Models
{
    public abstract class Patient
    {
        public Patient()
        {
        }
        public Patient(int id, int hospitalNumber, string fullName, Gender gender, string address, Hospital hospital)
        {
            Id = id;
            HospitalNumber = hospitalNumber;
            FullName = fullName;
            Gender = gender;
            Address = address;
            Hospital = hospital;
        }

       

        public virtual int Id { get; set; }
        public virtual int HospitalNumber { get; set; }
        public virtual string FullName { get; set; }
        public virtual string Address { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}