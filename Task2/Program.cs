/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();
int size = asknum("размерность массива");
int[] array = GetArray(size);

Console.WriteLine($"[{String.Join(", ", array)}] -> {sumUnevenNumbers(array)}");

int asknum (string name)
{
    Console.Write($"Введите  {name}: ");
    int n = int.Parse(Console.ReadLine()!);
    return n; 
}


int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(-100, 100);
  }
  return array;
}

int sumUnevenNumbers (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
  {
    sum +=array[i];
  }
  return sum; 
}
