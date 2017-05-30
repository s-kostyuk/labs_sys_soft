using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

using lab7_v1.Simulators;
using lab7_v1.Model;
using lab7_v1.Controllers;

namespace lab7_v1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            const int STORAGE_CAPACITY = 1000;
            const int INITAL_BALANCE = 1000;

            Storage storage = new Storage(STORAGE_CAPACITY);

            Store store = new Store(storage, INITAL_BALANCE);

            for (int i = 0; i < 10; i++)
            {
                storage.StoreProduct(new StoreItem(
                    Guid.NewGuid(), string.Format("Phone {0}", i),
                    10, 14, 1
                )
                , 3
                );
            }

            StoreActivitySimulators simul = new StoreActivitySimulators(store);

            Thread th_client = new Thread(simul.ClientsBuying);
            Thread th_storage = new Thread(simul.StorageRefill);

            Console.WriteLine("started");

            th_storage.Start();
            th_storage.Suspend();

            th_client.Start();
            th_client.Suspend();

            while (true)
            {
                Console.WriteLine("Store opened");
                store.Open();

                th_client.Resume();

                Thread.Sleep(10000);

                th_client.Suspend();

                Console.WriteLine("Store closed");
                store.Close();

                Console.WriteLine(string.Format("Balance: {0}", store.CashBalance));
                Console.WriteLine(store.StoreLog.Last());
                Console.WriteLine();

                th_storage.Resume();

                Thread.Sleep(10000);

                th_storage.Suspend();

                store.Open();

                Console.WriteLine(string.Format("Balance: {0}", store.CashBalance));
                Console.WriteLine(string.Format("Used space: {0}", store.Storage.GetUsedSpace()));
                Console.WriteLine();

                //th_client.Abort();
            }



        }
    }
}
