﻿// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

public class Task2
{
    public static void Main(string[] args)
    {
        // Входная строка со смешанными буквами обоих регистров
        string input = "aBcD1ef!-";
        // Преобразование всех заглавных букв в строчные
        string result = input.ToLower();
        // Вывод результата
        Console.WriteLine(result);
    }
}