using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************************************************************/

namespace lab7_v1.Model
{
    public struct StorageItem
    {
        /*-------------------------------------------------------------------*/

        public StoreItem StoreItem { get; private set; }
        public int Quantity { get; private set; }

        /*-------------------------------------------------------------------*/

        public StorageItem(StoreItem si, int quantity)
        {
            this.StoreItem = si;
            this.Quantity = quantity;
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
