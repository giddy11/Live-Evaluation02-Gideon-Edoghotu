

namespace Question1.Models
{
    public  class Pharmacist : HospitalWorkers
    {
        public Pharmacist()
        {
        }
        public Pharmacist(int id, string name, Hospital hospital) : base(id, name, hospital)
        {
        }
    }
}
