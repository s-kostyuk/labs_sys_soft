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

        public int PurchaseCost
        {
            get { return m_purchase_cost; }

            set
            {
                CheckPositive.Check(value, "Product Purchase Cost", "value");
                m_purchase_cost = value;
            }
        }

        /*-------------------------------------------------------------------*/

        public int SellingCost
        {
            get { return m_selling_cost; }

            set
            {
                CheckPositive.Check(value, "Product Selling Cost", "value");
                m_selling_cost = value;
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

        public StoreItem(Guid id, string name, int purchase_cost, int selling_cost, int package_size)
            : base(id)
        {
            this.Name = name;
            this.PurchaseCost = purchase_cost;
            this.SellingCost = selling_cost;
            this.PackageSize = package_size;
        }

        /*-------------------------------------------------------------------*/

        private int m_purchase_cost;
        private int m_selling_cost;
        private int m_package_size;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
