using FluentNHibernate.Mapping;
using Question1.Models.Appointment_Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Mappings
{
    public class PatientAppointmentMap : ClassMap<PatientAppointment>
    {
        public PatientAppointmentMap()
        {
            Id(x => x.Id);
            References(x => x.Hospital);
            References(x => x.Doctor);
            References(x => x.Patient);
            HasMany(x => x.Drugs);
            Map(x => x.AppointmentSchedule);
            References(x => x.Bill);
            Map(x => x.Prescription);
        }
    }
}
