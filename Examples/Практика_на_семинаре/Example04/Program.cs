// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10;99].

int[] array = new int[123];
int count = 0;
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-100, 1000);
    Console.Write(array[i] + "  ");
}
for(int i = 0; i < array.Length; i++ )
{
    if(array[i] > 11 && array[i] < 100)
    {
        count++;

    }
}
Console.WriteLine();
Console.WriteLine($"Количество элементов = {count}");
