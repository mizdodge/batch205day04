using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04
{
    class Cobacoba
    {
        public Cobacoba(int length)
        {
            result(length);
        }
        public void result(int length)
        {
            int number = length;
            for (int i = 0; i < length; i++)
            {
                if(i== length - 1)
                {
                    number = number + i;
                }
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(j + "\t");
                    }
                    else if (i == length - 1)
                    {
                        if (j<i)
                        {
                            Console.Write(number + "\t");
                            number -= 1;
                            

                        }
                        else
                        {
                            Console.Write(i + j + "\t");
                        }
                    }
                    else if (j == length - 1) 
                    {
                        if (j == 0)
                        {
                            Console.Write(i + j+ "\t");
                        }
                        else
                        {
                            Console.Write(i + j);
                        }
                    }
                    else if (j == 0)
                    {
                        if (j == 0)
                        {
                            Console.Write(i + j+ "\t");
                        }
                        else
                        {
                            Console.Write("\t");
                        }
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
