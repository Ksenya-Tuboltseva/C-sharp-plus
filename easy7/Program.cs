Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (N > 100)
{
    for (int i = 1; i <= N; i++)
    {
        if (N % i != 0);
        {
            count = count + 1;
        }
        Console.WriteLine(count);
    }
}
else
{
    Console.WriteLine("Число меньше 100");
}