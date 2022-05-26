using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class HospitalWorkersMap<T> : ClassMap<T> where T : HospitalWorkers
    {
        public HospitalWorkersMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            References(x => x.Hospital);
        }
    }
}
