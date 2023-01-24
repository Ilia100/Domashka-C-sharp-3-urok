/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */


int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 9999 && resultNumber < 100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы Ввели не число или не корректное число. Повторите ввод!\n");
        }
    }
    return resultNumber;
}

void poli(int x)
{
    if ((x / 10000 == x % 10) && (x / 1000 % 10 == x % 100 / 10))
    {
        Console.WriteLine("это полиндром");
    }
    else
    {
        Console.WriteLine("это не полиндром");
    }
}

int y = GetNumber("Введите пятизначное чесло");

poli(y);

