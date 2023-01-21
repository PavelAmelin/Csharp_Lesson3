int ch = Convert.ToInt32(Console.ReadLine());
if (ch / 10000 == ch % 10 && ch % 10000 / 1000 == ch % 100 / 10)
Console.WriteLine("Да");
else
Console.WriteLine("Нет");