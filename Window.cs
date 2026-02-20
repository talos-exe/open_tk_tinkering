using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTK_Tinkering
{
    public class Window : GameWindow
    {
        /// <summary>
        /// Creates a constructor of the standard OpenTK GameWindow.
        /// </summary>
        /// <param name="width">The width of the window, in pixels.</param>
        /// <param name="height">The height of the window, in pixels.</param>
        /// <param name="title">The title of the window.</param>
        public Window(Int32 width, Int32 height, String title) : base(GameWindowSettings.Default, new NativeWindowSettings() { ClientSize = (width, height), Title = title }) { }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }
        }

    }
}
