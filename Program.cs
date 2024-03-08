namespace SynchronizationPlayground;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Console.WriteLine("Greetings and welcome to the thread synchronization playground!");
        Console.WriteLine("Please, make a selection in the main window.");

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Main());
    }
}
