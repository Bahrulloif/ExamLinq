int[] numbers = { 5, 8, 12, 15, 20, 25, 30 };
var result = (from e in numbers
orderby e descending
select e).Take(3);

foreach (var item in result)
{
    System.Console.WriteLine(item);
}