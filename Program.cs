using OpenTK_Tinkering;

class Program
{
    static void Main(string[] args)
    {
        using (Window window = new Window(800, 600, "OpenTK_Window"))
        {
            window.Run();
        }
    }
}