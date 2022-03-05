using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class RobotReturnOrigin
    {
        public static bool JudgeCircle(string moves)
        {
            int upCount = 0;
            int downCount = 0;
            int rigthCount = 0;
            int leftCount = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                    upCount++;
                else if (moves[i] == 'D')
                    downCount++;
                else if (moves[i] == 'L')
                    leftCount++;
                else
                    rigthCount++;
            }

            if (rigthCount - leftCount == 0 && upCount - downCount == 0)
                return true;

            return false;
        }
    }
}
