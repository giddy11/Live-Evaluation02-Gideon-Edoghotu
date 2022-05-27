

namespace Question1.Models
{
    public class Receptionist : HospitalWorkers 
    {
        public Receptionist()
        {
        }
        public Receptionist(int id, string name, Hospital hospital) : base(id, name, hospital)
        {
        }
    }
}
