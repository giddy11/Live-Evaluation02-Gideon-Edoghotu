using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class PatientMap : ClassMap<Patient>//ClassMap<T> where T : Patient
    {
        public PatientMap()
        {
            Id(x => x.Id);
            Map(x => x.HospitalNumber);
            Map(x => x.FullName);
            Map(x => x.Address);
            //References(x => x.Gender);
            References(x => x.Hospital);
        }
    }
}
