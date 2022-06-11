//Напишите программу, которая на вход принимает
//число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

System.Console.Write("введите число a: ");
string x = Console.ReadLine();
int a = int.Parse(x);
if (a%2==0)
{
    System.Console.WriteLine("а - четное число");
}
else
{
    System.Console.WriteLine("а - нечетное число");
}