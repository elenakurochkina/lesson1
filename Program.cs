//Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные 
//числа от 1 до N.

System.Console.Write("введите число N: ");
string x = Console.ReadLine();
int N = int.Parse(x);
int a = 2;
while (a < N)
{
    System.Console.WriteLine($"{a}, ");
    a=a+2;
}

