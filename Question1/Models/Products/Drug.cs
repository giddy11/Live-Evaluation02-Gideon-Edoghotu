using Question1.Repos.EntityBase;


namespace Question1.Models.Products
{
    public class Drug : EntityBase
    {
        public Drug()
        {
        }
        public Drug(int id, string name, int price, Pharmacist pharmacists)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public virtual void DrugPurchased(Patient patient)
        {
            CountOfPurchasedDrug++;
        }

        public virtual int Price { get; set; }
        public virtual int CountOfPurchasedDrug { get; set; } = 0;
        public virtual List<Pharmacist> Pharmacists { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}
