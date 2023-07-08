/*
// Task 1. Напишите программу, которая принимает на вход
  // трёхзначное число и на выходе показывает вторую цифру этого числа.

int randomNumber(int num)
{
    int Number = num % 100;
        Number = Number / 10;

    int result = Number;
    return result;
}

Console.WriteLine("Imput a Triple Digits: " );
int num = Convert.ToInt32(Console.ReadLine());
    if(num >=100 && num < 1000)
    {
        int newNumber = randomNumber(num);
        Console.WriteLine(newNumber);
    }
    else
    Console.WriteLine("it's not a three digit number: " );
*/    