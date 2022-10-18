// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int total =0;
while (total<100){
    total += int.Parse(Console.ReadLine());
    Console.WriteLine("合計" + total);
}