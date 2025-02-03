namespace AssafFinkelshtein;

public class Logger : IDisposable
{
    private readonly string _logFileName = Path.Combine("Logs", "Logger.txt");
    private readonly StreamWriter writer;

    public Logger()
    {
        if (!Directory.Exists("Logs"))
            Directory.CreateDirectory("Logs");

        writer = new StreamWriter(_logFileName, true);
    }

    public async Task Log(string message)
    {
        await writer.WriteLineAsync(DateTime.Now + ":\t" + message);
    }

    public void Dispose()
    {
        writer.Dispose();
    }
}
