Console.WriteLine ("Введите любое трехзначное число..");
int i = int.Parse(Console.ReadLine());
int a = i/10;
int b = a%10;
Console.WriteLine( i + "=>"+ b );