using System;
using System.Collections.Generic;

namespace zad26
{
    class ItemList
    {
        private readonly List<Item> items;

        public ItemList()
        {
            items = new List<Item>();
        }

        public int Count => items.Count;

        public Item Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException("Невалиден индекс.");
            }
            return items[index];
        }

        public void Add(Item newItem)
        {
            if (newItem == null)
            {
                throw new ArgumentNullException("Стоката не може да е null.");
            }

            if (items.Contains(newItem))
            {
                throw new ArgumentException("Тази стока вече съществува в списъка.");
            }

            int index = items.BinarySearch(newItem);
            if (index < 0) index = ~index;

            items.Insert(index, newItem);
        }
    }
}
