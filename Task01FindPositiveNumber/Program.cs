Console.WriteLine("Введите количество чисел ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int PrintArray (int [] array)
{
int count = 0;
for(int i = 0; i < M; i++) 
        { 
            if(array[i] > 0)
            {count = count +1;}
        }
 return count;
}
Console.WriteLine(PrintArray(array));