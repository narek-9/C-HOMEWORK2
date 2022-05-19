Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(number);

if(Number.Length < 3) {
    Console.WriteLine("Третьей цифры нет.");
}
else {
    Console.WriteLine("Третья цифра = " + Number[2]);
}

