
namespace Question1.Models
{
    public class Nurse : HospitalWorkers
    {
        public Nurse()
        {

        }
        public Nurse(int id, string name, Hospital hospital) : base(id, name, hospital)
        {
        }
    }
}
