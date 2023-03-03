namespace Console.Test;

public class ClearScriptRunnerTests
{
    private ClearScriptConsole _clearScriptRunner = new ();
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        _clearScriptRunner.Execute("Hello World", CancellationToken.None);
        Assert.Pass();
    }
}