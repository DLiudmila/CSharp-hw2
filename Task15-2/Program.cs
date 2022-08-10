int d = 0;
while(d > 0 || d < 8) 
// {
    Console.WriteLine(" Введите число от 1 до 7");
    d = Convert.ToInt32(Console.ReadLine());
// }
switch (1 <= d && d <= 7)
{
    case 1 <= d && d <= 5 :
    Console.WriteLine("Нет");
    break;
    case  d == 6 || d == 7 :
    Console.WriteLine("Да");
    break;
    default:
    Console.WriteLine("Попробуй еще раз");
    }
