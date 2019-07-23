using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSimpleArraySum
{
    class Program
    {
        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] arrayinput = new int[arCount];
            int count = 0;


            string[] arrayconvert = Console.ReadLine().Split(' ');
            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            //;

            foreach (var item in arrayconvert)
            {
                try
                {
                    arrayinput[count] = Convert.ToInt32(item);
                    count++;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            int result = simpleArraySum(arrayinput);



           Console.WriteLine(result);

           // textWriter.Flush();
           // textWriter.Close();
        }
    }
}
