using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtvecklingsUppgift3
{
    public class QuickSort
    {
        private Dictionary<int, char[]> ConvertIntegerToCharArray;
        public void instantiateDataTable()
        {
            ConvertIntegerToCharArray = new Dictionary<int, char[]>();
            ConvertIntegerToCharArray[1] = "ett".ToCharArray();
            ConvertIntegerToCharArray[2] = "två".ToCharArray();
            ConvertIntegerToCharArray[3] = "tre".ToCharArray();
            ConvertIntegerToCharArray[4] = "fyra".ToCharArray();
            ConvertIntegerToCharArray[5] = "fem".ToCharArray();
            ConvertIntegerToCharArray[6] = "sex".ToCharArray();
            ConvertIntegerToCharArray[7] = "sju".ToCharArray();
            ConvertIntegerToCharArray[8] = "åtta".ToCharArray();
            ConvertIntegerToCharArray[9] = "nio".ToCharArray();
            ConvertIntegerToCharArray[10] = "tio".ToCharArray();
            ConvertIntegerToCharArray[11] = "elva".ToCharArray();
            ConvertIntegerToCharArray[12] = "tolv".ToCharArray();
            ConvertIntegerToCharArray[13] = "tretton".ToCharArray();
            ConvertIntegerToCharArray[14] = "fjorton".ToCharArray();
            ConvertIntegerToCharArray[15] = "femton".ToCharArray();
            ConvertIntegerToCharArray[16] = "sexton".ToCharArray();
            ConvertIntegerToCharArray[17] = "sjutton".ToCharArray();
            ConvertIntegerToCharArray[18] = "arton".ToCharArray();
            ConvertIntegerToCharArray[19] = "nitton".ToCharArray();
            ConvertIntegerToCharArray[20] = "tjugo".ToCharArray();
            ConvertIntegerToCharArray[21] = "tjugoett".ToCharArray();
            ConvertIntegerToCharArray[22] = "tjugotvå".ToCharArray();
            ConvertIntegerToCharArray[23] = "tjugotre".ToCharArray();
            ConvertIntegerToCharArray[24] = "tjugofyra".ToCharArray();
            ConvertIntegerToCharArray[25] = "tjugofem".ToCharArray();
        }

        public QuickSort(List<int> list)
        {
            //size of the List
            int Lowest = 0;
            int Highest = 25;

            instantiateDataTable();
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
            int pivotLocation = LowestValue;
            int pivot = list[LowestValue];
            int leftwall = LowestValue;
            for(int i = LowestValue+1;i<HighestValue;i++)
            {
                if(Compare(list[i], pivot)) //if (list[i] < pivot)
                {
                    int Storage = list[i];
                    list[i] = list[leftwall];
                    list[leftwall] = Storage;
                    leftwall = leftwall + 1;

                    if (list[i] == pivot)
                        pivotLocation = i;
                    else if (list[leftwall] == pivot)
                        pivotLocation = leftwall;

                }
            }
            int LeftwallStorage = list[leftwall];
            list[leftwall] = pivot;
            list[pivotLocation] = LeftwallStorage;


            return leftwall;
        }


        public bool Compare(int listvalue, int pivot)
        {
            int amountOfLettersInListValue = ConvertIntegerToCharArray[listvalue].Count();
            int amountOfLettersInpivot = ConvertIntegerToCharArray[pivot].Count();


            for (int i = 0; i < Math.Max(amountOfLettersInListValue, amountOfLettersInpivot); i++)
            {
                if (amountOfLettersInListValue == i)
                    return true;
                if (amountOfLettersInpivot == i)
                    return false;

                if (ConvertIntegerToCharArray[listvalue][i] < ConvertIntegerToCharArray[pivot][i])
                {

                    return true;
                }
                else if (ConvertIntegerToCharArray[listvalue][i] > ConvertIntegerToCharArray[pivot][i])
                {
                    return false;
                }

            }

            //if its the same number it returns true
            return false;
        }

    }
}
