/*
Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
*/
char[,] chars = new char[,] {{'H', 'e', 'l', 'l', 'o'},
                             {'W', 'o', 'r', 'l', 'd'}}; // Создаем массив символов

string makeString(char[,] chars) // Функция передает массив символов и преобразует их в строку
{
    string sim = ""; // Переменная принимающаа символы и превращающая их в строку
    for (int i = 0; i < chars.GetLength(dimension: 0); i++)
    {
        for (int j = 0; j < chars.GetLength(dimension: 1); j++)
        {
            if (i == 1 && j == 0)
            {
                sim += " ";
            }
            sim += chars[i, j];
        }
    }
    return sim;
}
string sim = makeString(chars); // 
System.Console.WriteLine(value: sim); // Функция выводит строку на печать