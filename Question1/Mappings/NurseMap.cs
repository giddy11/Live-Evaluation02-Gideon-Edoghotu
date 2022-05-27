using Question1.Models;

namespace Question1.Mappings
{
    public class NurseMap : EntityBaseMap<Nurse>
    {
        public NurseMap()
        {
            References(x => x.Hospital);
        }
    }
}
