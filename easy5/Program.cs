Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
int sum = 0;
for (int i = 0; i < N; i++)
{
    sum = sum + array[i];
}
double average = sum / N;
for (int i = 0; i < N; i++)
{
    if (array[i] / average == 1)
    {
        Console.WriteLine("Yes");
        break;
    }
    else
    {
        Console.WriteLine("No");
        break;
    }
};