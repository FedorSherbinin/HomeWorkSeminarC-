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

// Task 2. Напишите программу, которая выводит третью цифру заданного числа.

int ThirdDigit(int num)
{
    int Number = num % 1000;
        Number = Number / 100;
    
    int result = Number;
    return result;
}

Console.WriteLine("Imput a Number: ");
int num = Convert.ToInt32(Console.ReadLine());
    if(num >=100 )
    {
        int newNumber = ThirdDigit(num);
        Console.WriteLine(newNumber);
    }
    else
    Console.WriteLine("there is no third digit");
