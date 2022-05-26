

namespace Question1.Models
{
    public class HospitalWorkers
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
