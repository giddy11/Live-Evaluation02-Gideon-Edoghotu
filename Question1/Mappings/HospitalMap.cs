using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class HospitalMap : ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.Doctors);
            HasMany(x => x.Nurses);
            HasMany(x => x.Pharmacists);
            HasMany(x => x.Patients);
            HasOne(x => x.Receptionist);
            HasOne(x => x.Accountant);
        }
    }
}
