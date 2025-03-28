using Evergine.Common.Graphics;
using Evergine.Components.Graphics3D;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Graphics.Effects;
using Evergine.Framework.Graphics.Materials;
using Evergine.Framework.Managers;
using Evergine.Framework.Services;
using Evergine.Mathematics;
using ExampleEvergine.Components;
using ExampleEvergine.Managers;
using System;

namespace ExampleEvergine
{
    public class MyScene : Scene
    {
        public ImGuiManager ImGuiManager;

        public override void RegisterManagers()
        {
            base.RegisterManagers();
            this.Managers.AddManager(new global::Evergine.Bullet.BulletPhysicManager3D());

            this.ImGuiManager = new ImGuiManager();
        }

        protected override void CreateScene()
        {
            // Imgui window
            Entity e = new Entity()
                    .AddComponent(new Transform3D())
                    .AddComponent(new ImguiDemo())
                    .AddComponent(new ImnodesDemo());

            this.Managers.EntityManager.Add(e);

            // Cube with imguizmo
            var assetsService = Application.Current.Container.Resolve<AssetsService>();
            Effect standardEffect = assetsService.Load<Effect>(EvergineContent.Effects.StandardEffect);

            RenderLayerDescription opaqueLayerDescription = new RenderLayerDescription()
            {
                RenderState = new RenderStateDescription()
                {
                    RasterizerState = RasterizerStates.CullBack,
                    BlendState = BlendStates.Opaque,
                    DepthStencilState = DepthStencilStates.ReadWrite,
                },
            };

            StandardMaterial standardMaterial = new StandardMaterial(standardEffect)
            {
                LayerDescription = opaqueLayerDescription,
                BaseColor = Color.White,
                LightingEnabled = true,
            };

            Entity primitive = new Entity()
                .AddComponent(new Transform3D())
                .AddComponent(new MaterialComponent() { Material = standardMaterial.Material })
                .AddComponent(new CubeMesh())
                .AddComponent(new ImguizmoDemo())
                .AddComponent(new MeshRenderer());

            this.Managers.EntityManager.Add(primitive);
        }

        protected override void Start()
        {
            base.Start();

            var graphicsPresenter = Application.Current.Container.Resolve<GraphicsPresenter>();
            var graphicsContext = Application.Current.Container.Resolve<GraphicsContext>();
            var renderManager = this.Managers.RenderManager;
            this.ImGuiManager.Initialize(graphicsPresenter, graphicsContext, renderManager);
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.ImGuiManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Dispose(bool disposing)
        {
            this.ImGuiManager.Destroy();
            base.Dispose(disposing);
        }
    }
}


