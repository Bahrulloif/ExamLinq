string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

var result= from e in words
orderby e.Length descending
select e;

foreach (var item in result)
{
    System.Console.WriteLine(item);
}