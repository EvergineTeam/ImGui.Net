using System.Diagnostics;
using Evergine.Common.Graphics;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Services;

namespace EvergineImGUITest.Windows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create app
            MyApplication application = new MyApplication();

            // Create Services
            uint width = 1280;
            uint height = 720;
            WindowsSystem windowsSystem = new Evergine.Forms.FormsWindowsSystem();
            application.Container.RegisterInstance(windowsSystem);
            var window = windowsSystem.CreateWindow("EvergineImGUITest - DX11", width, height);

            ConfigureGraphicsContext(application, window);
			
			// Creates XAudio device
            var xaudio = new Evergine.XAudio2.XAudioDevice();
            application.Container.RegisterInstance(xaudio);

            Stopwatch clockTimer = Stopwatch.StartNew();
            windowsSystem.Run(
            () =>
            {
                application.Initialize();
            },
            () =>
            {
                var gameTime = clockTimer.Elapsed;
                clockTimer.Restart();

                application.UpdateFrame(gameTime);
                application.DrawFrame(gameTime);
            });
        }

        private static void ConfigureGraphicsContext(Application application, Window window)
        {
            GraphicsContext graphicsContext = new Evergine.DirectX11.DX11GraphicsContext();
            graphicsContext.CreateDevice();
            SwapChainDescription swapChainDescription = new SwapChainDescription()
            {
                SurfaceInfo = window.SurfaceInfo,
                Width = window.Width,
                Height = window.Height,
                ColorTargetFormat = PixelFormat.R8G8B8A8_UNorm,
                ColorTargetFlags = TextureFlags.RenderTarget | TextureFlags.ShaderResource,
                DepthStencilTargetFormat = PixelFormat.D24_UNorm_S8_UInt,
                DepthStencilTargetFlags = TextureFlags.DepthStencil,
                SampleCount = TextureSampleCount.None,
                IsWindowed = true,
                RefreshRate = 60
            };
            var swapChain = graphicsContext.CreateSwapChain(swapChainDescription);
            swapChain.VerticalSync = true;

            var graphicsPresenter = application.Container.Resolve<GraphicsPresenter>();
            var firstDisplay = new Display(window, swapChain);
            graphicsPresenter.AddDisplay("DefaultDisplay", firstDisplay);

            application.Container.RegisterInstance(graphicsContext);
        }
    }
}
