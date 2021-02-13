using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<S, P>
    {
        S[] array;
        P[] array2;
        S[] tempArray;
        P[] tempArray2;

        public MyDictionary()
        {
            array = new S[0];
            array2 = new P[0];


        }

        public void Add(S item, P item2)
        {
            S[] tempArray = array;
            array = new S[array.Length + 1];
            P[] tempArray2 = array2;
            array2 = new P[array2.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
                // Console.WriteLine("Şehir:"+ " " + array[i]);
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                array2[i] = tempArray2[i];
                // Console.WriteLine("Plaka" +" "+ array2[i]);
            }
            array[array.Length - 1] = item;
            array2[array2.Length - 1] = item2;

        }

        public void List()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Şehir:" + array[i] + " " + " Plaka: " + array2[i]);
            }
        }

        public int Count()
        {
            return array2.Length;
        }


    }
}


