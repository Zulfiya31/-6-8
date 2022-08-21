//Задача 8 на нахождение четного из числа N
Console.WriteLine ("Введите любое число..");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n);
int i = 1;
while (i < n)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
   
