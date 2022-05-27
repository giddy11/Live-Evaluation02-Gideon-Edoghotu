using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class RegisteredPatientMap : EntityBaseMap<RegisteredPatient>
    {
        public RegisteredPatientMap()
        {
            Map(x => x.HospitalNumber);
            Map(x => x.Address);
            Map(x => x.Gender);
            References(x => x.Hospital);
        }
    }
}
