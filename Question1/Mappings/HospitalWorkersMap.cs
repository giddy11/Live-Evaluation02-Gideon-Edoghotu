using FluentNHibernate.Mapping;
using Question1.Models;

namespace Question1.Mappings
{
    public class HospitalWorkersMap : EntityBaseMap<HospitalWorkers>
    {
        public HospitalWorkersMap()
        {
            References(x => x.Hospital);
        }
    }
}
