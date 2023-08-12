string[] names = { "Alica", "Anna", "Amy", "Dave", "Alex" };

var result=from e in names
where e.StartsWith("A") && e.EndsWith("a")
select e;

foreach (var item in result)
{
    System.Console.WriteLine(item);
}