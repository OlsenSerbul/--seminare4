// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Сколько элементов будет в массиве? Ведите число:  ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Length];
for(int i = 0; i < Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
int SumNech(int[] array, int Length)
{
    int sumNech = 0;
    for(int i = 0 ; i < Length; i++ )
    {
       if( i % 2 > 0)
       {
           sumNech += array[i];
       } 
    }
    return sumNech;
}
int sumNech = SumNech(array, Length);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях  = {sumNech}");

