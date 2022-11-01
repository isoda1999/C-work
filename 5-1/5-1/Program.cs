// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");
//配列の宣言・宣言
int[] x = new int[10];
int n = 0;
//入力された値を10回取得する
for (int i = 0; i < 10; i++)
{
    n = int.Parse(Console.ReadLine());
}
//10個の要素を×2する
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("2倍された値"+(n + i) * 2);
}