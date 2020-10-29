using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace MiniProyecto1 {
    public class Window : GameWindow{

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings,nativeWindowSettings){}

        private readonly float[] _vertices =
        {
            // Position         Texture coordinates
             0.5f,  0.5f, 0.0f, 1.0f, 1.0f, // top right
             0.5f, -0.5f, 0.0f, 1.0f, 0.0f, // bottom right
            -0.5f, -0.5f, 0.0f, 0.0f, 0.0f, // bottom left
            -0.5f,  0.5f, 0.0f, 0.0f, 1.0f  // top left
        };
        private readonly uint[] _indices =
        {
            0, 1, 3,
            1, 2, 3
        };
        private int ebo;
        private int vbo;
        private int vao;
        private Shader shader;
        private Texture texture;
        bool flag = false;
        bool flag2 = false;
        private readonly float[] vertices2 = {
            0.0f*0.001f,1.0f*0.001f, 0.0f*0.001f,
            -(122.0f / 175.0f)*0.001f,(125.0f / 175.0f)*0.001f, 0.0f*0.001f,
            -1.0f*0.001f,0.0f*0.001f, 0.0f*0.001f,
            -(122.0f / 175.0f)*0.001f, -(125.0f / 175.0f)*0.001f, 0.0f*0.001f,
            0.0f*0.001f,-1.0f*0.001f, 0.0f*0.001f,
            (122.0f / 175.0f)*0.001f, -(125.0f / 175.0f)*0.001f, 0.0f*0.001f,
            1.0f*0.001f,0.0f*0.001f, 0.0f*0.001f,
            (122.0f / 175.0f)*0.001f, (125.0f / 175.0f)*0.001f, 0.0f*0.001f
        };
        private int vbo2;
        private int vao2;
        private Shader shader2;

        protected override void OnLoad()
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);

            vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            ebo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, _indices.Length * sizeof(uint), _indices, BufferUsageHint.StaticDraw);
            shader = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag.glsl");
            shader.Use();
            texture = new Texture("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Texturas\\sun.jpg");
            texture.Use();
            vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
            var vertexLocation = shader.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            var texCoordLocation = shader.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation);
            GL.VertexAttribPointer(texCoordLocation, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            //Triángulo Rojo de Prueba
            vbo2 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo2);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices2.Length * sizeof(float), vertices2, BufferUsageHint.StaticDraw);
            shader2 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag2.glsl");
            shader2.Use();
            vao2 = GL.GenVertexArray();
            GL.BindVertexArray(vao2);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            base.OnLoad();
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.BindVertexArray(vao);
            var transform = Matrix4.Identity;
            var transform2 = Matrix4.Identity;
            var transform3 = Matrix4.Identity;
            float tiempo = (float)GLFW.GetTime();
            
            if(tiempo<8) {
                if(tiempo > 2.5) {
                    flag = true;
                }
                transform *= Matrix4.CreateScale(0.3f*tiempo);            
            }
            else { //Ya terminó de crecer
                transform *= Matrix4.CreateScale(0.3f*8);
            }
            texture.Use();
            shader.Use();
            shader.SetMatrix4("transform",transform); 
            GL.DrawElements(PrimitiveType.Triangles, _indices.Length, DrawElementsType.UnsignedInt, 0);
            shader2.Use();
            
            if(flag) {
                GL.BindVertexArray(vao2);
                if(tiempo<24){
                    transform2 *= Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(2*MathHelper.Pi));
                    transform2 *= Matrix4.CreateScale(40.0f*tiempo); 
                }
                else {
                    transform2 *= Matrix4.CreateScale(40f*24);
                }
                shader2.SetMatrix4("transform2",transform2);
            }
            if(flag2) {
                transform2 *= Matrix4.CreateScale(tiempo); 
                
            }
            GL.DrawArrays(PrimitiveType.TriangleFan, 0, 9); 
            SwapBuffers();
            base.OnRenderFrame(e);
        }
         protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Size.X, Size.Y);
            base.OnResize(e);
        }
        protected override void OnUnload()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.UseProgram(0);
            GL.DeleteBuffer(vbo);
            GL.DeleteVertexArray(vao);
            GL.DeleteProgram(shader.Handle);
            GL.DeleteTexture(texture.Handle);
            base.OnUnload();
        }
    }
}