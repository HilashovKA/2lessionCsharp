int number = new Random().Next(10, 100); // [10, 99]
Console.WriteLine(number);
int digit1 = number / 10; // 74 / 10 = 7 (int)
int digit2 = number % 10; // 74 / 10 = 4
if (digit1 > digit2)
    Console.WriteLine(digit1);
else
    Console.WriteLine(digit2);
