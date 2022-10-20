// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    int strike = 0;
    int ball = 0;
    while (strike < 3 && ball < 4) {
        Console.Write("ストライク=1かボール=2で入力して下さい ");
        int judgement = int.Parse(Console.ReadLine());

        if (judgement == 1){
            strike++;
        }
        else if (judgement == 2)
            ball++;
        }
Console.WriteLine("ストライク" + strike+":"+"ボール" + ball) ;


