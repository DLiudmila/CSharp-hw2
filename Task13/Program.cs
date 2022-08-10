Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n % 10;
if ( n < 100 )
{
   Console.WriteLine("третьей цифры нет"); 
}
else
{
    Console.WriteLine(result);
}

