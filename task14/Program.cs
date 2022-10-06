/*
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
*/

int number = new Random().Next(1, 1000);

string Kratno(int number)
{
    string kratno = "";
    if (number % 7 == 0 && number % 23 == 0)
    {
        kratno = "Да";
    }
    else kratno = "Нет";
    return kratno;
}

Console.WriteLine(number);
String result = Kratno(number);
Console.WriteLine(result);