//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int diffMaxMin = 0;
if (number == 0)
{
Console.Write("Вы ввели недопустимое значение");
return;
}


int[] GetArray(int size, int maxNum, int minNum)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(1,20);
}
return array;
}

int GetDiffMaxMin (int[] array)
{
    int maxNum = 0;
    int minNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum) maxNum +=array[i];
        else maxNum = array[i];
        if (array[i] < minNum) minNum +=array[i];
        else minNum = array[i];
    }
    int diffMaxMin = maxNum - minNum;
    return array;
}

int[] result = GetArray(number);
int result2 = GetDiffMaxMin(array);


// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 1; i < array.Length; i++)
// {
 
// Console.Write($"{array[i]},");
// }
// Console.Write($"{array[array.Length - 1]}]");
// }

// PrintArray(result);
Console.Write($"Количество четных чисел в массиве: {diffMaxMin}");