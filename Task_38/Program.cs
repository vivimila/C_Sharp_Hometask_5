//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

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
array[i] = new Random().Next(1,50); // дала ограничение для удобной проверки
}
return array;
}

    int[] GetDiffMaxMin(int [] array)
{
    int maxNum = array[0];
    int minNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[0]) minNum = array[i];
        if(array[i] > array[0]) maxNum = array[i];
    }
    count = maxNum - minNum;
    return new int[] {count};
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
Console.Write($"{array[i]},");
}
Console.WriteLine($"{array[array.Length - 1]}]");
}

int[] arr = GetArray(number);
PrintArray(arr);
int [] diffMaxMin = GetDiffMaxMin(arr);
Console.Write($"Разница между максимальным и минимальным значаниями в массиве: {count}");

