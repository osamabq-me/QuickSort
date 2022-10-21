﻿using System;
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

        //swap the element at index x with element at index y
        void swap(int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public void q_sort(int low,int high)
        {
            int pivot, i, j;
            if (low < high)
                return;

            //Partition the list into two parts:
            //one containing elements less that or equal to pivot
            //Outher conntainning elements greater than pivot

            i = low +1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //search for element greate than pivot
                while ((arr[i]<= pivot) && (i<= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for element smaller than pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count--;
                }
                cmp_count--;

                if (i < j)//If the greater element is on the left of the elemnt
                {
                    //swap the element at index i whit the elemnent at index j
                    swap(i, j);
                    mov_count++;
                }


            }


        }




        static void Main(string[] args)
        {
        }
    }
}
