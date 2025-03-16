using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1_2Calculator
{
    internal interface IMath
    {
        decimal Add(params decimal[] nums);
        decimal Subtract(params decimal[] nums);
        decimal Multiply(params decimal[] nums);
        decimal Divide(params decimal[] nums);
        decimal Modulo(params decimal[] nums);

    }
    internal class MyMath : IMath
    {
        public decimal Add(params decimal[] nums)
        {
            decimal result = 0;
            foreach (var i in nums)
            {
                result += i;
            }
            return result;
        }
        public decimal Subtract(params decimal[] nums)
        {
            if (nums.Length == 0) return 0;

            decimal result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result -= nums[i];
            }
            return result;
        }
        public decimal Multiply(params decimal[] nums)
        {
            decimal result = 1;
            foreach (var i in nums)
            {
                result *= i;
            }
            return result;
        }
        public decimal Divide(params decimal[] nums)
        {
            if (nums.Length == 0) { return 0; }
            decimal result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result /= nums[i];
            }
            return result;
        }
        public decimal Modulo(params decimal[] nums)
        {
            if(nums.Length == 0) {return 0; }
            decimal result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result %= nums[i];
            }
            return result;
        }
        
    }
}
