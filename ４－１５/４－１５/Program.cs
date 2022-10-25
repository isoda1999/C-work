// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Prime
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} = {1}", n, string.Join(" x ", PrimeFactors(n)));
    }

    public static IEnumerable<int> PrimeFactors(int n)
    {
        int i = 2;
        int tmp = n;

        while (i * i <= n)
        {
            if (tmp % i == 0)
            {
                tmp /= i;
                yield return i;
            }
            else
            {
                i++;
            }
        }
        if (tmp != 1) yield return tmp;{
            Console.WriteLine();
        }
    }
}
