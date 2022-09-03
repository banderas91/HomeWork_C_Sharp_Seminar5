/*Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write(" разница  в массиве -" );


for (int i =0; i< N; i++)
{
    array[i] = new Random().Next(100, 1000);
Console.Write( " "+(array[i]) );
}


int max = array[0];
int min = array[0];

for (int i = 0; i < N; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("  между Максимальным "+ max + " и Минимальным  "+ min + " равна "+ (max - min) );
