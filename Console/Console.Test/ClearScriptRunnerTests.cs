using Microsoft.ClearScript.V8;

namespace Console.Test;

public class ClearScriptRunnerTests
{
    private ClearScriptConsole _clearScriptRunner = new ();

    [Test]
    public async Task Test1()
    {
        V8Settings.GlobalFlags = V8GlobalFlags.DisableJITCompilation;
        await _clearScriptRunner.ExecuteAsync("Hello World", CancellationToken.None);
        Assert.Pass();
    }
}