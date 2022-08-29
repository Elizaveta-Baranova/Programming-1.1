Console.Write("Введите первое число ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
{
    Console.Write("Максимальное число " + FirstNumber);
}
if (FirstNumber < SecondNumber && SecondNumber > ThirdNumber)
{
    Console.Write("Максимальное число " + SecondNumber);
}
if (FirstNumber < ThirdNumber && SecondNumber < ThirdNumber)
{
    Console.Write("Максимальное число " + ThirdNumber);
}