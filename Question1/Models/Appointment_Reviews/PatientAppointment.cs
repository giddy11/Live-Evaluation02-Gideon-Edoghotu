

using Question1.Models.Products;
using Question1.Repos.DBManager;

namespace Question1.Models.Appointment_Reviews
{
    public class PatientAppointment
    {   
        public PatientAppointment()
        {
        }

        public PatientAppointment(Patient patient, DateTime time, Doctor doctor, Hospital hospital)
        {
            Patient = patient;
            AppointmentSchedule = time;
            Doctor = doctor;
            Hospital = hospital;
        }

        public virtual void BookAppointment(Patient patient)
        {
            Receptionist receptionist = new Receptionist();
            if (receptionist.CheckIfRegistered(patient) is true)
            {
                BookSchedule(new DateTime(5), Doctor, Hospital);
            }
        }

        public virtual void BookSchedule(DateTime time, Doctor doctor, Hospital hospital)
        {
            PatientAppointment appointment = new PatientAppointment();

            appointment.BookSchedule(time, doctor, hospital);
            DataBaseManager<PatientAppointment>.AddItem(appointment);
        }

        public virtual void AdministerDrugs(string nameofdrug)
        {
            Prescription.Add(nameofdrug);
        }






        public virtual int Id { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual List<Drug> Drugs { get; set; }
        public virtual DateTime AppointmentSchedule { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual List<string> Prescription { get; set; }
    }
}
