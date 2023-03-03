// See https://aka.ms/new-console-template for more information

using Console;

static class Program
{
    static async Task<int> Main(string[] args)
    {
        if (args.Length > 0)
        {
            var runner = new ClearScriptConsole();
            await runner.ExecuteAsync(args[0], CancellationToken.None);
        }
        return 0;
    }
}