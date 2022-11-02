// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//配列の宣言・要素数の初期化
int[] x = new int[10];
int size = 10;
//入力された値を10回取得する
for (int i = 0; i < size; i++)
{
    x[i] = int.Parse(Console.ReadLine());
}
//10個の要素をする
for (int i = 0; i < size; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("偶数=" + (x[i]));
    }
}

for (int i = 0; i < size; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("奇数=" + (x[i]));
    }
}