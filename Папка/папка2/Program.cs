//Номер 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine ("Введите любое число..");
int i = int.Parse(Console.ReadLine());
if (i%2==0)
{
    Console.WriteLine ("Число четное");
}
else 
{
    Console.WriteLine ("Число нечетное");
}
