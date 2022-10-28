// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;

Console.WriteLine("hellow world");

//コンソールに入力された値をとってくる
//int n = int.Parse(Console.ReadLine());
int n = 5;

//入力された数だけ文字列増やす処理をSizeにつける
for (int i = 0; i < n; i++)
{
    //String型の変数Sizeに空文字を入れて初期化
    String dollars = "";

    //順に＄を増やす
    for (int j = 0; j < n; j++)
    {
        if (j == i)
        {
            dollars += "$";
        }
        else if (j == (n - i - 1))
        {
            dollars += "$";
        }
        else
        {
            dollars += " ";
        }
    }
    Console.WriteLine(dollars);
}