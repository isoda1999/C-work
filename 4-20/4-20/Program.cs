// See https://aka.ms/new-console-template for more information
using System.Drawing;

int size = int.Parse(Console.ReadLine());
 size = 0;
String dollars = "";
for (int i = 0; i < size; i++){
    dollars += "$";
    Console.Write(dollars);
}