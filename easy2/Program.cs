Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; i++)
{
    array [i] = new Random().Next(-100, 101);
}
int quantityOfPositive = 0;
int j = 0;
int sum = 0;
if (array[j] > 0)
{
    quantityOfPositive += 1;
    sum += array[j];
}
Console.WriteLine(quantityOfPositive);
Console.WriteLine(sum);