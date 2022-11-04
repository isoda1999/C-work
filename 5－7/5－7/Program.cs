// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
// 値を格納する配列 kuku を宣言する
int[,] kuku = new int[9, 9];

// 配列 kuku に値を代入する
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        kuku[i - 1, j - 1] = i * j;
    }
}
// 結果を出力する
int sum = 0;
int x = 0;
int y = 0;

Console.WriteLine("左辺");
x = int.Parse(Console.ReadLine());

Console.WriteLine("右辺");
y = int.Parse(Console.ReadLine());

int result = kuku[x - 1, y - 1];
Console.WriteLine(result);