Console.WriteLine("Возведем число А в степень равную натуральному числу В");
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
{
    int B_pos = B*(-1);
    double sum = Math.Pow(A, B_pos);
    Console.WriteLine(sum);
}
if (B > 0)
{
    double sum = Math.Pow(A, B);
    Console.WriteLine(sum);
}