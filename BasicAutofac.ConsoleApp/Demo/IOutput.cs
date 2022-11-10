namespace BasicAutofac.ConsoleApp.Demo;

public interface IOutput
{
    void Write(string content);
}

public class ConsoleOutput : IOutput
{
    public void Write(string content)
    {
        Console.WriteLine(content);
    }
}
