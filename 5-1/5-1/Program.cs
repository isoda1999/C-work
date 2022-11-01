// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int y = 0;
//配列の要素数と入力の回数を10回に増やす
for (int i = 0; i < 10; i++)
{
    int[] x = { y };

    y = int.Parse(Console.ReadLine());
}
//要素を×２して出力する
for (int i = 0; i < 11; i++)
{
    Console.WriteLine(+i * 2);
}