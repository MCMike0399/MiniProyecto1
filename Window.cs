using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;

namespace MiniProyecto1 {
    public class Window : GameWindow{

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings,nativeWindowSettings){}
        private readonly float[] verticesSemillas = {
            0.1f, -0.1f, 0.0f,  1.0f,0.0f, 
            0.1f, 0.1f, 0.0f,  1.0f,1.0f, 
            -0.1f, 0.1f, 0.0f,  0.0f, 1.0f, 
            -0.1f, -0.1f, 0.0f,  0.0f, 0.0f 
        };
        private readonly uint[] indices15 = {
            0, 1, 3,
            1, 2, 3
        };
        private int ebo15;
        private int vbo15;
        private int vao15;
        private Shader shader15;
        private Texture texture15;
        private readonly float[] hojaDiagDerInf = {
            (122.0f / 175.0f), -(125.0f / 175.0f),0.0f,
            (95.0f / 175.0f), -(39.0f/ 175.0f),0.0f,
            (25.0f / 175.0f), -(17.0f / 175.0f),0.0f,
            (42.0f / 175.0f), -(85.0f / 175.0f),0.0f
        };
        private int vbo14;
        private int vao14;
        private Shader shader14;
        private readonly float[] hojaDiagIzqInf = {
            -(122.0f / 175.0f), -(125.0f / 175.0f),0.0f,
            -(95.0f / 175.0f), -(39.0f / 175.0f),0.0f,
            -(25.0f / 175.0f), -(17.0f / 175.0f),0.0f,
            -(42.0f / 175.0f), -(85.0f / 175.0f),0.0f
        };
        private int vbo13;
        private int vao13;
        private Shader shader13;
        private readonly float[] hojaDiagDerSup = {
            (122.0f / 175.0f), (125.0f / 175.0f),0.0f,
            (95.0f / 175.0f), (39.0f / 175.0f),0.0f,
            (25.0f / 175.0f), (17.0f / 175.0f),0.0f,
            (42.0f / 175.0f), (85.0f / 175.0f),0.0f
        };
        private int vbo12;
        private int vao12;
        private Shader shader12;
        private readonly float[] hojaDiagIzqSup = {
            -(122.0f / 175.0f), (125.0f / 175.0f),0.0f,
            -(95.0f / 175.0f), (39.0f / 175.0f),0.0f,
            -(25.0f / 175.0f), (17.0f / 175.0f),0.0f,
            -(42.0f / 175.0f), (85.0f / 175.0f),0.0f
        };
        private int vbo11;
        private int vao11;
        private Shader shader11;
        private readonly float[] hojaIzquierda = {
            -(60.0f / 175.0f),0.0f,0.0f,
            -(111.5f / 175.0f), (28.0f / 175.0f),0.0f,
            -1.0f, 0.0f,0.0f,
            -(111.5f / 175.0f), -(28.0f / 175.0f),0.0f
        };
        private int vbo10;
        private int vao10;
        private Shader shader10;
        private readonly float[] hojaDerecha = {
            (60.0f / 175.0f),0.0f,0.0f,
            (111.5f / 175.0f), (28.0f / 175.0f),0.0f,
            1.0f, 0.0f,0.0f,
            (111.5f / 175.0f), -(28.0f / 175.0f),0.0f
        };
        private int vbo9;
        private int vao9;
        private Shader shader9;
        private readonly float[] hojaAbajo = {
            0.0f, -(60.0f / 175.0f),0.0f,
            (28.0f / 175.0f), -(111.5f / 175.0f),0.0f,
            0.0f, -1.0f,0.0f,
            (-28.0f / 175.0f), -(111.5f / 175.0f),0.0f
        };
        private int vbo8;
        private int vao8;
        private Shader shader8;
        private readonly float[] hojaArriba = {
            0.0f, (60.0f/175.0f),0.0f,
            (28.0f / 175.0f), (111.5f / 175.0f),0.0f,
            0.0f, 1.0f,0.0f,
            (-28.0f / 175.0f), (111.5f / 175.0f),0.0f
        };
        private int vbo7;
        private int vao7;
        private Shader shader7;
        private readonly float[] verticesAire = {
            1.0f, -1.0f, 0.0f,  1.0f,0.0f, 
            1.0f, -(125.0f/175.0f), 0.0f,  1.0f,1.0f, 
            (122.0f/175.0f), -(125.0f/175.0f), 0.0f,  0.0f, 1.0f, 
            (122.0f/175.0f), -1.0f, 0.0f,  0.0f, 0.0f 
        };
        private readonly uint[] indices6 = {
            0, 1, 3,
            1, 2, 3
        };
        private int ebo6;
        private int vbo6;
        private int vao6;
        private Shader shader6;
        private Texture texture6;
        private readonly float[] verticesFuego = {
            -1.0f, -1.0f, 0.0f,  0.0f,0.0f, 
            -1.0f, -(125.0f/175.0f), 0.0f,  0.0f,1.0f, 
            -(122.0f/175.0f), -(125.0f/175.0f), 0.0f,  1.0f, 1.0f, 
            -(122.0f/175.0f), -1.0f, 0.0f,  1.0f, 0.0f 
        };
        private readonly uint[] indices5 = {
            0, 1, 3,
            1, 2, 3
        };
        private int ebo5;
        private int vbo5;
        private int vao5;
        private Shader shader5;
        private Texture texture5;
        private readonly float[] verticesTierra = {
            -1.0f, 1.0f, 0.0f,  0.0f,1.0f, 
            -1.0f, (125.0f/175.0f), 0.0f,  0.0f,0.0f, 
            -(122.0f/175.0f), (125.0f/175.0f), 0.0f,  1.0f, 0.0f, 
            -(122.0f/175.0f), 1.0f, 0.0f,  1.0f, 1.0f 
        };
        private readonly uint[] indices4 = {
            0, 1, 3,
            1, 2, 3
        };
        private int ebo4;
        private int vbo4;
        private int vao4;
        private Shader shader4;
        private Texture texture4;
        private readonly float[] verticesAgua = {
            1.0f, 1.0f, 0.0f,  1.0f,1.0f, //top right
            1.0f, (125.0f/175.0f), 0.0f,  1.0f,0.0f, //bottom right
            (122.0f/175.0f), (125.0f/175.0f), 0.0f,  0.0f, 0.0f, //bottom left
            (122.0f/175.0f), 1.0f, 0.0f,  0.0f, 1.0f //top left
        };
        private readonly uint[] indices3 = {
            0, 1, 3,
            1, 2, 3
        };
        private int ebo3;
        private int vbo3;
        private int vao3;
        private Shader shader3;
        private Texture texture3;
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
        private int cont=0;

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
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            //Sol
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

