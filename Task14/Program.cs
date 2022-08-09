Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

if (num % number1 == 0 & num % number2 == 0)
    Console.WriteLine("Кратно");
else 
    Console.WriteLine("Не кратно");
