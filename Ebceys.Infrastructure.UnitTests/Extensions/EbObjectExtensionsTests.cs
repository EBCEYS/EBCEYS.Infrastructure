using AwesomeAssertions;
using Ebceys.Infrastructure.Extensions;
using Ebceys.Tests.Infrastructure.Helpers;

namespace Ebceys.Infrastructure.UnitTests.Extensions;

public class EbObjectExtensionsTests
{
    private static readonly EbRandomizer Randomizer = new();

    // ── ToUInt ──────────────────────────────────────────────────────────────

    [TestCase(0)]
    [TestCase(1)]
    [TestCase(int.MaxValue)]
    public void When_ToUInt_With_NonNegativeInt_Result_SameValue(int value)
    {
        var result = value.ToUInt();

        result.Should().Be((uint)value);
    }

    [Test]
    public void When_ToUInt_With_NegativeInt_Result_OverflowCast()
    {
        const int value = -1;

        var result = value.ToUInt();

        result.Should().Be(uint.MaxValue);
    }

    // ── ToULong ─────────────────────────────────────────────────────────────

    [TestCase(0L)]
    [TestCase(1L)]
    [TestCase(long.MaxValue)]
    public void When_ToULong_With_NonNegativeLong_Result_SameValue(long value)
    {
        var result = value.ToULong();

        result.Should().Be((ulong)value);
    }

    [Test]
    public void When_ToULong_With_NegativeLong_Result_OverflowCast()
    {
        const long value = -1L;

        var result = value.ToULong();

        result.Should().Be(ulong.MaxValue);
    }

    // ── ToDiagnosticJson ─────────────────────────────────────────────────────

    [Test]
    public void When_ToDiagnosticJson_With_SimpleObject_Result_ValidJson()
    {
        var obj = new { Id = 1, Name = "Test" };

        var json = obj.ToDiagnosticJson();

        json.Should().NotBeNullOrEmpty();
        json.Should().Contain("\"id\"").And.Contain("\"name\"");
    }

    [Test]
    public void When_ToDiagnosticJson_With_Null_Result_NullLiteral()
    {
        object? obj = null;

        var json = obj!.ToDiagnosticJson();

        json.Should().Be("null");
    }

    [Test]
    public void When_ToDiagnosticJson_With_Enum_Result_StringRepresentation()
    {
        var obj = new { Status = DayOfWeek.Monday };

        var json = obj.ToDiagnosticJson();

        json.Should().Contain("Monday");
    }

    // ── ToJson ───────────────────────────────────────────────────────────────

    [Test]
    public void When_ToJson_With_SimpleObject_Result_ValidJson()
    {
        var obj = new { Id = 42, Value = "hello" };

        var json = obj.ToJson();

        json.Should().NotBeNullOrEmpty();
        json.Should().Contain("42").And.Contain("hello");
    }

    [Test]
    public void When_ToJson_With_Null_Result_NullLiteral()
    {
        object? obj = null;

        var json = obj!.ToJson();

        json.Should().Be("null");
    }

    // ── IsNullOrEmpty ─────────────────────────────────────────────────────────

    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase(" ", false)]
    [TestCase("a", false)]
    public void When_IsNullOrEmpty_With_VariousStrings_Result_CorrectBool(string? value, bool expected)
    {
        value.IsNullOrEmpty().Should().Be(expected);
    }

    // ── IsNullOrWhiteSpace ────────────────────────────────────────────────────

    [TestCase(null, true)]
    [TestCase("", true)]
    [TestCase("   ", true)]
    [TestCase("a", false)]
    [TestCase(" a ", false)]
    public void When_IsNullOrWhiteSpace_With_VariousStrings_Result_CorrectBool(string? value, bool expected)
    {
        value.IsNullOrWhiteSpace().Should().Be(expected);
    }

    // ── Join ─────────────────────────────────────────────────────────────────

    [Test]
    public void When_Join_With_MultipleStrings_Result_ConcatenatedWithSeparator()
    {
        string[] values = ["a", "b", "c"];

        var result = values.Join(", ");

        result.Should().Be("a, b, c");
    }

    [Test]
    public void When_Join_With_EmptyCollection_Result_EmptyString()
    {
        string[] values = [];

        var result = values.Join(", ");

        result.Should().BeEmpty();
    }

    [Test]
    public void When_Join_With_SingleElement_Result_ElementWithoutSeparator()
    {
        var value = Randomizer.String(8);
        string[] values = [value];

        var result = values.Join("-");

        result.Should().Be(value);
    }

    [Test]
    public void When_Join_With_EmptySeparator_Result_ConcatenatedStrings()
    {
        string[] values = ["foo", "bar", "baz"];

        var result = values.Join(string.Empty);

        result.Should().Be("foobarbaz");
    }
}