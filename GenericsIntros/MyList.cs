using System;
using System.Collections.Generic;
using System.Text;
namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];

             
        }
        public void Add(T item)
        {
            T[] tempArray = items;// geçiçi dizi(tempArray) oluşturarak eleman koybolmasını engelleriz
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//geçiçi diziden degerleri asıl diziye aktarma

            }

            items[items.Length - 1] = item;//eklemek istediğimiz eleman eklendi
             
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}

