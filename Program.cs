using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Project___Perfect_Numbers__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstnum,lastnum,i,sum = 0;

            Console.Write(" Enter The First Number : ");
            firstnum = int.Parse(Console.ReadLine());

            Console.Write(" Enter The Last Number : ");
            lastnum = int.Parse(Console.ReadLine());


            while (firstnum <= lastnum)  
            {

               sum = 0;

               for (i = 1; i <= firstnum/2; i++) 
               {

                     if (firstnum % i == 0)
                     {  
                       sum += i;     
                     }

               } 
                    if (sum == firstnum && firstnum != 0)
                    { 
                      Console.WriteLine(firstnum);
                    }

                firstnum++;

            }
              
        }

    }
}
