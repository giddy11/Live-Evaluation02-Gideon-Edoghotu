

namespace Question1.Models
{
    public class Receptionist : HospitalWorkers 
    {
        public Receptionist()
        {
        }
        public Receptionist(int id, string fullName, Hospital hospital) : base(id, fullName, hospital)
        {
        }
    }
}
