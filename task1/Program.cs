// Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int num = ReadInt("Введите пятизначное число: ");
if (9999 < num && num < 100000)
{
    if ((num / 10000) == (num % 10) && (num / 1000 % 10) == (num / 10 % 10))
    {
        Console.WriteLine($"Число {num} является палиндромом!");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ является палиндромом!");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число!");
}