            //Octágono Café
            vbo2 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo2);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices2.Length * sizeof(float), vertices2, BufferUsageHint.StaticDraw);
            shader2 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag2.glsl");
            shader2.Use();
            vao2 = GL.GenVertexArray();
            GL.BindVertexArray(vao2);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Centro Arriba
            vbo7 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo7);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaArriba.Length * sizeof(float), hojaArriba, BufferUsageHint.StaticDraw);
            shader7 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader7.Use();
            vao7 = GL.GenVertexArray();
            GL.BindVertexArray(vao7);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Centro Abajo
            vbo8 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo8);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaAbajo.Length * sizeof(float), hojaAbajo, BufferUsageHint.StaticDraw);
            shader8 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader8.Use();
            vao8 = GL.GenVertexArray();
            GL.BindVertexArray(vao8);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Centro Derecha
            vbo9 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo9);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaDerecha.Length * sizeof(float), hojaDerecha, BufferUsageHint.StaticDraw);
            shader9 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader9.Use();
            vao9 = GL.GenVertexArray();
            GL.BindVertexArray(vao9);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Centro Derecha
            vbo10 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo10);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaIzquierda.Length * sizeof(float), hojaIzquierda, BufferUsageHint.StaticDraw);
            shader10 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader10.Use();
            vao10 = GL.GenVertexArray();
            GL.BindVertexArray(vao10);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Sup Izq Diag
            vbo11 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo11);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaDiagIzqSup.Length * sizeof(float), hojaDiagIzqSup, BufferUsageHint.StaticDraw);
            shader11 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader11.Use();
            vao11 = GL.GenVertexArray();
            GL.BindVertexArray(vao11);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Sup Der Diag
            vbo12 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo12);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaDiagDerSup.Length * sizeof(float), hojaDiagDerSup, BufferUsageHint.StaticDraw);
            shader12 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader12.Use();
            vao12 = GL.GenVertexArray();
            GL.BindVertexArray(vao12);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Inf Izq Diag
            vbo13 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo13);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaDiagIzqInf.Length * sizeof(float), hojaDiagIzqInf, BufferUsageHint.StaticDraw);
            shader13 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader13.Use();
            vao13 = GL.GenVertexArray();
            GL.BindVertexArray(vao13);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Hoja Inf Der Diag
            vbo14 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo14);
            GL.BufferData(BufferTarget.ArrayBuffer, hojaDiagDerInf.Length * sizeof(float), hojaDiagDerInf, BufferUsageHint.StaticDraw);
            shader14 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert2.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag4.glsl");
            shader14.Use();
            vao14 = GL.GenVertexArray();
            GL.BindVertexArray(vao14);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            //Agua Textura
            vbo3 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo3);
            GL.BufferData(BufferTarget.ArrayBuffer, verticesAgua.Length * sizeof(float), verticesAgua, BufferUsageHint.StaticDraw);
            ebo3 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo3);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices3.Length * sizeof(uint), indices3, BufferUsageHint.StaticDraw);
            shader3 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert3.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag3.glsl");
            shader3.Use();
            texture3 = new Texture("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Texturas\\water.jpg");
            texture3.Use();
            vao3 = GL.GenVertexArray();
            GL.BindVertexArray(vao3);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo3);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo3);
            var vertexLocation3 = shader3.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation3);
            GL.VertexAttribPointer(vertexLocation3, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            var texCoordLocation3 = shader3.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation3);
            GL.VertexAttribPointer(texCoordLocation3, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            //Tierra Textura
            vbo4 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo4);
            GL.BufferData(BufferTarget.ArrayBuffer, verticesTierra.Length * sizeof(float), verticesTierra, BufferUsageHint.StaticDraw);
            ebo4 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo4);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices4.Length * sizeof(uint), indices4, BufferUsageHint.StaticDraw);
            shader4 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert3.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag3.glsl");
            shader4.Use();
            texture4 = new Texture("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Texturas\\earth.jpg");
            texture4.Use();
            vao4 = GL.GenVertexArray();
            GL.BindVertexArray(vao4);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo4);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo4);
            var vertexLocation4 = shader4.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation4);
            GL.VertexAttribPointer(vertexLocation4, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            var texCoordLocation4 = shader4.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation4);
            GL.VertexAttribPointer(texCoordLocation4, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            //Fuego Textura
            vbo5 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo5);
            GL.BufferData(BufferTarget.ArrayBuffer, verticesFuego.Length * sizeof(float), verticesFuego, BufferUsageHint.StaticDraw);
            ebo5 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo5);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices5.Length * sizeof(uint), indices5, BufferUsageHint.StaticDraw);
            shader5 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert3.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag3.glsl");
            shader5.Use();
            texture5 = new Texture("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Texturas\\fire.jpg");
            texture5.Use();
            vao5 = GL.GenVertexArray();
            GL.BindVertexArray(vao5);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo5);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo5);
            var vertexLocation5 = shader5.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation5);
            GL.VertexAttribPointer(vertexLocation5, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            var texCoordLocation5 = shader5.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation5);
            GL.VertexAttribPointer(texCoordLocation5, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            //Textura Aire
            vbo6 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo6);
            GL.BufferData(BufferTarget.ArrayBuffer, verticesAire.Length * sizeof(float), verticesAire, BufferUsageHint.StaticDraw);
            ebo6 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo6);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices6.Length * sizeof(uint), indices6, BufferUsageHint.StaticDraw);
            shader6 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert3.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag3.glsl");
            shader6.Use();
            texture6 = new Texture("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Texturas\\air.jpg");
            texture6.Use();
            vao6 = GL.GenVertexArray();
            GL.BindVertexArray(vao6);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo6);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo6);
            var vertexLocation6 = shader6.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation6);
            GL.VertexAttribPointer(vertexLocation6, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            var texCoordLocation6 = shader6.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation6);
            GL.VertexAttribPointer(texCoordLocation6, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            //Textura Semillas
            vbo15 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo15);
            GL.BufferData(BufferTarget.ArrayBuffer, verticesSemillas.Length * sizeof(float), verticesSemillas, BufferUsageHint.StaticDraw);
            ebo15 = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo15);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices15.Length * sizeof(uint), indices15, BufferUsageHint.StaticDraw);
            shader15 = new Shader("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\vert.glsl", "C:\\Users\\maqui\\Documents\\MiniProyecto1\\Shaders\\frag.glsl");
            shader15.Use();
            texture15 = new Texture("C:\\Users\\maqui\\Documents\\MiniProyecto1\\Texturas\\semillas.jpg");
            texture15.Use();
            vao15 = GL.GenVertexArray();
            GL.BindVertexArray(vao15);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo15);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo15);
            var vertexLocation15 = shader15.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation15);
            GL.VertexAttribPointer(vertexLocation15, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            var texCoordLocation15 = shader15.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoordLocation15);
            GL.VertexAttribPointer(texCoordLocation15, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            base.OnLoad();
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            var transform = Matrix4.Identity;
            var transform2 = Matrix4.Identity;
            var transform3 = Matrix4.Identity;
            var transform4 = Matrix4.Identity;
            var transform5 = Matrix4.Identity;
            float tiempo = (float)GLFW.GetTime();
            
            if(tiempo<7) {
                GL.BindVertexArray(vao);
                texture.Use();
                shader.Use();
                transform = Matrix4.CreateScale(0.3f*tiempo);
                shader.SetMatrix4("transform",transform); 
                GL.DrawElements(PrimitiveType.Triangles, _indices.Length, DrawElementsType.UnsignedInt, 0);
                if(tiempo>4 && tiempo<7) {
                    GL.BindVertexArray(vao2);
                    shader2.Use();
                    transform2 = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(2*MathHelper.Pi));
                    transform2 = Matrix4.CreateScale(40.0f*tiempo); 
                    shader2.SetMatrix4("transform2",transform2);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 9); 
                }
            }
            else {            
                texture.Use();
                GL.BindVertexArray(vao);
                transform = Matrix4.CreateScale(0.3f*7);
                shader.SetMatrix4("transform",transform); 
                GL.DrawElements(PrimitiveType.Triangles, _indices.Length, DrawElementsType.UnsignedInt, 0);
                if(tiempo<23) {
                    GL.BindVertexArray(vao2);
                    transform2 = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(2*MathHelper.Pi));
                    transform2 = Matrix4.CreateScale(40.0f*tiempo); 
                    shader2.SetMatrix4("transform2",transform2);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 9); 
                    if(cont<2000) {
                        GL.BindVertexArray(vao3);
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateScale(1f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);                    
                        cont++;
                    }
                    else if(cont<4000) {
                        //Console.WriteLine("holi");
                        GL.BindVertexArray(vao3); 
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateTranslation(0.0f,-1.71f,0.0f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,0.0f,0.0f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateTranslation(0.0f,1.71f,0.0f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateTranslation(-1.696f,0.0f,0.0f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);     
                        cont++;
                    }
                    else if(cont<6000) {
                        GL.BindVertexArray(vao3); 
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateTranslation(-1.696f,-1.71f,0.0f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,-1.71f,0.0f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,1.71f,0.0f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateTranslation(-1.696f,1.71f,0.0f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);     
                        cont++;
                    }
                    else if(cont<8000) {
                        GL.BindVertexArray(vao3); 
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateTranslation(-1.696f,0.0f,0.0f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateTranslation(0.0f,-1.71f,0.0f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,0.0f,0.0f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateTranslation(0.0f,1.71f,0.0f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);     
                        cont++;
                    }
                    else if(cont<10000) {
                        GL.BindVertexArray(vao3);
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateScale(1f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);                    
                        cont++;
                    }
                    else {
                        cont=0;
                    }
                }
                else {
                   
                    GL.BindVertexArray(vao2);
                    transform2 = Matrix4.CreateScale(40.0f*23);
                    shader2.SetMatrix4("transform2",transform2);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 9);
                    GL.BindVertexArray(vao7);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader7.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao8);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader8.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao9);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader9.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao10);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader10.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao11);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader11.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao12);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader12.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao13);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader13.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    GL.BindVertexArray(vao14);
                    transform4 = Matrix4.CreateScale(1f);
                    transform4 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                    shader14.SetMatrix4("transform2",transform4);
                    GL.DrawArrays(PrimitiveType.TriangleFan, 0, 4);
                    if(cont<2000) {
                        GL.BindVertexArray(vao3);
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateScale(1f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);                    
                        cont++;
                    }
                    else if(cont<4000) {
                        //Console.WriteLine("holi");
                        GL.BindVertexArray(vao3); 
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateTranslation(0.0f,-1.71f,0.0f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,0.0f,0.0f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateTranslation(0.0f,1.71f,0.0f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateTranslation(-1.696f,0.0f,0.0f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);     
                        cont++;
                    }
                    else if(cont<6000) {
                        GL.BindVertexArray(vao3); 
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateTranslation(-1.696f,-1.71f,0.0f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,-1.71f,0.0f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,1.71f,0.0f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateTranslation(-1.696f,1.71f,0.0f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);     
                        cont++;
                    }
                    else if(cont<8000) {
                        GL.BindVertexArray(vao3); 
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateTranslation(-1.696f,0.0f,0.0f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateTranslation(0.0f,-1.71f,0.0f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateTranslation(1.696f,0.0f,0.0f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateTranslation(0.0f,1.71f,0.0f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);     
                        cont++;
                    }
                    else if(cont<10000) {
                        GL.BindVertexArray(vao3);
                        shader3.Use();
                        texture3.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader3.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices3.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao4); 
                        shader4.Use();
                        texture4.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader4.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices4.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao5); 
                        shader5.Use();
                        texture5.Use();
                        transform3 = Matrix4.CreateScale(1f);
                        shader5.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices5.Length,DrawElementsType.UnsignedInt,0);
                        GL.BindVertexArray(vao6); 
                        shader6.Use();
                        texture6.Use();
                        transform3 = Matrix4.Identity;
                        transform3 = Matrix4.CreateScale(1f);
                        shader6.SetMatrix4("transform3",transform3);
                        GL.DrawElements(PrimitiveType.Triangles,indices6.Length,DrawElementsType.UnsignedInt,0);                    
                        cont++;
                    }
                    else {
                        cont=0;
                    }
                    if(tiempo>26) {
                        GL.BindVertexArray(vao15);
                        shader15.Use();
                        texture15.Use();
                        transform5 = Matrix4.CreateScale(1.3f);
                        transform5 = Matrix4.CreateRotationZ((float)GLFW.GetTime());
                        shader15.SetMatrix4("transform",transform5);
                        GL.DrawElements(PrimitiveType.Triangles,indices15.Length,DrawElementsType.UnsignedInt,0);
                    }      
                }         
            }
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