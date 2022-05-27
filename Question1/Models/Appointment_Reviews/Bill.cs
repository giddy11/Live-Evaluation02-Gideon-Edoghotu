

namespace Question1.Models.Appointment_Reviews
{
    public class Bill
    {
        public virtual void AddToBill(string content, decimal sumTotal)
        {
            BillBreakdown.Add(content, sumTotal);
            TotalBills += sumTotal;
        }

        public virtual void RemoveItemFromBill(string content)
        {
            if (BillBreakdown.ContainsKey(content))
            {
                BillBreakdown.Remove(content);
                Console.WriteLine($"{content} has been removed!");
            }
            else Console.WriteLine("Not Found!");
        }

        public virtual decimal PrintTotal()
        {
            return TotalBills; 
        }



        

        public virtual int Id { get; set; }
        public virtual decimal TotalBills { get; set; } = 0; 
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Hospital Hospital { get; set; }

        public virtual Dictionary<string, decimal> BillBreakdown { get; set; }
    }
}
