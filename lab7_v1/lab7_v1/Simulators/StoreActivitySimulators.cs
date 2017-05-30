using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

using lab7_v1.Controllers;
using lab7_v1.Model;

/*****************************************************************************/

namespace lab7_v1.Simulators
{
    public class StoreActivitySimulators
    {
        /*-------------------------------------------------------------------*/

        const int MIN_DELAY = 500;
        const int MAX_DELAY = 1000;
        const int MIN_CLIENTS = 3;
        const int MAX_CLIENTS = 10;
        const int MIN_QUANTITY = 1;
        const int MAX_QUANTITY = 3;

        /*-------------------------------------------------------------------*/

        public StoreActivitySimulators(Store store)
        {
            this.m_store = store;
            this.m_clients.RegenerateClients();
        }

        /*-------------------------------------------------------------------*/

        public void ClientsBuying()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(GetRandomDelay());

                    StoreItem product = GetRandomProduct();

                    Client client = GetRandomClient();

                    int quantity = m_rand.Next(MIN_QUANTITY, MAX_QUANTITY);

                    m_store.Sell(client, product, quantity);
                }
                catch (ArgumentException)
                {
                    // Failed to sell: not available
                }
                catch (ThreadInterruptedException)
                {
                    break;
                }
            }
        }

        /*-------------------------------------------------------------------*/

        public void StorageRefill()
        {
            while (m_store.CashBalance > 0)
            {
                try
                {
                    Thread.Sleep(GetRandomDelay());

                    StoreItem product = GetRandomProduct();

                    int quantity = m_rand.Next(MIN_QUANTITY, MAX_QUANTITY);

                    m_store.Purchase(product, quantity);
                }
                catch (ArgumentException)
                {
                    // Failed to refill storage: not enough money
                    break;
                }
                catch (ThreadInterruptedException)
                {
                    break;
                }
            }
        }

        /*-------------------------------------------------------------------*/

        private int GetRandomDelay()
        {
            return m_rand.Next(MIN_DELAY, MAX_DELAY);
        }

        /*-------------------------------------------------------------------*/

        private int GetRandomClientIndex()
        {
            return m_rand.Next(MIN_CLIENTS, MAX_CLIENTS);
        }

        /*-------------------------------------------------------------------*/

        private StoreItem GetRandomProduct()
        {
            int available_products_count = m_clients.Clients.Count;

            if (available_products_count == 0)
            {
                return null;
            }

            int random_product_number = m_rand.Next(0, available_products_count);

            return m_store.Storage.StorageItems.Keys.ElementAtOrDefault(available_products_count);
        }

        /*-------------------------------------------------------------------*/

        private Client GetRandomClient()
        {
            int available_clients_count = m_clients.Clients.Count;

            Debug.Assert(available_clients_count > 0);

            int random_client_number = m_rand.Next(0, available_clients_count);

            return m_clients.Clients[random_client_number];
        }
        
        /*-------------------------------------------------------------------*/

        private Store m_store;
        private Random m_rand = new Random();
        private RandomClientsProvider m_clients = new RandomClientsProvider(MIN_CLIENTS, MAX_CLIENTS);

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
