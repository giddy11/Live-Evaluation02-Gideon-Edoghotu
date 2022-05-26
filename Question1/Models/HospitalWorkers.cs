

namespace Question1.Models
{
    public class HospitalWorkers
    {
        public HospitalWorkers()
        {
        }

        public HospitalWorkers(int id, string fullName, Hospital hospital)
        {
            Id = id;
            FullName = fullName;
            Hospital = hospital;
        }


        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
