// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sum = 0;
int num = int.Parse(Console.ReadLine());
sum += num;
while (true){
    if (num == 0)
    {
        break;
       

    }
    Console.WriteLine(num);
    Console.WriteLine("合計は" + sum);
}