using FluentNHibernate.Mapping;
using Question1.Models.Appointment_Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Mappings
{
    public class MedicalConditionMap : ClassMap<MedicalCondition>
    {
        public MedicalConditionMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Patient);
        }
    }
}
