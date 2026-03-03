using System.Collections;
using JetBrains.Annotations;
using NUnit.Framework;

namespace Ebceys.Tests.Infrastructure.Helpers.TestCaseSources;

/// <summary>
///     The test case source.
/// </summary>
/// <typeparam name="TData">The test data.</typeparam>
[PublicAPI]
public abstract class EbTestCaseSource<TData>
{
    /// <summary>
    ///     Setups the data, that will be used as base for test case functions.
    /// </summary>
    /// <returns>The new instance of <see cref="TData" />.</returns>
    public abstract TData SetupValidBase();

    /// <summary>
    ///     Setups the data, that will be used as base for test case functions.
    /// </summary>
    /// <returns>The new instance of <see cref="TData" />.</returns>
    public abstract TData? SetupInvalidBase();

    /// <summary>
    ///     Gets the test cases that should be valid.
    /// </summary>
    /// <returns></returns>
    public abstract IEnumerable<(Func<TData?, TData?>, string)> GetValidCases();

    /// <summary>
    ///     Gets the test cases that should be invalid.
    /// </summary>
    /// <returns></returns>
    public abstract IEnumerable<(Func<TData?, TData?>, string)> GetInvalidCases();
}

/// <summary>
///     The valid test case executor. Executes the <see cref="EbTestCaseSource{TData}.GetValidCases" />.
/// </summary>
/// <typeparam name="TData">The test data.</typeparam>
/// <typeparam name="TEnumerator">The test case enumerator</typeparam>
[PublicAPI]
public sealed class EbTestDataValidExecutor<TEnumerator, TData> : TestCaseEnumerator<TData>
    where TEnumerator : EbTestCaseSource<TData>
{
    private readonly TEnumerator _testCaseSource;

    /// <summary>
    ///     Initiates the new instance of <see cref="EbTestDataValidExecutor{TEnumerator,TData}" />.
    /// </summary>
    public EbTestDataValidExecutor()
    {
        _testCaseSource = Activator.CreateInstance<TEnumerator>();
    }

    /// <inheritdoc />
    protected override (IEnumerable<(Func<TData?, TData?>, string)> dataSource, TData? baseData) GetData()
    {
        return (GetCases(), _testCaseSource.SetupValidBase());
    }

    private IEnumerable<(Func<TData?, TData?>, string)> GetCases()
    {
        yield return (_ => _testCaseSource.SetupValidBase(), "Valid_Base");
        foreach (var validCase in _testCaseSource.GetValidCases())
        {
            yield return validCase;
        }
    }
}

/// <summary>
///     The invalid test case executor. Executes the <see cref="EbTestCaseSource{TData}.GetInvalidCases" />.
/// </summary>
/// <typeparam name="TData">The test data.</typeparam>
/// <typeparam name="TEnumerator">The test case enumearator.</typeparam>
[PublicAPI]
public sealed class EbTestDataInvalidExecutor<TEnumerator, TData> : TestCaseEnumerator<TData>
    where TEnumerator : EbTestCaseSource<TData>
{
    private readonly TEnumerator _testCaseSource;

    /// <summary>
    ///     Initiates the new instance of <see cref="EbTestDataInvalidExecutor{TEnumerator,TData}" />.
    /// </summary>
    public EbTestDataInvalidExecutor()
    {
        _testCaseSource = Activator.CreateInstance<TEnumerator>();
    }

    /// <inheritdoc />
    protected override (IEnumerable<(Func<TData?, TData?>, string)> dataSource, TData? baseData) GetData()
    {
        return new ValueTuple<IEnumerable<(Func<TData?, TData?>, string)>, TData?>(_testCaseSource.GetInvalidCases(),
            _testCaseSource.SetupInvalidBase());
    }
}

/// <summary>
///     The <see cref="TestCaseEnumerator{TData}" /> class.
/// </summary>
/// <typeparam name="TData"></typeparam>
[PublicAPI]
public abstract class TestCaseEnumerator<TData> : IEnumerable<TestCaseData>
{
    /// <summary>
    ///     Initiates the new instance of <see cref="TestCaseEnumerator{TData}" />.
    /// </summary>
    protected TestCaseEnumerator()
    {
        Cases = Enumerate();
    }

    private IEnumerable<TestCaseData> Cases { get; }

    /// <inheritdoc />
    public IEnumerator<TestCaseData> GetEnumerator()
    {
        return Cases.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    ///     Gets the data.
    /// </summary>
    /// <returns></returns>
    protected abstract (IEnumerable<(Func<TData?, TData?>, string)> dataSource, TData? baseData) GetData();

    private IEnumerable<TestCaseData> Enumerate()
    {
        var dataSource = GetData();
        foreach (var testCase in dataSource.dataSource)
        {
            var casted = EbTestCaseData<TData>.CreateFrom(testCase);
            yield return new TestCaseData(casted.PreparedData(dataSource.baseData))
                .SetArgDisplayNames(casted.TestDescription);
        }
    }
}

/// <summary>
///     The test case data.
/// </summary>
/// <param name="PreparedData">The func to prepare data to test case.</param>
/// <param name="TestDescription">The test descriptions.</param>
/// <typeparam name="TData">The data to test.</typeparam>
internal record EbTestCaseData<TData>(Func<TData?, TData?> PreparedData, string TestDescription)
{
    /// <summary>
    ///     Creates the new instance of <see cref="EbTestCaseData{TData}" /> by <paramref name="data" />.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The new instance of <see cref="EbTestCaseData{TData}" />.</returns>
    public static EbTestCaseData<TData> CreateFrom((Func<TData?, TData?>, string) data)
    {
        return new EbTestCaseData<TData>(data.Item1, data.Item2);
    }
}