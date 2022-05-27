

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

        public virtual bool CheckIfRegistered(Patient patients)
        {
            if (Patients is RegisteredPatient)
                return true;
            else
            {
                Console.WriteLine("Patient has just been registered");
                return false;
            }
        }


        public virtual List<Patient> Patients { get; set; }
    }
}
