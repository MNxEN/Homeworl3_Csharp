// Задача 3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите число ->");

for (int digit = 1; digit <= number; digit++)
{
    int result = digit * digit * digit;
    Console.Write($" {result} ");
}

/*
int digit = 1;
while (digit <= number)
{
    int result = digit * digit * digit;
    Console.Write($" {result} ");
    digit++;
}
*/