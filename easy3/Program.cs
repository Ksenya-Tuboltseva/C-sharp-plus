Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; i++)
{
    array [i] = new Random().Next(-100, 101);
if (array[i] < 0)
{
    Console.WriteLine("Yes");
    break;
}
else
{
    Console.WriteLine("No");
}
};