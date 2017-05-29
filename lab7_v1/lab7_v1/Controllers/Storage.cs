/*****************************************************************************/

/* FIXME List:
 Consider Change:
 * CC1 - Raise an event on added/removed items in storage;
 * CC2 - Add a cache of used space to minimize executions of LINQ queries;
 * CC3 - Move lock() out of the Storage class.

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
    /// Склад (хранилище) магазина. Содержит данные о находящихся на складе
    /// товарах, доступном и занятом пространстве.
    /// </summary>
    public class Storage
    {
        /*-------------------------------------------------------------------*/

        //public event EventHandler StorageItemsChanged; // CC1

        /*-------------------------------------------------------------------*/

        /// <summary>
        /// Список товаров на складе и количество единиц.
        /// </summary>
        public IReadOnlyDictionary<StoreItem, int> StorageItems
        {
            get { return m_items_available; }
        }

        /// <summary>
        /// Максимальная вместимость склада
        /// </summary>
        public int Capacity
        {
            get { return m_capacity; }

            set
            {
                if (value < GetUsedSpace())
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

        public Storage(int max_storage_capacity)
        {
            m_capacity = max_storage_capacity;
            m_items_available = new Dictionary<StoreItem, int>();
        }

        /*-------------------------------------------------------------------*/

        /// <summary>
        /// Прием продукции на склад
        /// </summary>
        /// <param name="si">Тип продукции</param>
        /// <param name="quantity">Количество единиц продукции</param>
        public void StoreProduct(StoreItem si, int quantity)
        {
            check_valid_quantity(quantity);

            int space_needed = get_occupied_space(si, quantity);

            lock (this) // CC3
            {
                if (space_needed > GetFreeSpace())
                {
                    throw new ArgumentException("Not enough free space", "quantity");
                }
                else
                {
                    m_items_available[si] = get_current_quantity(si) + quantity;
                }
            }

            Debug.Assert(GetFreeSpace() >= 0);

            //RaiseStorageItemsChanged(); // CC1
        }

        /*-------------------------------------------------------------------*/

        /// <summary>
        /// Отправка товара со склада
        /// </summary>
        /// <param name="si">Отправляемый тип товара</param>
        /// <param name="quantity">Количество единиц товара</param>
        public void ShipProduct(StoreItem si, int quantity)
        {
            if (!m_items_available.ContainsKey(si))
            {
                throw new ArgumentException("This product is unavailable", "si");
            }

            check_valid_quantity(quantity);

            lock (this) // CC3
            {
                int current_quantity = get_current_quantity(si);

                if (quantity > current_quantity)
                {
                    throw new ArgumentException("Not enough product items left", "quantity");
                }
                else
                {
                    m_items_available[si] = get_current_quantity(si) - quantity;
                }
            }

            Debug.Assert(m_items_available[si] >= 0);

            //RaiseStorageItemsChanged(); // CC1
        }

        /*-------------------------------------------------------------------*/

        /// <summary>
        /// Рассчитать объем занятого пространства на складе
        /// </summary>
        /// <returns>Объем занятого пространства на складе</returns>
        public int GetUsedSpace()
        {
            return m_items_available.Sum(
                item => get_occupied_space(item.Key, item.Value)
                );
        }

        /*-------------------------------------------------------------------*/

        /// <summary>
        /// Рассчитать объем свободного пространства на складе
        /// </summary>
        /// <returns>Объем свободного пространства на складе</returns>
        public int GetFreeSpace()
        {
            return this.m_capacity - this.GetUsedSpace();
        }

        /*-------------------------------------------------------------------*/

        // CC1
        //protected virtual void RaiseStorageItemsChanged()
        //{
        //    StorageItemsChanged?.Invoke(this, new EventArgs());
        //}

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
        //private bool m_occupied_space_cache_valid = false; // CC2
        private Dictionary<StoreItem, int> m_items_available;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
