// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Сколько элементов будет в массиве? Ведите число:  ");
int Length = Convert.ToInt32(Console.ReadLine());
 
int[] array = new int[Length];
for(int i = 0; i < Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
int CountChet (int[] array, int Length)
{
   int count = 0;
   for(int i = 0; i < Length; i++ )
   {
      if (array[i] % 2 == 0)
      {
        count++;
      }
   }
   return count;
}   
int count = CountChet(array, Length);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");
