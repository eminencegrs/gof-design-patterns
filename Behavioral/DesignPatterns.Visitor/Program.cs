using DesignPatterns.Visitor;
using DesignPatterns.Visitor.Converters;

// var context = new Context();
// var discountVisitor = new SizeVisitor();
// var handler = new Handler(new[] { discountVisitor });
// var data = context.GetData();
// var convertedInGB = handler.Process(data.itemsInBytes);
// var convertedInBytes = handler.Process(data.itemsInGB);
//
// Console.WriteLine();

var strings = new List<string>
{
    "100KB",
    "200 KB",
    "10 MB",
    "200MB",
    "1GB",
    "20 GB"
};

var visitor = new StringVisitor();

var result = new List<ISize>();
result.AddRange(strings.Select(x => x.Accept(visitor)));

var amountVisitor = new SizeVisitor(
    new List<ISizeConverter<ISize>>
    {
        new KiloBytesToBytesConverter(),
        new MegaBytesToBytesConverter(),
        new GigaBytesToBytesConverter(),
        new TeraBytesToBytesConverter(),
        new PetaBytesToBytesConverter(),
    });

var newResult = new List<ISize>();
newResult.AddRange(result.Select(x => x.Accept(amountVisitor)));

Console.WriteLine();