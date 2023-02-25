/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();
int size = asknum("размерность массива");
int[] array = GetArray(size);

Console.WriteLine($"[{String.Join(", ", array)}] -> {Counteven(array)}");

int asknum (string name)
{
    Console.Write($"Введите  {name}: ");
    int n = int.Parse(Console.ReadLine()!);
    return n; 
}


int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
  return array;
}

int Counteven(int[] array)
{
  int count = 0;
  foreach(int el in array)
  {
    if (el %2 == 0) count++;
  }
  return count;
}