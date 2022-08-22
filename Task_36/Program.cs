// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNeg = 0;
if (number == 0)
{
Console.Write("Вы ввели недопустимое значение");
return;
}
int[] GetArray(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(-100,100); 
}
return array;
}

    int[] SumNegative(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sumNeg = sumNeg + array[i] ;
    }
    return new int[] {sumNeg};
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

int[] arr = GetArray(number, 0, 100);
PrintArray(arr);
int [] diffMaxMin = SumNegative(arr);
Console.Write($"Сумма элементов находящихся на нечетных индексах: {sumNeg}");