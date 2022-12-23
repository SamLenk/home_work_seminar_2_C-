// Задача 1

int num = new Random().Next(100, 1000);
System.Console.WriteLine($"Исходное число {num}, вторая цифра {(num / 10) % 10} ");

// Задача 2
System.Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());

if (num < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (num >= 3)
{
    System.Console.WriteLine((num1 / 10) % 10);
}
// Задача 3