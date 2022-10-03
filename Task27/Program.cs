//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();
 
Console.Write("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));

int result = 0;
SumNumbers ();

Console.WriteLine(result);



void SumNumbers ()
{
    while (number > 0)
    {
        int digit = number % 10;
        result = result + digit;
        number = number / 10;
    }
}


