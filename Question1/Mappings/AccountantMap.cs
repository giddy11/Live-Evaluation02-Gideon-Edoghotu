using Question1.Models;

namespace Question1.Mappings
{
    public class AccountantMap : EntityBaseMap<Accountant>
    {
        public AccountantMap()
        {
            References(x => x.Hospital);
        }
    }
}
