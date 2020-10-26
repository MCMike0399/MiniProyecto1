using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;

namespace MiniProyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nativeWindowSettings = new NativeWindowSettings()
            {
                Size = new Vector2i(800, 600),
                Title = "MiniProyecto 1",
            };
            using (var window = new Window(GameWindowSettings.Default, nativeWindowSettings))
            {
                window.Run();
            }
        }
    }
}
