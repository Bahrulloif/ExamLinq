
List<Person> people = new List<Person>
{
new Person { Name = "Alice", Age = 20 },
new Person { Name = "Bob", Age = 30 },
new Person { Name = "Charlie", Age = 20 },
new Person { Name = "Dave", Age = 30 },
};

var result=(from e in people
group e by e.Age into gr
select new {
    Age=gr.Key,
    Count=gr.Count()
}).ToList();

foreach (var item in result)
{
    System.Console.WriteLine(item);
}


class Person
{
public string Name { get; set; }
public int Age { get; set; }
}
