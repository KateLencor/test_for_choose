string[] Array;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
Array = stroka.Split(' ');
var result = new string[Array.Length];
var i = 0;
foreach (var element in Array)
{
    if (element.Length <= 3)
    {
        result[i] = element;
        i++;
    }
}
Console.WriteLine("Выборка элементов длинной до трех(включая) символов: ");
Console.WriteLine(string.Join(Environment.NewLine, result, 0, i));
