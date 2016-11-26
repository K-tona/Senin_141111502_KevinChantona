using System;

namespace Solution

{
    class Solution
    {
        public const int Modulus = 1000000007;
        static bool Valid(int a, int b)
        {
            if (a < 25) return false;
            if (a == 25) return b <= 23;
            return b == (a - 2);
        }
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(System.Console.ReadLine());
            var b = Convert.ToInt32(System.Console.ReadLine());
            int hasil;
            if (a < b) Swap(ref a, ref b);
            if (!Valid(a, b))
            {
                hasil = 0;
            }
            else
            {
                if (a > 25)
                {
                    hasil = Kombinasi(24, 24, Modulus);
                    hasil = (int)((((long)hasil) * Pangkat(2, b - 24, Modulus)) % Modulus);
                }
                else
                {
                    hasil = Kombinasi(a - 1, b, Modulus);
                }
            }
            Console.WriteLine("{0}", hasil);
        }
        public static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
        public static int Kombinasi(int n, int r, int mod)
        {
            if (n < r) Swap(ref n, ref r);
            if (n < 1 || r < 1) return 1;
            var row = new int[r];
            for (var i = 0; i < r; row[i++] = 1) { }
            for (int i = 2; i < r; ++i)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
            }
            --r;
            int sum = row[r];
            for (int i = 0; i < n; ++i)
            {
                for (int j = r; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
                sum = (sum + row[r]) % mod;
            }
            return sum;
        }
        private static int Pangkat(int Bilangan, int Expo, int mod)
        {
            if (Expo < 2)
            {
                return (Expo < 1) ? 1 : Bilangan;
            }
            long product = Pangkat(Bilangan, Expo >> 1, mod);
            product = (product * product) % mod;
            return ((Expo & 1) == 1) ? (int)((product * Bilangan) % mod) : (int)(product);
        }
    }
}