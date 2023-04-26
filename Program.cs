//Вывести максимальное и мнимальтное числа из 2-х введенных
Console.WriteLine("Введите 2 числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine($"max is {x}, min is {y}");
}
else
{
    Console.WriteLine($"max is {y}, min is {x}");
}




//Вывести максимальное число из 3-х введенных
Console.WriteLine("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b & a>c)
{
    Console.WriteLine($"max number is a");
}
else
{if (b>c & b>a)
    Console.WriteLine($"max number is b");
}
{if (c>a & c>b)
    Console.WriteLine($"max number is c");
}


//Проверка числа на четность
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
Console.WriteLine($"Введенное число четное");
else 
Console.WriteLine($"Введенное число нечетное");


//Вывод всех четных чисел от 1 до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= N; i += 2) Console.WriteLine(i);