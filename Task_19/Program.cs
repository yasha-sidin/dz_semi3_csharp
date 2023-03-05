// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void CheckPal5(int fivefigures)
{
    string check = fivefigures.ToString();
    if (check.Length == 5)
    {
        if (check[0] == check[4] && check[1] == check[3])
        {
            Console.WriteLine("Пятизначное число является палиндромом");
        }
        else
        {
            Console.WriteLine("Пятизначное число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
    }
}
Console.Write("Введите пятизначное число: ");
int number5 = int.Parse(Console.ReadLine());
CheckPal5(number5);