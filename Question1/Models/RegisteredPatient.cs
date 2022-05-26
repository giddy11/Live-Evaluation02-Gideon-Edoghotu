

namespace Question1.Models
{
    public class RegisteredPatient : Patient
    {
        public RegisteredPatient()
        {
        }
        public RegisteredPatient(int id, int hospitalNumber, string fullName, Gender gender, string address, Hospital hospital) : base(id, hospitalNumber, fullName, gender, address, hospital)
        {
        }
    }
}
