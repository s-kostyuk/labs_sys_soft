using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_v5.Model
{
    public class BasicEntity
    {
        public Guid Id { get; private set; }

        public BasicEntity() { }

        public BasicEntity(Guid id)
        {
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            return 
                (obj is BasicEntity)
                &&
                ((obj as BasicEntity).Id == this.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        
    }
}
