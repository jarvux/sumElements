using System;
using System.Collections.Generic;
using System.Linq;
using SumElements;

namespace SumElements
{
    class Program
    {
        private static void Main()
        {
            int[] nums = { 2, 7, 11, 15 };
            var target = 9;
            var result = Elements.SumElements(nums, target);
            Console.WriteLine("found, index: " + result);
        }
    }
}