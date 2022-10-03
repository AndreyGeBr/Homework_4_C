// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода


Random random = new Random();
int size = 8;
int[] numbers = new int[size];
Console.WriteLine ($"Размер массива {size}");

FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 100);
    }
} 

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }
}
