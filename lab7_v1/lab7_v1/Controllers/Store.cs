using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab7_v1.Utils;

/*****************************************************************************/

namespace lab7_v1.Controllers
{
    /// <summary>
    /// Состояния магазина
    /// </summary>
    public enum StorageStates : int
    {
        Closed = 0 // explisit is better than implicit
        , Open
    }

    /// <summary>
    /// Магазин. Имеет склад, осуществляет закупку и продажу товаров.
    /// </summary>
    public class Store
    {
        /*-------------------------------------------------------------------*/

        public int CashBalance {
            get { return m_cash_balance; }
            private set
            {
                CheckPositive.Check(value, "CashBalance", "value");

                m_cash_balance = value;
            }
        }

        /*-------------------------------------------------------------------*/

        public Storage Storage
        {
            get { return m_storage; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Pre-built storage must be specified");
                }

                this.m_storage = value;
            }
        } // ???????

        /*-------------------------------------------------------------------*/

        public StorageStates State { get; private set; }

        /*-------------------------------------------------------------------*/

        public Store(Storage storage, int initial_cash_balance)
        {
            this.Storage = storage;
            this.State = StorageStates.Closed; // explisit is better than implicit

            this.CashBalance = initial_cash_balance;
        }

        /*-------------------------------------------------------------------*/

        public void Close() { State = StorageStates.Closed; }

        /*-------------------------------------------------------------------*/

        public void Open() { State = StorageStates.Open; }

        /*-------------------------------------------------------------------*/

        private int m_cash_balance;
        private Storage m_storage;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
