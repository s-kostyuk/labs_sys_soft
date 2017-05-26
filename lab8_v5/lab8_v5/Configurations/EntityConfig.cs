using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using lab8_v5.Model;

namespace lab8_v5.Configurations
{
    public class BasicEntityConfiguration<T> : EntityTypeConfiguration<T>
        where T : BasicEntity
    {
        public BasicEntityConfiguration()
        {
            HasKey(e => e.Id);
            //Property(e => e.DomainId).IsRequired();
        }
    }
}
