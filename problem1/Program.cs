var list = new List<int>(){1, 5, 8, 12, 15, 20};

var result=from e in list
where e>10
select e;
foreach (var item in result)
{
    System.Console.WriteLine(item);
}