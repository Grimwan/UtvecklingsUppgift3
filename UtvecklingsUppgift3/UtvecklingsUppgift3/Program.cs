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
            HeltalsSortering sort = new HeltalsSortering();
            Console.WriteLine("Unsorted list values from 1 - 25");
            foreach (int listValue in sort.GetContainer())
            {    
                Console.Write(listValue+", ");
            }
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________________________");
            
            QuickSort quick = new QuickSort(sort.GetContainer());
            Console.WriteLine("Sorted list values from 1 - 25");
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
