/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


Console.Clear();
int size = asknum("размерность массива");
int[] array = GetArray(size);

Console.WriteLine($"[{String.Join(", ", array)}] -> {raz(array)}");

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
    array[i] = new Random().Next(0, 100);
  }
  return array;
}


int raz (int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach(int el in array)
    {
        if (el > max) max = el;
        else if (el<min) min = el;
    }
    int raz = max - min;
    return raz;

}