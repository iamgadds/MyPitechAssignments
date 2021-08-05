using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[7] { 11,32,13,53,3,15,69};
            ArrayMinMax ar = new ArrayMinMax();

            int max = 0;

            int min = ar.getValueUsingRef(myArray, ref max);

            Console.Write("The array is:  ");
            foreach(int i in myArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nMax: " + max + "      Min: " + min);

            Console.WriteLine("\n--------------------");
            min = ar.getValueUsingOut(myArray, out max);
            Console.WriteLine("\nMax: " + max + "      Min: " + min);

            Console.WriteLine("\n--------------------");
            var res = ar.getValueUsingArrays(myArray);
            Console.WriteLine("\nMax: " + res[1] + "      Min: " + res[0]);

            Console.WriteLine("\n--------------------");
            var res1 = ar.getValueUsingTuple(myArray);
            Console.WriteLine("\nMax:" + res1.Item2 + "      Min: " + res1.Item1);

            Console.WriteLine("\n--------------------");
            var res2 = ar.getValueUsingClass(myArray);
            Console.WriteLine("\nMax:" + res2.max1 + "      Min: " + res2.min1);

            Console.ReadLine();
        }
    }

    

}
