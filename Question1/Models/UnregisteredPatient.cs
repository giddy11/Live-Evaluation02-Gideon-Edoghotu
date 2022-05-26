

namespace Question1.Models
{
    public class UnregisteredPatient : Patient
    {
        public UnregisteredPatient()
        {
        }
        public UnregisteredPatient(int id, int hospitalNumber, string fullName, Gender gender, string address, Hospital hospital) : base(id, hospitalNumber, fullName, gender, address, hospital)
        {
        }
    }
}
