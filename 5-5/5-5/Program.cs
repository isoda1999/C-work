// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("数字を入力してください");
int num = int.Parse(Console.ReadLine());

int[] binary = new int[16];

// 配列 binaryに0か1を代入する
for (int i = 0; i < 16; i++)
{
    int x = (int)Math.Pow(2, i);
    int y = num / x;
    binary[i] = y % 2;
}

// 配列を逆転させる
Array.Reverse(binary);
// 配列の中身を順に出力する
for (int i = 0; i < 16; i++)
{
    Console.Write(binary[i]);
}