namespace Console.Test;

public class ClearScriptRunnerTests
{
    private ClearScriptConsole _clearScriptRunner = new ();

    [Test]
    public async Task Test1()
    {
        await _clearScriptRunner.ExecuteAsync("Hello World", CancellationToken.None);
        Assert.Pass();
    }
}