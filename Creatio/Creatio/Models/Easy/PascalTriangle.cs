using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        { 
            IList<IList<int>> result = new List<IList<int>>();
            List<int> row = new List<int>();
             
            row.Add(1);
            result.Add(row);

            for (int i = 1; i < numRows; i++)
            {
                var prevRow = result[i - 1];
                row = new List<int>();
                row.Add(1);
                int count = prevRow.Count;
                for (int j = 0; j < prevRow.Count - 1; j++)
                {
                    row.Add(prevRow[j] + prevRow[j + 1]);
                }
                row.Add(1);
                result.Add(row);
            }
            Console.WriteLine(result);
             

            return result;

        }
    }
}
