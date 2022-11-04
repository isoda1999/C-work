// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

Console.WriteLine("Hello, World!");
//配列の宣言・要素数の初期化
int[] x = new int[10];
int sum = 0;
//入力された値を10回取得する
int i = 0;
for (i = 0; i < 10; i++)
{
    x[i] = int.Parse(Console.ReadLine());

    sum += x[i];

    if (sum >= 100)
    {
        Console.WriteLine(sum);
        break;
    }
}
for (i = 0; i < 10; i++)
    if (i < 10)
    {
        Console.WriteLine("入力された値" + x[i]);
    }