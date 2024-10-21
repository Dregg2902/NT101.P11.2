using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
class Program
{
    // Hàm kiểm tra số nguyên tố
    class BigIntegerPrimeTest
    {
        public bool IsProbablePrime(BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= source - 2);

                BigInteger x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }

            return true;
        }
    }
    static BigInteger GeneratePrime(long low, long high)
    {
        Random rand = new Random();
        BigInteger primeCandidate;
        BigIntegerPrimeTest BIPT = new BigIntegerPrimeTest();
        do
        {
            primeCandidate = rand.NextInt64(low, high);
        } while (BIPT.IsProbablePrime(primeCandidate,100)==false);
        return primeCandidate;
    }

    // Hàm tính ước chung lớn nhất (gcd)
    static BigInteger Gcd(BigInteger a, BigInteger b)
    {
        BigInteger Remainder;

        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }

        return a;
    }

    // Hàm tính lũy thừa modulo (a^x % p) sử dụng phương pháp bình phương và nhân
    static BigInteger ModularExponentiation(BigInteger a, BigInteger x, BigInteger p)
    {
        BigInteger result = 1;
        a = a % p;
        while (x > 0)
        {
            if (x % 2 == 1)
                result = (result * a) % p;
            x /= 2;
            a = (a * a) % p;
        }
        return result;
    }

    // Tìm 10 số nguyên tố lớn nhất dưới 10 số nguyên tố Mersenne đầu tiên
    static List<BigInteger> LargestPrimesUnderMersenne()
    {
        List<BigInteger> mersennePrimes = new List<BigInteger>
        {
            BigInteger.Pow(2, 2) - 1,       // 3
            BigInteger.Pow(2, 3) - 1,       // 7
            BigInteger.Pow(2, 5) - 1,       // 31            BigInteger.Pow(2, 7) - 1,       // 127
            BigInteger.Pow(2, 13) - 1,      // 8191
            BigInteger.Pow(2, 17) - 1,      // 131071
            BigInteger.Pow(2, 19) - 1,      // 524287
            BigInteger.Pow(2, 31) - 1,      // 2147483647
            BigInteger.Pow(2, 61) - 1,      // 2305843009213693951
            BigInteger.Pow(2, 89) - 1       // 61847529056000335583
        };

        // Danh sách để lưu trữ các số nguyên tố lớn nhất
        List<BigInteger> largestPrimes = new List<BigInteger>();

        // Duyệt qua từng số nguyên tố Mersenne
        foreach (var m in mersennePrimes)
        {
            List<BigInteger> primesUnderM = FindPrimesUnder(m, 1);

            Console.WriteLine($"số nguyên tố lớn nhất dưới {m}:");
            foreach (var prime in primesUnderM)
            {
                Console.WriteLine(prime);
            }
            Console.WriteLine(); // Dòng trống giữa các kết quả
        }
        return largestPrimes;
    }
    static List<BigInteger> FindPrimesUnder(BigInteger limit, int count)
    {
        List<BigInteger> primes = new List<BigInteger>();
            BigInteger candidate = limit - 1; // Bắt đầu từ số ngay dưới limit
        BigIntegerPrimeTest BIPT = new BigIntegerPrimeTest();
        // Tìm số nguyên tố cho đến khi đủ số lượng yêu cầu
        while (primes.Count < count && candidate > 1)
            {
                if (BIPT.IsProbablePrime(candidate,100))
                {
                    primes.Add(candidate);
                }
                candidate--; // Giảm candidate để kiểm tra số nguyên tố tiếp theo
            }
        return primes;
    }

    // Hàm hiển thị menu và xử lý tùy chọn của người dùng
    static void ShowMenu()
    {
        Console.WriteLine("Chọn tùy chọn:");
        Console.WriteLine("1. Sinh số nguyên tố 8-bit, 16-bit, 64-bit và kiểm tra số nguyên tố < 2^89 - 1");
        Console.WriteLine("2. Tính ước chung lớn nhất (GCD) của hai số");
        Console.WriteLine("3. Tính lũy thừa modulo (a^x % p)");
        Console.Write("Nhập lựa chọn của bạn: ");
    }

    static void Main(string[] args)
    {
        ShowMenu();
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            // Sinh số nguyên tố 8-bit, 16-bit, 64-bit
            BigInteger prime8Bit = GeneratePrime(1 << 7, (1 << 8) - 1);
            BigInteger prime16Bit = GeneratePrime(1 << 15, (1 << 16) - 1);
            BigInteger prime64Bit = GeneratePrime(4611686018427387904, 9223372036854775807);
            Console.WriteLine($"Số nguyên tố 8-bit: {prime8Bit}");
            Console.WriteLine($"Số nguyên tố 16-bit: {prime16Bit}");
            Console.WriteLine($"Số nguyên tố 64-bit: {prime64Bit}");

            // Kiểm tra số nguyên tố < 2^89 - 1
            Console.Write("Nhập số cần kiểm tra (nhỏ hơn 2^89 - 1): ");
            BigInteger arbitraryNumber = BigInteger.Parse(Console.ReadLine());
            BigIntegerPrimeTest BIPT = new BigIntegerPrimeTest();
            Console.WriteLine($"{arbitraryNumber} {(BIPT.IsProbablePrime(arbitraryNumber,100) ? "là số nguyên tố." : "không phải là số nguyên tố.")}");

            // Xác định 10 số nguyên tố lớn nhất dưới 10 số nguyên tố Mersenne đầu tiên
            Console.WriteLine("10 số nguyên tố lớn nhất dưới 10 số nguyên tố Mersenne đầu tiên là:");
            List<BigInteger> largestPrimes = LargestPrimesUnderMersenne();
            foreach (long prime in largestPrimes)
            {
                Console.WriteLine(prime);
            }
        }
        else if (choice == "2")
        {
            // Tính UCLN của hai số
            Console.Write("Nhập số thứ nhất: ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine($"UCLN của hai số là: {Gcd(num1, num2)}");
        }
        else if (choice == "3")
        {
            // Tính lũy thừa modulo
            Console.Write("Nhập cơ số (a): ");
            BigInteger baseNum = BigInteger.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ (x): ");
            BigInteger exponent = BigInteger.Parse(Console.ReadLine());
            Console.Write("Nhập modulo (p): ");
            BigInteger mod = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine($"{baseNum}^{exponent} mod {mod} = {ModularExponentiation(baseNum, exponent, mod)}");
        }
        else
        {
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
        }
    }
}

