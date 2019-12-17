using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtvecklingsUppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an array with numbers from 1 to 25 and shuffles their positon them.
            HeltalsSortering sort = new HeltalsSortering();

            //First part writes the unsorted list. 
            Console.WriteLine("Unsorted list values from 1 - 25");
            foreach (int listValue in sort.GetContainer())
            {    
                Console.Write(listValue+", ");
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________________________");

            //Second parts sorts the list with a quicksort algorithm
            QuickSort quick = new QuickSort(sort.GetContainer());
            Console.WriteLine("Sorted list values from 1 - 25 by alphabetical order in Swedish");
            foreach (int listValue in sort.GetContainer())
            {
                Console.Write(listValue + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________________________");
            Console.ReadKey();
        }
    }
}
