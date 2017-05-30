/*****************************************************************************/

/* FIXME List:
 Consider Change:
 * CC4 - remove try-catch section;
 * CC5 - throw exeption.
 */

/*****************************************************************************/

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

        public IReadOnlyList<StoreLogItem> StoreLog {
            get { return m_store_log; }
        }

        /*-------------------------------------------------------------------*/

        public Store(Storage storage, int initial_cash_balance)
        {
            this.Storage = storage;
            this.State = StorageStates.Closed; // explisit is better than implicit

            this.CashBalance = initial_cash_balance;
        }

        /*-------------------------------------------------------------------*/

        public void Close() {
            if (State != StorageStates.Closed)
            {
                State = StorageStates.Closed;
                CloseSession();
            }
            //else // CC5
            //{
            //    throw new InvalidOperationException("Unable to close a closed store");
            //}
        }

        /*-------------------------------------------------------------------*/

        public void Open() {
            if (State != StorageStates.Open)
            {
                State = StorageStates.Open;
                OpenSession();
            }
            //else // CC5
            //{
            //    throw new InvalidOperationException("Unable to open an opened store");
            //}
        }

        /*-------------------------------------------------------------------*/

        private void CloseSession()
        {
            m_current_session_log.PeriodEnd = DateTime.UtcNow;
            m_current_session_log.NumberOfClients = m_session_clients.Count;
            m_store_log.Add(m_current_session_log);

            m_session_clients.Clear();
        }

        /*-------------------------------------------------------------------*/

        private void OpenSession()
        {
            m_current_session_log = new StoreLogItem();
            m_current_session_log.PeriodStart = DateTime.UtcNow;
        }

        /*-------------------------------------------------------------------*/

        public void Sell(Client client, IDictionary<StoreItem, int> order_items)
        {
            foreach (var item in order_items) {
                this.Sell(client, item.Key, item.Value);
            }
        }

        /*-------------------------------------------------------------------*/

        public void Sell(Client client, StoreItem si, int quantity=1)
        {
            int order_cost = get_selling_order_price(si, quantity);

            lock (this)
            {
                // CC4
                try
                {
                    this.Storage.ShipProduct(si, quantity);
                }
                catch (ArgumentException e)
                {
                    throw new ArgumentException("Unable to sell product", e);
                }
                
                m_session_clients.Add(client);
                CashBalance += order_cost;
                m_current_session_log.Income += order_cost;
                m_current_session_log.StorageUsedSpace = m_storage.GetUsedSpace();
            }
        }

        /*-------------------------------------------------------------------*/

        public void Purchase(IDictionary<StoreItem, int> order_items)
        {
            foreach (var item in order_items)
            {
                this.Purchase(item.Key, item.Value);
            }
        }

        /*-------------------------------------------------------------------*/

        public void Purchase(StoreItem si, int quantity = 1)
        {
            int order_cost = get_purchase_order_price(si, quantity);

            lock (this)
            {
                // CC4
                try
                {
                    this.Storage.StoreProduct(si, quantity);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    throw e;
                }
                catch (ArgumentException e)
                {
                    throw e;
                }

                CashBalance -= order_cost;
            }
        }

        /*-------------------------------------------------------------------*/

        private int m_cash_balance;
        private Storage m_storage;
        private List<StoreLogItem> m_store_log = new List<StoreLogItem>();
        private StoreLogItem m_current_session_log;
        private HashSet<Client> m_session_clients = new HashSet<Client>();

        /*-------------------------------------------------------------------*/

        private int get_purchase_order_price(StoreItem si, int quantity)
        {
            return si.PurchaseCost * quantity;
        }

        /*-------------------------------------------------------------------*/

        private int get_selling_order_price(StoreItem si, int quantity)
        {
            return si.SellingCost * quantity;
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
