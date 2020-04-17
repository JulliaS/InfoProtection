using Common;
using System.Numerics;

namespace Task6
{
    public class ElGemal
    {
        public static void Encode(BigInteger p, BigInteger g, BigInteger k_B, BigInteger m_A, out BigInteger r, out BigInteger e)
        {
            var d_B = BigInteger.ModPow(g, k_B, p);

            BigInteger k_A;
            do
            {
                k_A = NumbersOperations.Random(2, p - 1);
            }
            while (BigInteger.GreatestCommonDivisor(k_A, p - 1) != 1);

            r = BigInteger.ModPow(g, k_A, p);
            e = (BigInteger.ModPow(d_B, k_A, p) * (m_A % p)) % p;
        }
        public static BigInteger Decode(BigInteger r, BigInteger e, BigInteger p, BigInteger k_B)
        {
            return (BigInteger.ModPow(r, p - k_B - 1, p) * (e % p)) % p;
        }

    }
}
