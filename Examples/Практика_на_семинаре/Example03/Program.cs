// Задайте массив. Напишите программу, которая
// определяет, присутсвует ли заданное число в массиве.
int[] array = new int[12] {1, 6, 78, 3, -5, -13, 45, 0, 21, 16, 20, 42 };
Console.Write("Введите искомое число:  ");
int X = Convert.ToInt32(Console.ReadLine());

bool SearchElement(int[] array, int X )
{
    for ( int i = 0; i < array.Length; i++ )
    {
        if(array[i] == X)
        {
            return true;
        }
    }
    return false;

}

Console.WriteLine(SearchElement(array, X ));
