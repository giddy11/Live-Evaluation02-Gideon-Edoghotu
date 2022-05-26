

namespace Question1.Models
{
    public class Doctor : HospitalWorkers
    {
        public Doctor(int id, string fullName, Hospital hospital) : base(id, fullName, hospital)
        {
        }
    }
}
