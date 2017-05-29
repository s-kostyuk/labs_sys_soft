using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using lab7_v1.Model;
using lab7_v1.Utils;

/*****************************************************************************/

namespace lab7_v1.Controllers
{
    public class Storage
    {
        /*-------------------------------------------------------------------*/

        public IList<StorageItem> StorageItems { get; private set; }
        public int Capacity
        {
            get { return m_capacity; }

            set
            {
                if (value < UsedSpace())
                {
                    throw new ArgumentException("Storage capacity can't be less than UsedSpace", "value");
                }
                else
                {
                    m_capacity = value;
                }
            }
        }

        /*-------------------------------------------------------------------*/

        public void StoreProduct(StoreItem si, int quantity)
        {
            check_valid_quantity(quantity);

            int space_needed = get_occupied_space(si, quantity);

            if (space_needed > FreeSpace())
            {
                throw new ArgumentException("Not enough free space", "quantity");
            }
            else
            {
                m_items_available[si] = get_current_quantity(si) + quantity;
            }

            Debug.Assert(FreeSpace() >= 0);
        }

        /*-------------------------------------------------------------------*/

        public void ShipProduct(StoreItem si, int quantity)
        {
            check_valid_quantity(quantity);

            int current_quantity = get_current_quantity(si);
            
            if (quantity > current_quantity)
            {
                throw new ArgumentException("Not enough product items left", "quantity");
            }
            else
            {
                m_items_available[si] -= quantity;
            }

            Debug.Assert(m_items_available[si] >= 0);
        }

        /*-------------------------------------------------------------------*/

        public int UsedSpace()
        {
            return StorageItems.Sum(
                item => get_occupied_space(item.StoreItem, item.Quantity)
                );
        }

        /*-------------------------------------------------------------------*/

        public int FreeSpace()
        {
            return this.m_capacity - this.UsedSpace();
        }

        /*-------------------------------------------------------------------*/

        private static int get_occupied_space(StoreItem si, int quantity)
        {
            return si.PackageSize * quantity;
        }

        /*-------------------------------------------------------------------*/

        private int get_current_quantity(StoreItem si)
        {
            int current_quantity;
            m_items_available.TryGetValue(si, out current_quantity);

            return current_quantity;
        }

        /*-------------------------------------------------------------------*/

        private static void check_valid_quantity(int quantity)
        {
            CheckPositive.Check(quantity, "Product quantity", "quantity");
        }

        /*-------------------------------------------------------------------*/

        private int m_capacity;
        private Dictionary<StoreItem, int> m_items_available;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
