// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int kuku[] = new int[9, 9];

// 配列 kuku に値を代入する

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
        Console.Write(" {0,2}", kuku[i, j]);

    Console.WriteLine();
}