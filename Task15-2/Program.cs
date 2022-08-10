int d = 0;
while(d < 1 || d > 7) 
{
    Console.WriteLine(" Введите число от 1 до 7");
    d = Convert.ToInt32(Console.ReadLine());
}
switch (d)
{
    case 1 :
    case 2 :
    case 3 :
    case 4 :
    case 5 :
        Console.WriteLine("Нет");
        break;
    case 6 :
    case 7 :
        Console.WriteLine("Да");
        break;
    // default:
    //     Console.WriteLine("Попробуй еще раз");
    //     break;
    }
