// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

   
        int KP = 0;
        int HP = 0;

        for (int i = 1; i <= 9; i++)
        {
            Console.Write(i + "回表、巨人の得点");
            KP+= int.Parse(Console.ReadLine());

            Console.Write(i + "回裏、阪神の得点");
            HP += int.Parse(Console.ReadLine());
        }

        Console.WriteLine("巨人"+KP+"点"+"・"+ "阪神"+HP+"点");

        if (KP >HP)
            Console.WriteLine("巨人の勝ち");
        else if (KP< HP)
            Console.WriteLine("阪神の勝ち");
        else
            Console.WriteLine("引き分け");
    
