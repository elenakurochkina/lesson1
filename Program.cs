//Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, 
//а какое меньшее

System.Console.Write("введите число a: ");
string x = Console.ReadLine();
int a = int.Parse(x);
System.Console.Write("введите число b: ");
string y = Console.ReadLine();
int b = int.Parse(y);
if (a < b)
{
    System.Console.WriteLine($"большее число {b}, а меньшее число {a}");
}
else
{
    System.Console.WriteLine($"большее число {a}, а меньшее число {b}");
}