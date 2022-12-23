// Задача 1

int num = new Random().Next(100, 1000);
System.Console.WriteLine($"Исходное число {num}, вторая цифра {(num / 10) % 10} ");

// Задача 2
System.Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());

if (num1 < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (num1 > 99999)
{
    System.Console.WriteLine("Введено число вне диапозона!");
}
else if (num1 <= 99999 && num1 >= 100)
{
    string num2 = Convert.ToString(num1);
    System.Console.WriteLine(num2 [2]);
}

// Задача 3

System.Console.WriteLine("Введите номер дня недели: ");
int num3 = Convert.ToInt32(System.Console.ReadLine());

if (num3 < 1 && num3 > 7)
{
    System.Console.WriteLine("Такого дня недели нет");
}
else if (num3 >= 1 && num3 <=5)
{
    System.Console.WriteLine("Нет(");
}
else if (num3 == 6 || num3 == 7)
{
    System.Console.WriteLine("Да!)");
}