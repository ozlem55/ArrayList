using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            ////verilere erişme
            //Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //AddRange
            Console.WriteLine("************");
            //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> saylar = new List<int>() { 1, 3, 7, 9,92, 5 };
            //liste.AddRange(renkler);
            liste.AddRange(saylar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //sort
            Console.WriteLine("*******************");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //binarysearch
            Console.WriteLine("*******************");
            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            Console.WriteLine("*******************");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //clear
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
