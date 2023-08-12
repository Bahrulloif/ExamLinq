
var list = new List<int>(){1, 5, 8, 12, 15, 20};
var result=(from e in list
where e%2==1
select e).Sum();

System.Console.WriteLine(result);