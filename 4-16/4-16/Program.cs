// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
  bool IsPrime(long x) { 
 x = int.Parse(Console.ReadLine());
    if (x < 2) return false;
    if (x == 2) return true;
    if (x % 2 == 0) return false;

    double sqrtX = Math.Sqrt(x);
    for (long i = 3; i < sqrtX; i += 2){
        if (x % i == 0) return false;
    }
    return true;
}