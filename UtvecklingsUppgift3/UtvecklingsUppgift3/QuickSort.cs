using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtvecklingsUppgift3
{
    public class QuickSort
    {
        public QuickSort(List<int> list)
        {
            //size of the List
            int Lowest = 0;
            int Highest = 25;


            //now the quicksort algorithm is working.
            QuickSortFunction(list, Lowest, Highest);
        }

        public void QuickSortFunction(List<int> list, int LowestValue, int HighestValue)
        {
            if(LowestValue<HighestValue)
            {
                int Pivot_location = Partition(list, LowestValue, HighestValue);
                QuickSortFunction(list, LowestValue, Pivot_location);
                QuickSortFunction(list, Pivot_location + 1, HighestValue);
            }
        }

        public int Partition(List<int> list, int LowestValue, int HighestValue)
        {
            int pivotlocation = LowestValue;
            int pivot = list[LowestValue];
            int leftwall = LowestValue;
            for(int i = LowestValue+1;i<HighestValue;i++)
            {
                if( list[i]<pivot)
                {
                    int Storage = list[i];
                    list[i] = list[leftwall];
                    list[leftwall] = Storage;
                    leftwall = leftwall + 1;
                }
            }
            list[leftwall] = pivot;
            


            return leftwall;
        }
        
    }
}
