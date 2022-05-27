// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int RandomNumbers(int size, int min, int max)
{
    int[] array = new int[size];
    int sum = 0;
    Console.Write("Массив: ");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);

        Console.Write(array[i] + " ");

        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int array = RandomNumbers(size, 1, 10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, на нечётных позициях: {array}");
