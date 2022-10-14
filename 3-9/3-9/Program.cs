using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("曜日を入力してください");
            Console.WriteLine("0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("時間帯を入力してください");
            Console.WriteLine("0=午前、1=午後、2=夜間");
            int time = int.Parse(Console.ReadLine());
            Boolean bli = true;
            //日曜は全時間帯false
            if (day == 0)
            {
                bli = false;
                Console.WriteLine("休診");
            }
            //時間帯0で曜日が2か5の時
            else if (time == 0 && (day == 2 || day == 5))
            {
                bli = false;
                Console.WriteLine("休診");
                //時間帯1で曜日が6の時
            }
            else if ((time == 1 && (day == 6)))
            {
                bli = false;
                Console.WriteLine("休診");
                //時間帯2で曜日が2か5の時
            }
            else if ((time == 2 && (day == 3 || day == 6)))
            {
                bli = false;
                Console.WriteLine("休診");
                if (bli)
                    Console.WriteLine("診察");
                else
                {
                    Console.WriteLine("休診");
















                }
            }
        }
    }
}
