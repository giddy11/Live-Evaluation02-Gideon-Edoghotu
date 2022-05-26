using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class UnregisteredPatientMap : ClassMap<UnregisteredPatient>//PatientMap<UnregisteredPatient>
    {
        public UnregisteredPatientMap()
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
