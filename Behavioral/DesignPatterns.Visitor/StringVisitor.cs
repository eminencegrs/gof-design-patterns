using System.Text.RegularExpressions;
using DesignPatterns.Visitor.Models;

namespace DesignPatterns.Visitor;

public class StringVisitor : IVisitor<string, ISize>
{
    public ISize Visit(string size)
    {
        if (string.IsNullOrWhiteSpace(size))
        {
            throw new ArgumentException("Input size string cannot be null or empty.", nameof(size));
        }

        var regexPattern = @"^(?<value>\d+(\.\d+)?)\s*(?<unit>[KMGTPE]?B)$";
        var match = Regex.Match(size, regexPattern, RegexOptions.IgnoreCase);

        if (!match.Success)
        {
            throw new ArgumentException("Could not parse the provided value.", nameof(size));
        }

        var value = long.Parse(match.Groups["value"].Value);
        var unit = match.Groups["unit"].Value.ToUpper();

        return unit switch
        {
            "KB" => new SizeInKiloBytes { Value = value },
            "MB" => new SizeInMegaBytes { Value = value },
            "GB" => new SizeInGigaBytes { Value = value },
            "TB" => new SizeInTeraBytes { Value = value },
            "PB" => new SizeInPetaBytes { Value = value },
            _ => throw new ArgumentOutOfRangeException(nameof(size), "Unknown size unit.")
        };
    }
}
