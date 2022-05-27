

namespace Question1.Models
{
    public class Accountant : HospitalWorkers 
    {
        public Accountant()
        {
        }
        public Accountant(int id, string name, Hospital hospital) : base(id, name, hospital)
        {
        }
    }
}
