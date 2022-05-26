using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class RegisteredPatientMap : ClassMap<RegisteredPatient>//PatientMap<RegisteredPatient>
    {
        public RegisteredPatientMap()
        {
            Id(x => x.Id);
            Map(x => x.HospitalNumber);
            Map(x => x.FullName);
            Map(x => x.Address);
            Map(x => x.Gender);
            References(x => x.Hospital);
        }
    }
}
