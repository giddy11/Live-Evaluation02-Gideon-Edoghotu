using Question1.Models;

namespace Question1.Mappings
{
    public class ReceptionistMap : EntityBaseMap<Receptionist>
    {
        public ReceptionistMap()
        {
            References(x => x.Hospital);
            HasMany(x => x.Patients);
           
        }
    }
}

