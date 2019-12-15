using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UtvecklingsUppgift3
{
   public class HeltalsSortering
    {
        private List<int> Container;

        private Dictionary<int, char[]> ConvertIntegerToCharArray;

        //the constructor creates the list and shuffles the data. 
        public HeltalsSortering()
        {
            Container = new List<int>();
            for(int i = 1;i<26;i++)
            {
                Container.Add(i);
                Shuffle();
                
            }
            //prepare a dictonary which converts the int to a chararray.
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
            char valuee = 'ä';
            int value = valuee;

            QuickSort quick = new QuickSort(Container);
        }
        //shuffles the List, Utilises the Random class to Shuffle the List. 
        public void Shuffle()
        {
            Random rng = new Random();
            int n = Container.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = Container[k];
                Container[k] = Container[n];
                Container[n] = value;
            }
        }


        

    }
}
