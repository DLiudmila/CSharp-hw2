int number = new Random().Next(100, 1000);
Console.WriteLine($"число: {number}");
int d12 = number / 10;
int d2 = d12 % 10;
Console.WriteLine(d2);
