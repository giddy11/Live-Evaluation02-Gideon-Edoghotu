using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Models
{
    public class Hospital
    {
        public Hospital()
        {
        }

        public Hospital(int id, string name, string address, Receptionist reception, Accountant accountant)
        {
            Id = id;
            Name = name;
            Address = address;
            Receptionist = reception;
            Accountant = accountant;
        }







        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
        public virtual List<Pharmacist> Pharmacists { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual Receptionist Receptionist { get; set; }
        public virtual Accountant Accountant { get; set; }

    }
}
