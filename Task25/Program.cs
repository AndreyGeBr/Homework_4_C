// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвращает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();
 
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
int pow = Power(a, b);

Console.Write($"Число {a} в степени {b} равно {pow}");


int Power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
       result *= a;
    }
    return result;
}
