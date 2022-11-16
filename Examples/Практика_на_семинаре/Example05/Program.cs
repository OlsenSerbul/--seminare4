// Найдите произведение пар чисел в одномерном массиве.
// пары - первый и последний, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
 

Console.Write("Сколько элементов будет в массиве? Ведите число:  ");
int Length = Convert.ToInt32(Console.ReadLine());
 
int[] array = new int[Length]; 

for (int i = 0; i < Length; i++ )
{
  Console.Write($"Введите элемент массива под номером  {i}: ");
   array[i] = Convert.ToInt32(Console.ReadLine());
}

 int number = 0; 
if(Length % 2 == 0)
{

    for( int i = 0; i < Length / 2; i++)
    {
       
       number = array[i] * array[array.Length - i - 1];
       
    }
    Console.Write($"Новый массив: {number} " + "  ");
}
