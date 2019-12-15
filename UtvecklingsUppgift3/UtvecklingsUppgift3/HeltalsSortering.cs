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
          
          
           
        }
        public List<int> getContainer()
        {
            return Container;
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
