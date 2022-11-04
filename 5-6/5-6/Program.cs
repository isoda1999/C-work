// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
// 値を格納する配列 kuku を宣言する
int[,] kuku = new int[9, 9];

// 配列 kuku に値を代入する
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.WriteLine(i * j);
        kuku[i - 1, j - 1] = i * j;
    }
}

// 結果を出力する
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(" {0,2}", kuku[i, j]);
    }

    Console.WriteLine();
}