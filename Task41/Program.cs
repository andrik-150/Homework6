/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите числа M: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] massiveNum = new int[n];

void InputNum(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($" Введите {i+1} число: ");
        massiveNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Comparison(int[] massiveNum)
{
    int count = 0;
    for (int i = 0; i < massiveNum.Length; i++)
    {
        if (massiveNum[i] > 0) count += 1;
    }
    return count;
}
InputNum(n);
Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNum)}");