// Console.WriteLine("Введите первое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2== 0) Console.WriteLine("Не делиться на 0");
// else if (number1 % number2 == 0) Console.WriteLine($"{number1}, {number2} Кратно");
// else Console.WriteLine ($"{number1}, {number2} не кратно, остаток {number1 % number2}");


Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int number3 = number1 % number2;

if (number1 % number2 == 0)
    Console.WriteLine("Делимое кратно делимому");
else
    Console.WriteLine("Остаток "+ number3);