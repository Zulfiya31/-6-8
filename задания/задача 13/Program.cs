Console.WriteLine ("Введите любое число ");
int num = int.Parse(Console.ReadLine());
if(num<99)
{
    Console.WriteLine("Третьей цифры нет");
}   
if(num>99){
    Console.WriteLine ("Неразобрал, что за число вы ввели, введите снова ");
    string str = Console.ReadLine ();
    int n = str.Length;
    Console.WriteLine  ("Все теперь увидел, вот ваша третья цифра");
    Console.WriteLine  (str[2]);
}
