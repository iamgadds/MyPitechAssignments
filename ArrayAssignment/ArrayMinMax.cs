using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class ArrayMinMax
    {
        public int getValueUsingRef(int[] sort, ref int max)
        {
            int min = sort[0];
            for(int i=1; i<sort.Length; i++){
                if (sort[i] < min)
                {
                    min = sort[i];
                }
                else
                {
                    max = sort[i];
                }
            }
            return min;
        }

        public int getValueUsingOut(int[] sort, out int max)
        {
            int min = sort[0];
            max = sort[0];
            for (int i = 1; i < sort.Length; i++)
            {
                if (sort[i] < min)
                {
                    min = sort[i];
                }
                else
                {
                    max = sort[i];
                }
            }
            return min;
        }

        public int[] getValueUsingArrays(int[] sort)
        {
            int min = sort[0];
            int max = sort[0];
            for (int i = 1; i < sort.Length; i++)
            {
                if (sort[i] < min)
                {
                    min = sort[i];
                }
                else
                {
                    max = sort[i];
                }
            }

            int[] arrays = new int[2] { min, max };
            return arrays;
        }

        public Tuple<int,int> getValueUsingTuple(int[] sort)
        {
            int min = sort[0];
            int max = sort[0];
            for (int i = 1; i < sort.Length; i++)
            {
                if (sort[i] < min)
                {
                    min = sort[i];
                }
                else
                {
                    max = sort[i];
                }
            }
            return Tuple.Create(min, max);
        }

        
        public Result getValueUsingClass(int[] sort)
        {
            Result minmax = new Result();
            minmax.min1 = sort[0];
            minmax.max1 = sort[0];
            for (int i = 1; i < sort.Length; i++)
            {
                if (sort[i] < minmax.min1)
                {
                    minmax.min1 = sort[i];
                }
                else
                {
                    minmax.max1 = sort[i];
                }
            }
            return minmax;
        }

    }
    public class Result
    {
        public int min1;
        public int max1;
    }
}
