// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите кол-во чисел");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] a = new int[n];
for(int i=0; i<n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
    if(a[i]>0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество положительных чисел: {sum}");