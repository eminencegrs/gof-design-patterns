// namespace DesignPatterns.Visitor;
//
// public class Handler(IEnumerable<IVisitor> visitors)
// {
//     public IEnumerable<IAmount> Process(ICollection<IAmount> sizes)
//     {
//         var result = new List<IAmount>();
//         foreach (var visitor in visitors)
//         {
//             result.AddRange(sizes.Select(size => size.Accept(visitor)));
//         }
//
//         return result;
//     }
// }
