using Question1.Models.Products;

namespace Question1.Mappings
{
    public class DrugMap : EntityBaseMap<Drug>
    {
        public DrugMap()
        {
            Map(x => x.Price);
            Map(x => x.CountOfPurchasedDrug);
            HasManyToMany(x => x.Pharmacists);
            HasManyToMany(x => x.Patients);
        }
    }
}
