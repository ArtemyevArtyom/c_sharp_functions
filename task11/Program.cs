/*
11. Напишите программу, которая выдаёт случайное трёхзначное число
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
*/

int number = new Random().Next(100, 1000);

int getDeleteTwoDigitFromNumber(int number)
{
    int firstNumber = number / 100;
    int thirdNumber = number % 10;
    return (firstNumber * 10 + thirdNumber);
    
}

Console.WriteLine(number);
int result = getDeleteTwoDigitFromNumber(number);
Console.WriteLine(result);