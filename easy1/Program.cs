Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; i++)
{
    array [i] = new Random().Next(1, 101);
    if (array[i] % 3 == 0 && array[i] % 5 == 0 && array[i] % 7 != 0)
    {
    Console.WriteLine(array[i]);
    };
};