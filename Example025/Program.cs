// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
int RaiseToADegree(int a, int b){
    int result = 1;
    for (int i = 1; i <= b; i++){
        result = result * a;
    }
    return result;
}
Console.Clear();
Console.WriteLine($"Число {a} в степени {b} равно {RaiseToADegree(a, b)}");
