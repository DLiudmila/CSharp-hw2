Console.WriteLine("Введите целое число: ");
string str = Console.ReadLine();
char[] array = str.ToCharArray();
if ( array.Length < 3)
{
   Console.WriteLine("третьей цифры нет"); 
}
else
{
    Console.WriteLine(array[2]);
}

