// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sum = 0;
while (true)
{
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(int.Parse(Console.ReadLine()));
    if (num == 0)
    {
        break;

    }

    sum += num;


    Console.WriteLine(num);
    Console.WriteLine("合計は" + sum);
}
            