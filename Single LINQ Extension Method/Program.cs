// See https://aka.ms/new-console-template for more information


Console.WriteLine(" ------------> Learn LINQ: Filter with Where()  <----------- \n ");



IEnumerable<int> collection = [1, 2, 3, 4, 5];
var data = collection.Where(x => x > 2);

foreach (var item in data)
{
    Console.WriteLine(item);
}


Console.WriteLine("------------> Learn: Filtering by Type using OfType<T>() <------------ \n");


IEnumerable<object> collection1 = [1, 2, "eakub", 5, 4.700, 9.80, "islam"];

List<int> intData = collection1.OfType<int>().ToList();

List<double> doubleData = collection1.OfType<double>().ToList();
List<string> stringData = collection1.OfType<string>().ToList();

foreach (var item in intData)
{
    Console.Write(" " +item);
}
foreach (var item in doubleData)
{
    Console.Write(" " + item);
}
foreach (var item in stringData)
{
    Console.Write(" " + item);
} //