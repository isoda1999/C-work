// See https://aka.ms/new-console-template for more information
using System.Drawing;
Console.WriteLine("hellow world");
//コンソールに入力された値をとってくる
int n = int.Parse(Console.ReadLine());
//String型の変数Sizeに空文字を入れて初期化
String dollars = "";
//入力された数だけ文字列増やす処理をSizeにつける
for (int i=0;i<n;i++) {
    dollars = "";
    //順に＄を増やす
    for (int j=(n - 1)-i;j<n;j++) {
        dollars += "$";
    }
    Console.WriteLine(dollars);
}

