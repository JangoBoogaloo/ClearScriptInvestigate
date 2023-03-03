using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;

namespace Console;

public class ClearScriptConsole
{
    public async Task ExecuteAsync(string message, CancellationToken token)
    {
        try
        {
            using var engine = new V8ScriptEngine();
            engine.AddHostType("Console", HostItemFlags.GlobalMembers, typeof(System.Console));
            engine.Script.Console.WriteLine(message);
        }
        catch (ScriptEngineException ex)
        {
            await System.Console.Error.WriteLineAsync(ex.ErrorDetails);
        }
    }
}