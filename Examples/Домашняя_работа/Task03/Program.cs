// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементом массива.
double[] array = new double[7] {1.5 , 3.6 , 68.4 , 34.9 , 24.4 , 124.5 , 42.1 };
for(int i = 0; i < array.Length; i++ )
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
double DiffMinMax (double[] array )
{ 
    double max = array[0];
    double min = array[0];
    double MinMax = 0;
    for(int i = 0; i < array.Length ; i++ )
    {
        if(min > array[i])
        {
            min = array[i];
        }
        if(max < array[i])
        {
            max = array[i];
        }
    }  
    Console.WriteLine("min = " + min);
    Console.WriteLine("max = " + max);
    MinMax = max - min;
    return MinMax;
}
Console.WriteLine($"Разница между min и max элементом = {DiffMinMax(array)}");