/*
12. Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

int firstNumber = new Random().Next(1, 100);
int secondNumber = new Random().Next(1, 10);

void ReturnOstatok(int firstNumber, int secondNumber)
{
    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine($"Кратно");
    }
    else Console.WriteLine($"Не кратно, остаток {firstNumber % secondNumber}");
}

Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);

ReturnOstatok(firstNumber, secondNumber);