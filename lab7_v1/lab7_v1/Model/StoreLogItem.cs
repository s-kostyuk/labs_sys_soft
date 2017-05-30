using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************************************************************/

namespace lab7_v1.Model
{
    /// <summary>
    /// Вся текущая информация о сумме, полученной от продажи товаров,
    /// количестве клиентов и вместимости склада заносится в коллекцию и
    /// сериализуется в XML
    /// </summary>
    public struct StoreLogItem
    {
        /*-------------------------------------------------------------------*/

        public DateTime PeriodStart; // { get; set; }
        public int Income;           // { get; set; }
        public int NumberOfClients;  // { get; set; }
        public int StorageUsedSpace; // { get; set; }
        public DateTime PeriodEnd;   // { get; set; }

        /*-------------------------------------------------------------------*/

        public override string ToString()
        {
            return string.Format("Start: {0}\nEnd: {1}\nIncome: {2}\nNumberOfClients: {3}\nStorageUsedSpace: {4}",
                PeriodStart, PeriodEnd, Income, NumberOfClients, StorageUsedSpace
                );
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
