﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11  82 -> 10   9012 -> 12
Console.Clear();
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
  int sumNumber(int number){
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }
int sum = sumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sum);