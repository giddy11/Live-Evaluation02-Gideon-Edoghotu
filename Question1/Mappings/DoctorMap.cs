using Question1.Models;

namespace Question1.Mappings
{
    public class DoctorMap : EntityBaseMap<Doctor>
    {
        public DoctorMap()
        {
            References(x => x.Hospital);
        }
    }
}
