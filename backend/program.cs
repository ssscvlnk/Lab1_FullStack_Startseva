// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Меня зовут Старцева П.С.");
Console.WriteLine(DateTime.Now);
Console.WriteLine("Введите свое имя:");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine("Хотите продолжить? (y/n)");
string answer = Console.ReadLine();
if (answer == "y") Console.WriteLine("Продолжаем");
else if (answer == "n") Console.WriteLine("Не продолжаем");
else Console.WriteLine("Некорректный ответ");