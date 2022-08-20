// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 0)
{
Console.Write("Вы ввели недопустимое значение");
return;
}
int[] GetArray(int size)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(100,1000);
}
return array;
}
int[] result = GetArray(number);

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 1; i < array.Length; i++)
{
    if (array[i] % 2 == 0) // вносим проверку на четность
    count++;
    
Console.Write($"{array[i]},");
}
Console.Write($"{array[array.Length - 1]}]");
}

PrintArray(result);
Console.Write($"Количество четных чисел в массиве: {count}");