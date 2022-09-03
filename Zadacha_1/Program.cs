/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write(" Количество чётных чисел в массиве -" );


for (int i =0; i< N; i++)
{
    array[i] = new Random().Next(100, 1000);
Console.Write( " "+(array[i]) );
}


int Count = 0;
for (int i =0; i< N; i++)
{
    if (array[i] % 2 == 0)
    {
        Count++;
    }
  
}    

Console.WriteLine(" равно  " + Count);
 
     