using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {

        //static Dictionary<string, int> kutuphane = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            //kutuphane.Add("Emre", 27);
            //kutuphane.Add("Mustafa", 29);
            //kutuphane.Add("Ahmet", 45);
            //kutuphane.Add("Veli", 38);

            //foreach (var item in kutuphane)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.Write("Öğrenci No Giriniz:");
            //string ad  = Console.ReadLine();

            //try
            //{
            //    Console.WriteLine(kutuphane[ad]);
            //}
            //catch
            //{
            //    Console.WriteLine("Öğrenci Bulunamadı.");
            //}
            Dictionary<string, int> kutuphane = new Dictionary<string, int>();
            kutuphane.Add("Emre", 27);
            foreach (var item in kutuphane)
            {
                Console.WriteLine(item);
            }

        }
        class MyDictionary<T,K>
        {
            T[] array;
            T[] array1;

            T[] tempArray;
            T[] tempArray1;
            public MyDictionary()
            {
                array = new T[0];
                array1 = new T[0];
            }
            public void Add(T item, T item2)
            {
                tempArray = array;
                tempArray1 = array1;
                array = new T[array.Length + 1];
                array1 = new T[array1.Length + 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    array[i] = tempArray[i];
                    array1[i] = tempArray1[i];
                }
                for (int i = 0; i < tempArray.Length; i++)
                {
                    
                }
                array[array.Length - 1] = item;
                array1[array1.Length - 1] = item2;


            }

        }
    }
}