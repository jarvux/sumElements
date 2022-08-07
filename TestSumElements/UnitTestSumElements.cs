using System;
using SumElements;
using NUnit.Framework;

namespace TestSumElements
{
    public class Tests
    {
        [Test]
        public void ExistSumElements()
        {
            int[] nums = {2,7,11,15};
            var target = 9;
            var expected = new Tuple<int, int>(0, 1);
            var result = Elements.SumElements(nums, target);
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
        
        [Test]
        public void DoesNotExistSumElements()
        {
            int[] nums = {12,7,11,15};
            var target = 9;
            var expected = new Tuple<int, int>(0, 0);
            var result = Elements.SumElements(nums, target);
            Assert.AreEqual(expected, result);
            Assert.Pass();
        }
    }
}