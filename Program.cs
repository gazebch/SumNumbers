// See https://aka.ms/new-console-template for more information

var r = new Random();
var mas = Enumerable.Repeat(0, 20).Select(x => r.Next(1, 150)).ToArray();
Console.WriteLine("входной массив");
Console.WriteLine(string.Join(" ", mas.Select(x => x.ToString()).ToArray()));

var sortMas = mas.OrderBy(s => SumDigit(s));

Console.WriteLine("отсортированный массив по сумме цифр");
Console.WriteLine(string.Join(" ", sortMas.Select(x => x.ToString()).ToArray()));

int SumDigit(int dig)
{
    var sum = 0;
    while (dig != 0)
    {
        sum += dig % 10;
        dig /= 10;
    }
    return sum;
};

