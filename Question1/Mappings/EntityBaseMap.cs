using FluentNHibernate.Mapping;
using Question1.Repos.EntityBase;

namespace Question1.Mappings
{
    public class EntityBaseMap<T> : ClassMap<T> where T : EntityBase
    {
        public EntityBaseMap()
        {
            Id(x => x.ID);
            Map(x => x.Name);
        }
    }
}
