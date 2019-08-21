using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCustomList
{
    public class CustomList<T> : IEnumerable
    {
        private T[] items;
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private bool IsEqual;
        private Converter<T, T> converter;


        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
            IsEqual = false;
            this.converter = converter;
        }



        public void Add(T itemAdded)
        {

            if (count == capacity)
            {
                T[] temp = new T[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    temp[i] = items[i];
                }
                capacity *= 2;
                items = temp;
            }
            items[count] = itemAdded;

            count++;
        }

        public void Remove(T itemRemoved)
        {
            for (int i = 0; i < count; i++)
            {

                if (itemRemoved.Equals(items[i]))
                {
                    IsEqual = true;
                    if (i < count - 1)
                    {
                        items[i] = items[i + 1];
                    }
                    else
                    {
                        items[i] = default(T);
                    }
                    count--;
                }
                else
                {
                    IsEqual = false;
                }
            }
        }

        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += items[i].ToString();
            }
            return newString;
        }

        public static CustomList<T> operator +(CustomList<T> left, CustomList<T> right)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < left.Count; i++)
            {
                newList.Add(left[i]);
            }
            for (int i = 0; i < right.Count; i++)
            {
                newList.Add(right[i]);
            }
            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> left, CustomList<T> right)
        {
            //CustomList<T> resultList = new CustomList<T>();
            //fill this up with all items of left

            for (int i = 0; i < left.Count; i++)
            {
                for (int x = 0; x < right.Count; x++)
                    if (left[i].Equals(right[x]))
                    {
                        left.Remove(left[i]);
                    }
                    else
                    {
                        continue;
                    }
            }
            return left;
        }



        public static CustomList<T> Zip(CustomList<T> OriginalList, CustomList<T> ListInsert)
        {
            CustomList<T> ZippedList = new CustomList<T>();
            for (int i = 0; i < OriginalList.Count || i < ListInsert.Count; i++)
            {
                if (i < OriginalList.Count)
                {
                    ZippedList.Add(OriginalList[i]);
                }
                if (i < ListInsert.Count)
                {
                    ZippedList.Add(ListInsert[i]);
                }
            }

            return ZippedList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        public CustomList<int> Sort(CustomList<int> OriginalList)
        {
            for (int i = 0; i < OriginalList.Count; i++)
            {
                int x;
                int valueHolder = OriginalList[i];
                for (x = i; x > 0; x--)
                {
                    if (OriginalList[x - 1] > valueHolder)
                    {
                        OriginalList[x] = OriginalList[x - 1];
                    }

                }
                OriginalList[x] = valueHolder;
            }
            return OriginalList;
        }

        
    }


}


