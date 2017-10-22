using System.Collections.Generic;
using System.Linq;

namespace AlternatingCombine
{
    public class AlternateCombiner : IAlternateCombiner
    {
        public AlternateCombiner(){ }

        public List<string> AlternateCombine(List<string> first, List<string> second)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int listLength = first.Count() + second.Count();
            List<string> newList = new List<string>(listLength);

            while (firstIndex < first.Count() || secondIndex < second.Count())
            {
                if (firstIndex != first.Count() && secondIndex != second.Count())
                {
                    if (firstIndex <= secondIndex)
                    {
                        newList.Add(first[firstIndex]);
                        firstIndex++;
                    }
                    else
                    {
                        newList.Add(second[secondIndex]);
                        secondIndex++;
                    }
                }
                else if (secondIndex == second.Count())
                {
                    newList.Add(first[firstIndex]);
                    firstIndex++;
                }
                else
                {
                    newList.Add(second[secondIndex]);
                    secondIndex++;
                }

            }


            return newList;
        }
    }
}
