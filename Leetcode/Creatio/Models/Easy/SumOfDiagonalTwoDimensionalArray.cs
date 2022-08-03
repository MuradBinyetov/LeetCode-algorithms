using System;
using System.Collections.Generic;
using System.Text;

namespace Creatio.Models
{
    class SumOfDiagonalTwoDimensionalArray
    {
		public static int ArrayDiagonal(int[,] array)
		{
            int leftDiagonal = 0;
            int rightDiagonal = 0;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    if(row == column)
                    {
                        leftDiagonal += array[row, column];
                    }

                    if((row+column) == array.GetLength(0) - 1)
                    {
                        rightDiagonal += array[row, column];
                    }
                }
            }
            int sum = leftDiagonal + rightDiagonal;
            return sum;
		}
	} 
}

