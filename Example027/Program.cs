// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

//int NumDigets(int n)
//{
//    int count = 0;
//    while (n > 0)
//    {
//        n /= 10;
//        count++;
//    }
//    return count;
// }
//int SumDigets(int count){
//    int result = 0;
//   for (int i = 1; i <= count; i++){
//        result += i;
//   }
//    return result;
//}

//void SumDigets(int n, int count){
//    int result = 0;
//   for (int i= 1; i <= count; i++){
//        result += i;
//    }
//}
int sum = 0;
while (n > 0){
    int num = n % 10;
    n = n / 10;
    sum = sum + num;
}
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);
Console.Clear();
Console.WriteLine($"Сумма цифр равна {sum}");
