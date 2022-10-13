using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("年齢？");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("おおよその日数"+ age * 365);
        }
       
    }
}
