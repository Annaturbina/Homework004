Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
ToDegree(a, b);
void ToDegree(int a, int b)
{
    double result = 1;
    {
        result = result * Math.Pow(a, b);
    }
    Console.WriteLine($"{a}^{b}={result}");
}
