﻿using DesignPatterns.Visitor.Converters;
using DesignPatterns.Visitor.Models;
using FluentAssertions.Execution;
using Shouldly;
using Xunit;

namespace DesignPatterns.Visitor.UnitTests.Converters;

public class MegaBytesToBytesConverterTests
{
    [Fact]
    public void GivenSize_WhenCallConvert_ThenConvertedSizeReturned()
    {
        var expectedResult = new SizeInBytes { Value = 1024L * 1024 };
        var size = new SizeInMegaBytes { Value = 1L };
        var sut = new MegaBytesToBytesConverter();
        ISize? actualResult = null;
        var action = () => actualResult = sut.Convert(size);

        using (new AssertionScope())
        {
            action.ShouldNotThrow();
            actualResult.ShouldNotBeNull();
            actualResult.ShouldBeEquivalentTo(expectedResult);
        }
    }

    [Fact]
    public void GivenSize_WhenCallConvert_ThenInvalidOperationExceptionThrown()
    {
        var sut = new MegaBytesToBytesConverter();
        var action = () => sut.Convert(null!);
        action
            .ShouldThrow<InvalidOperationException>()
            .Message.ShouldBe("Could not convert MegaBytes to Bytes.");
    }

    [Fact]
    public void GivenSize_WhenCallCanConvert_ThenTrueReturned()
    {
        var size = new SizeInMegaBytes { Value = 1 };
        var sut = new MegaBytesToBytesConverter();
        bool? actualResult = null;
        var action = () => actualResult = sut.CanConvert(size);

        using (new AssertionScope())
        {
            action.ShouldNotThrow();
            actualResult.ShouldNotBeNull();
            actualResult?.ShouldBeTrue();
        }
    }
}
