// using AutoFixture;
//
// namespace DesignPatterns.Visitor;
//
// public class Context
// {
//     private readonly IFixture fixture = new Fixture();
//     private readonly Random random = new Random();
//
//     public (ICollection<IAmount> itemsInBytes, ICollection<IAmount> itemsInGB) GetData()
//     {
//         var inBytes = GetSizesInBytes().ToList();
//         var inGB = GetSizesInGB().ToList();
//         return (inBytes, inGB);
//     }
//
//     private static IEnumerable<IAmount> GetSizesInBytes()
//     {
//         yield return new AmountInBytes { Value = 1073741824 };
//         yield return new AmountInBytes { Value = 2147483648 };
//         yield return new AmountInBytes { Value = 3221225472 };
//     }
//
//     private static IEnumerable<IAmount> GetSizesInGB()
//     {
//         yield return new AmountInGB { Value = 10 };
//         yield return new AmountInGB { Value = 20 };
//         yield return new AmountInGB { Value = 30 };
//     }
// }
