// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int digit1 = number / 100;
// int digit2 = number % 10;
// int newnumber = digit1 * 10 + digit2;
// Console.WriteLine(newnumber);


int number = new Random().Next(100, 1000);
Console.WriteLine(number);
string str_number = number.ToString(); //836
char digit1 = str_number[0];
char digit3 = str_number[2];
string new_str_number = digit1.ToString() + digit3.ToString();
int new_number = Convert.ToInt32(new_str_number);
Console.WriteLine(new_number);