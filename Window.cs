using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;

namespace MiniProyecto1 {
    public class Window : GameWindow{

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings,nativeWindowSettings){}

        protected override void OnLoad()
        {
            GL.ClearColor(1.0f,1.0f,1.0f,1.0f);
            base.OnLoad();
        }
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            SwapBuffers();
            base.OnRenderFrame(args);
        }
        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Size.X, Size.Y);
            base.OnResize(e);
        }
        protected override void OnUnload()
        {
            base.OnUnload();
        }
    }
}