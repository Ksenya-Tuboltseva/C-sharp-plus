Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < N; i++)
{
    if (N % i == 0)
    {
        Console.WriteLine("Число не является простым");
        break;
    }
    else
    {
        Console.WriteLine("Число является простым");
        break;
    }
};