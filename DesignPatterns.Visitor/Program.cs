using DesignPatterns.Visitor;

var context = new Context();
var discountVisitor = new SizeVisitor();
var handler = new Handler(new[] { discountVisitor });
var data = context.GetData();
var convertedInGB = handler.Process(data.itemsInBytes);
var convertedInBytes = handler.Process(data.itemsInGB);

Console.WriteLine();