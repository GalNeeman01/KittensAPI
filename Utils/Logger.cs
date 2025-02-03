namespace AssafFinkelshtein;

public class Logger
{
    private readonly string _logFileName = Path.Combine("Logs", "Logger.txt");

    public Logger()
    {
        if (!Directory.Exists("Logs"))
            Directory.CreateDirectory("Logs");
    }
    
    public async Task Log(string message)
    {
        using StreamWriter writer = new StreamWriter(_logFileName, true);
        await writer.WriteLineAsync(DateTime.Now + ":\t" + message);
    }
}
