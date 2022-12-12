Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; i++)
{
    array [i] = new Random().Next(1, 101);
}

int sum = 0; //сумма чисел массива
for (int i = 0; i < N; i++)
{
    sum = (sum + array[i]);
}
double A = sum / N; //среднее арифметическое
Console.WriteLine(A);

int multi = 1; //результат перемножения чисел множества
for (int i = 0; i < N; i++)
{
    multi = multi * array[i];
}
double B = Math.Pow(multi, 1.0/N); //среднее геометрическое
Console.WriteLine(B);