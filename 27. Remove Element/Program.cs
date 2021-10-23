using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = { 3, 2, 2, 3 };
            int rem = 3;


            Console.Write("[");
            foreach (int inp in input)
            {
                Console.Write($" {Convert.ToString(inp)} ");
            }
            Console.WriteLine("]");


            int k = RemoveElement(input, rem);

            Array.Resize(ref input, k);

            int[] expectedNums = input;

            Console.WriteLine(Convert.ToString(k));

            Console.Write("[");
            foreach (int inp in input)
            {
                Console.Write($" {Convert.ToString(inp)} ");
            }
            Console.WriteLine("]");

            Console.Read();



            int RemoveElement(int[] nums, int val)
            {
                if (nums == null) return 0;
                if (nums.Length == 0) return 0;
                int us = 0;
                foreach(int num in nums)
                    {
                        if (num == val) us += 1;
                    }
                if (us == nums.Length) return 0;

                    int counter = nums.Length-1;
                int i = 0;

                for (; i < nums.Length; i++)
                {                                               
                    if (nums[i] == val)                         
                    {

                        if (nums[counter] == val)
                        {
                            for (int j = nums.Length - 1; j > 0; j--)
                            {
                                if (nums[j] != val)
                                {
                                    break;
                                }
                                else
                                {
                                    counter -= 1;
                                }
                            }
                        }

                        if (counter < i)
                        {
                            break;
                        }
                        nums[i] = nums[counter];
                        nums[counter] = val;
                       
                        counter = nums.Length - 1;
                    }
                }
                return i;

                //counter = nums.Length - 1;

                //for (int j = nums.Length - 1; j > 0; j--)
                //{
                //    if (nums[j] = val)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        counter -= 1;
                //    }
                //}
                //return nums.Length - counter +1 ;

            }
        }
    }
}
