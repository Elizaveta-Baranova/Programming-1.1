Console.Write("Введите первое число ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.Write("Максимальное число " + FirstNumber + ", а минимальное число " + SecondNumber);
}
else
{
    Console.Write("Максимальное число " + SecondNumber + ", а минимальное число " + FirstNumber);
}