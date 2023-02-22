// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// от 10 до 50

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    { 
        result[i] = new Random().Next(10, 50);
    }
    return result;
}
int[] array = GetBinaryArray(8);


for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}