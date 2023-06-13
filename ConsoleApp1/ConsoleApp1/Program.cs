int[] Mas = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
var str = string.Join(" ", Mas);
Console.WriteLine(str);
Console.Write("Введите первое число: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int two = Convert.ToInt32(Console.ReadLine());

if (one <= Mas.Length && two <= Mas.Length)
{
    Console.WriteLine("Сумма элементов массива: {0} ", Mas[one] + Mas[two]);
}
else
    Console.WriteLine("Произошла ошибка!");
Console.ReadLine();