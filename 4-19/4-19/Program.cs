// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sum = 0;
int count = 0;

while (true ){
    int num = int.Parse(Console.ReadLine());

    if (num == 0) {
        break;
    }
        sum += num;
        count++;
}


Console.WriteLine("平均は" + (sum / count));
