using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PositionsLargeGroups
    {
        public static IList<IList<int>> LargeGroupPositions(string s) //"abbxxxxzzyyyy"
        {
            IList<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < s.Length; i++)
            {
                int count = 1;
                
                for (int f = i+1; f < s.Length; f++)
                { 
                    if (s[i] == s[f])
                    {
                        count++;
                        continue;
                    }
                    if(s[i] != s[f])
                    {
                        break;
                    }
                } 
                if (count >= 3)
                {
                    List<int> interval = new List<int>();
                    interval.Add(i);
                    i = i + count - 1;
                    interval.Add(i);
                    list.Add(interval);
                    
                } 
            } 
            return list;
        }
    }
}
