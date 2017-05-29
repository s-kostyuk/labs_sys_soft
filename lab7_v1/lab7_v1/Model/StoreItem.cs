using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab7_v1.Utils;

/*****************************************************************************/

namespace lab7_v1.Model
{
    public class StoreItem : BasicEntity
    {
        /*-------------------------------------------------------------------*/

        public string Name { get; private set; }

        /*-------------------------------------------------------------------*/

        public int Cost
        {
            get { return m_cost; }

            private set
            {
                CheckPositive.Check(value, "Product Cost", "value");

                m_cost = value;
            }
        }

        /*-------------------------------------------------------------------*/

        public int PackageSize {
            get { return m_package_size; }

            private set
            {
                CheckPositive.Check(value, "PackageSize", "value");

                m_package_size = value;
            }
        }

        /*-------------------------------------------------------------------*/

        public StoreItem(Guid id, string name, int cost, int package_size)
            : base(id)
        {
            this.Name = name;
            this.Cost = cost;
            this.PackageSize = package_size;
        }

        /*-------------------------------------------------------------------*/

        private int m_cost;
        private int m_package_size;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
