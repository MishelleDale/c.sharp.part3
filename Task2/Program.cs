Console.WriteLine("Найдем сумму цифр введенного числа");
Console.WriteLine("Введите число: ");
int num, sum = 0, r;
num = Convert.ToInt32(Console.ReadLine());
while (num != 0)
    {
    r = num %10;
    num = num / 10;
    sum = sum + r;
    }
Console.WriteLine("Сумма цифр числа: " + sum);
Console.ReadLine();
 
 
 
        