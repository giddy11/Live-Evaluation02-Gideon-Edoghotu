using FluentNHibernate.Mapping;
using Question1.Models.Appointment_Reviews;

namespace Question1.Mappings
{
    public class BillMap : ClassMap<Bill>
    {
        public BillMap()
        {
            Id(x => x.Id);
            Map(x => x.TotalBills);
            References(x => x.Doctor);
            References(x => x.Patient);
            References(x => x.Hospital);
            Map(x => x.BillBreakdown);
        }
    }
}
