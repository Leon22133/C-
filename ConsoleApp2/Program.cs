// See https://aka.ms/new-console-template for more information
float a, b, c;
string num1, num2;
string menu;
int menuUI;

do
{
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить 2 числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент из числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    menu = Console.ReadLine();
    menuUI = Convert.ToInt32(menu);

    if (menuUI == 1)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        a = Convert.ToInt32(num1);
        b = Convert.ToInt32(num2);

        Console.WriteLine(a + b);
    }
    if (menuUI == 2)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        a = Convert.ToInt32(num1);
        b = Convert.ToInt32(num2);

        Console.WriteLine(a - b);
    }
    if (menuUI == 3)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        a = Convert.ToInt32(num1);
        b = Convert.ToInt32(num2);

        Console.WriteLine(a * b);
    }
    if (menuUI == 4)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        a = Convert.ToInt32(num1);
        b = Convert.ToInt32(num2);

        Console.WriteLine(a / b);
    }
    if (menuUI == 5)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        a = Convert.ToInt32(num1);
        b = Convert.ToInt32(num2);

        Console.WriteLine(Math.Pow(a, b));
    }
    if (menuUI == 6)
    {
        Console.WriteLine("Введите число");

        num1 = Console.ReadLine();
        a = Convert.ToInt32(num1);

        Console.WriteLine("Квадратный корень от числа - " + Math.Sqrt(a));

    }
    if (menuUI == 7)
    {
        Console.WriteLine("Введите число");

        num1 = Console.ReadLine();
        a = Convert.ToInt32(num1);

        Console.WriteLine("1% От числа - " + (a / 100));

    }
    if (menuUI == 8)
    {
        Console.WriteLine("Введите число");
        num1 = Console.ReadLine();
        a = Convert.ToInt32(num1);
        c = 1;

        for (int i = 1; i < a + 1; i++)
        {
            c = c * i;
        }
        Console.WriteLine(c);
    }
} while (menuUI != 9);


