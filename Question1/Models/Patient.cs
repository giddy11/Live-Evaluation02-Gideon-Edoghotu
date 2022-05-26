
namespace Question1.Models
{
    public abstract class Patient
    {
        


       

        public virtual int Id { get; set; }
        public virtual int HospitalNumber { get; set; }
        public virtual string FullName { get; set; }
        public virtual string Address { get; set; }
        //public virtual Gender Gender { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}