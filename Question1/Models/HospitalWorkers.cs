

using Question1.Repos.EntityBase;

namespace Question1.Models
{
    public class HospitalWorkers : EntityBase
    {
        public HospitalWorkers()
        {
        }

        public HospitalWorkers(int id, string name, Hospital hospital)
        {
            ID = id;
            Name = name;
            Hospital = hospital;
        }

        public virtual Hospital Hospital { get; set; }
    }
}
