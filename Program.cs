using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            uint n = 0;
            
            //Requesting number
            Console.Write(" Enter the number between 0 and 20 : ");
            n = Convert.ToUInt32(Console.ReadLine());

            //Building matrix
            for(int i = 1; i <= n; i++)
            {
                int j = i;
                int count = 0;
                while (count < n)
                {
                    Console.Write(" {0}", j);
                    j++;
                    count++;
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
