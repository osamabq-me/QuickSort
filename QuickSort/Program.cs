using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //Array of intgers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;//Number of comparisons
        private int mov_count = 0;//Number of data movments

        //Number of elements in array
        private int n;


        void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in arrauy :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximam 20 elements \n");
            }

            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter elements to the array");
            Console.WriteLine("---------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }




        static void Main(string[] args)
        {
        }
    }
}
