

Console.WriteLine ("Введите любое число от 1 до 7");
int num = int.Parse(Console.ReadLine());
if(num<6)
{
    Console.WriteLine("Сегодня будни, иди работай");
}   
    if(num>6)
    {
       Console.WriteLine("Урра, выходной"); 
    }