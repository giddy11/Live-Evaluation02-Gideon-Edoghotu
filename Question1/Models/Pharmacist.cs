

namespace Question1.Models
{
    public class Pharmacist : HospitalWorkers
    {
        public Pharmacist(int id, string fullName, Hospital hospital) : base(id, fullName, hospital)
        {
        }
    }
}
