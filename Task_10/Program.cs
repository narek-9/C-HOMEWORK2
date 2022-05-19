Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int SecondDigit = num / 10 % 10;
Console.WriteLine(SecondDigit);