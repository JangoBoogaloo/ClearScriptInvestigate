using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;

namespace Console;

public class ClearScriptConsole
{
    public async Task ExecuteAsync(string message, CancellationToken token)
    {
        try
        {
            var constraints = new V8RuntimeConstraints
            {
                MaxArrayBufferAllocation = 20,
                MaxNewSpaceSize = 20,
                MaxOldSpaceSize = 20,
            };
            using var engine = new V8ScriptEngine(constraints);
            engine.AddHostType("Console", HostItemFlags.GlobalMembers, typeof(System.Console));
            engine.Execute("function allocateMemory() { array = []; for(let i = 0; i <= 1000; i++) { array.push((new Array(999999999)).fill('aaaa')); } }");
            engine.Script.allocateMemory();
        }
        catch (ScriptEngineException ex)
        {
            await System.Console.Error.WriteLineAsync(ex.ErrorDetails);
        }
    }
}