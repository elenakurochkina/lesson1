// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

System.Console.Write("введите число a: ");
string x = Console.ReadLine();
int a = int.Parse(x);
System.Console.Write("введите число b: ");
string y = Console.ReadLine();
int b = int.Parse(y);
System.Console.Write("введите число c: ");
string z = Console.ReadLine();
int c = int.Parse(z);
int max = a;
if (b>max) max=b;
if (c>max) max=c;
System.Console.WriteLine(max);
