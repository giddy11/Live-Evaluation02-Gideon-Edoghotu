using Question1.Repos.EntityBase;

namespace Question1.Models
{
    public abstract class Patient : EntityBase
    {
        public Patient()
        {
        }
        public Patient(int id, int hospitalNumber, string name, Gender gender, string address, Hospital hospital)
        {
            ID = id;
            HospitalNumber = hospitalNumber;
            Name = name;
            Gender = gender;
            Address = address;
            Hospital = hospital;
        }

       
        public virtual int HospitalNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}