using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    public interface SortingAlgorithm
    {
        int SortTurn();
        bool SortSection();
    }
    
    public class BubbleSortLtR<Sortable> : SortingAlgorithm
    {
        public List<Sortable> sortArray;
        int idx = 1;
        public BubbleSortLtR(ref List<Sortable> sortArray)
        {
            this.sortArray = sortArray;
        }
        public BubbleSortLtR(int size,Func<Sortable> fillFunction)
        {
            this.sortArray = new List<Sortable>();
            for(int i = 0; i < size; i++) sortArray.Add(fillFunction());
        }
        public bool SortSection()
        {
            bool result = false;
            for(idx =1;idx< sortArray.Count();idx++)
            {
                if(SortTurn()!=0)result = true;
            }
            idx = 1;
            return result;
        }

        public int SortTurn()
        {
            if (idx >= sortArray.Count()) idx = 1;
            if (System.Convert.ToInt32(sortArray[idx]) < System.Convert.ToInt32(sortArray[idx - 1]))
            {
                Sortable t = sortArray[idx];
                sortArray[idx] = sortArray[idx - 1];
                sortArray[idx - 1] = t;
                idx += 1;
                return idx-1;
            }
            idx += 1;
            return 0;
        }
    }
}
