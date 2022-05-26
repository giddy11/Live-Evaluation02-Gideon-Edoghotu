

namespace Question1.Models
{
    public class Accountant : HospitalWorkers 
    {
        public Accountant()
        {
        }
        public Accountant(int id, string fullName, Hospital hospital) : base(id, fullName, hospital)
        {
        }
    }
}
