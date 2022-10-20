// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int strike = 0;
int ball = 0;
//各球種の入力回数のMAXを決める
while (strike < 3 && ball < 4)
{
    //各球種の入力欄を作る
    Console.Write("ストライク=1,ボール=2,ファール=3で入力して下さい ");
    int judgement = int.Parse(Console.ReadLine());
    //whileで指定した回数までカウントを繰り返し、上限に達したらそれまで入力された値を表示する
    if (judgement == 1){
        strike++;
    }else if (judgement == 2){
        ball++;
    //ファールは2つまではストライクとしてカウントされるのでストライクの条件式にファールの条件式を追加する
    }else if (judgement == 3 && strike < 2){
        strike++;
    }
    Console.WriteLine("ストライク" + strike + ":" + "ボール" + ball);
}