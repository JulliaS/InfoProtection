using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Task5
{
    public class SoloveyShtrassen
    {
        public static bool IsPrime(int n, int error)
        {
            int a;
            var random = new Random();

            for (int i = 0; i < error; i++)
            {
                a = random.Next(2, n);
                if (NumbersOperations.NSD(a, n) > 1)
                {
                    return false;
                }
                if (NumbersOperations.ModPow(a, (n - 1) / 2, n) != (n + Jacobi(a, n)) % n)
                {
                    return false;
                }
            }

            return true;
        }

        private static int Jacobi(int x, int n)
        {
            if (NumbersOperations.NSD(x, n) != 1) return 0;

            int result = 1;
            do
            {
                int y = 0;
                while (x % 2 == 0)
                {
                    y += 1;
                    x /= 2;
                }

                if ((y % 2 == 1 && (n % 8 == 3 || n % 8 == 5))
                    || (x % 4 == 3 && n % 4 == 3))
                {
                    result = -result;
                }

                //if (x % 4 == 3 && n % 4 == 3)
                //{
                //    result = -result;
                //}

                int temp = x;
                x = n % temp;
                n = temp;

            } while (x != 0);

            return result;
        }

       
    }
}
