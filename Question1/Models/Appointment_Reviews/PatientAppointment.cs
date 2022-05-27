

using Question1.Models.Products;

namespace Question1.Models.Appointment_Reviews
{
    public class PatientAppointment
    {
        //Receptionist receptionist = new Receptionist();
        //PatientAppointment appointment = new PatientAppointment();
        
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

        //public virtual void BookAppointment(Patient patient)
        //{
        //    if (receptionist.CheckIfRegistered(patient) is true)
        //    {
        //        BookSchedule(new DateTime(5), Doctor, Hospital); 
        //    }
        //}

        //public virtual void BookSchedule(DateTime time, Doctor doctor, Hospital hospital)
        //{
        //    appointment.BookSchedule(time, doctor, hospital);
        //}

        //public virtual void AdministerDrugs(string nameofdrug)
        //{
        //    Prescription.Add(nameofdrug);
        //}
        





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
