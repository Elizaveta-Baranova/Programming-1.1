Console.Write("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.Write("Введенное число " + Number + " является четным");
}
else
{
    Console.Write("Введенное число " + Number + " является нечетным");
}