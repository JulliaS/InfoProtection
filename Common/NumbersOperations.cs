using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class NumbersOperations
    {
        public static int NSD(int number1, int number2)
        {
            while (number2 != 0)
            {
                var temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }
            return number1;
        }

        public static int ModPow(int value, int power, int mod)
        {
            if (power == 0) return 1;
            if (power % 2 == 1) return (ModPow(value, power - 1, mod) * value) % mod;
           
            int variable;
            if (power % 4 == 0)
            {
                variable = ModPow(value, power / 4, mod) % mod;
                variable *= variable; variable *= (variable % mod);
                return variable % mod;
            }
            else
            {
                variable = ModPow(value, power / 2, mod) % mod;
                return (variable * variable) % mod;
            }
            
        }
    }
}
