int number = new Random().Next(100, 1000);
Console.WriteLine($"число: {number}");
int d2 = number % 100;
int d3 = d2 % 10;
int d4 = d2 - d3;
int result = d4 / 10;
Console.WriteLine(result);
