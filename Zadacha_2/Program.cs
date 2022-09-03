/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

[3, 7, 23, 12] -> 12
[4, 6, 8, 1, 4] -> 6
*/

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write(" сумма четных чисел в массиве, на не чётных позициях -" );


for (int i =0; i< N; i++)
{
    array[i] = new Random().Next(-999, 999);
Console.Write( " "+(array[i]) );
}


int Summ = 0;
for (int i =0; i< N; i++)
{
    if (array[i] % 2 == 0 && i % 2 > 0)
    {
        Summ = Summ + array[i];
    }
  
}    

Console.WriteLine(" равно  " + Summ);
 
     