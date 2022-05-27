using Question1.Models;


namespace Question1.Mappings
{
    public class PharmacistMap : EntityBaseMap<Pharmacist>
    {
        public PharmacistMap()
        {
            References(x => x.Hospital);
            HasManyToMany(x => x.Drugs);
        }
    }
}
