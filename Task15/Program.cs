int d = 0;
// while(d > 0 || d < 8) 
// {
    Console.WriteLine(" Введите число от 1 до 7");
    d = Convert.ToInt32(Console.ReadLine());
// }

if (1 <= d && d <= 5)
{
    Console.WriteLine("Нет");
}
else if ( d == 6 || d == 7 )
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Попробуй еще раз");
}

