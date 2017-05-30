using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab7_v1.Model;

/*****************************************************************************/

namespace lab7_v1.Simulators
{
    public class RandomClientsProvider : IDisposable
    {
        /*-------------------------------------------------------------------*/

        public IReadOnlyList<Client> Clients;

        /*-------------------------------------------------------------------*/

        public RandomClientsProvider(int min_clients, int max_clients)
        {
            m_min_clients = min_clients;
            m_max_clients = max_clients;
        }

        /*-------------------------------------------------------------------*/

        public void RegenerateClients()
        {
            m_clients.Clear();

            AddNewClients();
        }

        /*-------------------------------------------------------------------*/

        public void AddNewClients()
        {
            int num_of_clients = m_rand.Next(m_min_clients, m_max_clients);

            for (int i = 0; i < num_of_clients; i++)
            {
                m_clients.Add(
                    new Client(Guid.NewGuid())
                    );
            }
        }
        /*-------------------------------------------------------------------*/
        
        public void Dispose()
        {
            m_clients.Clear();
        }

        /*-------------------------------------------------------------------*/

        private List<Client> m_clients = new List<Client>();
        private int m_min_clients;
        private int m_max_clients;
        private Random m_rand = new Random();

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
