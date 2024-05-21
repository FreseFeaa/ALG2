
// Реализовать алгоритм Карацубы 

using System;

class KaratsubaAlgorithm
{
    public static long KaratsubaMultiply(long x, long y)
    {
        if (x < 10 || y < 10)
        {
            return x * y;
        }

        int num1_len = x.ToString().Length;
        int num2_len = y.ToString().Length;
        int n = Math.Max(num1_len, num2_len);
        int n2 = (int)Math.Ceiling(n / 2.0);

        long a = x / (long)Math.Pow(10, n2);
        long b = x % (long)Math.Pow(10, n2);
        long c = y / (long)Math.Pow(10, n2);
        long d = y % (long)Math.Pow(10, n2);

        long ac = a * c;
        long bd = b * d;
        long ad_bc = (a + b) * (c + d) - ac - bd;

        return (long)(ac * Math.Pow(10, 2 * n2) + ad_bc * Math.Pow(10, n2) + bd);
    }

    static void Main()
    {
        Console.WriteLine("Введите первое число");
        long num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        long num2 = int.Parse(Console.ReadLine());


        long result = KaratsubaMultiply(num1, num2);

        Console.WriteLine("Результат умножения для  {0} и {1}используя алгоритм Карацубы: {2}", num1, num2, result);
    }
}


// 3.	Реализовать рекурсивный и итеративный алгоритм для чисел Фибоначчи
 
// 3.1 Рекурсия

using System;
class Fibonacci
{
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ; Console.WriteLine($"Число Фибоначчи для n={n}: {FibonacciRecursive(n)}");
    }
}

// 3.2 Интерактивность

using System;
class Fibonacci
{
    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int prev = 0;
        int curr = 1; for (int i = 2; i <= n; i++)
        {
            int temp = prev + curr;
            prev = curr; curr = temp;
        }
        return curr;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ; Console.WriteLine($"Число Фибоначчи для n={n} : {FibonacciIterative(n)}");
    }
}

// 4.	Реализуйте рекурсивный и итеративный алгоритм Евклида 

// 4.1 Рекурсия

using System;
class Euclid
{
    public static int EuclideanRecursive(int a, int b)
    {
        if (b == 0) return a;
        return EuclideanRecursive(b, a % b);
    }
    static void Main()
    {
        Console.WriteLine("введите число для  евклида "); int num1 = int.Parse(Console.ReadLine()); 
        Console.WriteLine("введите 2 число для  евклида "); int num2 = int.Parse(Console.ReadLine()); 
        int gcd = EuclideanRecursive(num1, num2);
        Console.WriteLine($"Наибольший общий делитель чисел {num1} и {num2} : {gcd}");
    }
}

// 4.2 Интерактивность

using System;
class Euclid{
    public static int EuclideanIterative(int a, int b)    {
        while (b != 0)        {
            int temp = b;            b = a % b;
            a = temp;        }
        return a;
    }
    static void Main()    {
        Console.WriteLine("введите 1 число для евклида ");        
	int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("введите 2 число для евклида ");        
	int num2 = int.Parse(Console.ReadLine()); 
        int gcd = EuclideanIterative(num1, num2);
        Console.WriteLine($"Наибольший общий делитель чисел {num1} и {num2} равен: {gcd}");    }
}