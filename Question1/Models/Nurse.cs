
namespace Question1.Models
{
    public class Nurse : HospitalWorkers
    {
        public Nurse(int id, string fullName, Hospital hospital) : base(id, fullName, hospital)
        {
        }
    }
}
