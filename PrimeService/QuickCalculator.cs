using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing_using_mstest
{
    public class QuickCalculator
    {
        public int QuickAdd(int num1, int num2) 
        {
            return num1 + num2;
        }

        public int QuickSubtract(int num1, int num2) 
        {
            return num1 - num2; 
        }

        public bool QuickSumDivisibleBy2(int num1, int num2) 
        {
            if( (num1 + num2) % 2 == 0) 
            { 
                return true;    
            }

            return false;
        }
    }
}
