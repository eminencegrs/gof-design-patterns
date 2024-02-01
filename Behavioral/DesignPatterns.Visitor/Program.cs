using DesignPatterns.Visitor;

var context = new Context();
var handler = new Handler();
var data = context.GetData();
var sizes = handler.ProcessStrings(data.strings, [context.GetStringVisitor()]).ToList();
var finalSizes = handler.ProcessSizes(sizes, [context.GetSizeVisitor()]).ToList();

Console.WriteLine("| String Data | Sizes       | Final Sizes              |");
Console.WriteLine("|-------------|-------------|--------------------------|");

for (var i = 0; i < data.strings.Count; i++)
{
    Console.WriteLine($"| {data.strings.ElementAt(i),-11} | {sizes.ElementAt(i),-11} | {finalSizes.ElementAt(i),-24} |");
}
