// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool Palindrom(string symbol)
{
    for (int i = 0; i < symbol.Length / 2; i++)

        if (symbol[i] != symbol[symbol.Length - i - 1])
            return false;
    return true;
}
string symbol;
Console.WriteLine("Проверка на палиндром\nВведите строку:");
symbol = Console.ReadLine()!;
if (Palindrom(symbol))
    Console.WriteLine("Эта строка - палиндром");
else Console.WriteLine("Эта строка - не палиндром");