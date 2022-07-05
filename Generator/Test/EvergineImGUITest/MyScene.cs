using Evergine.Common.Graphics;
using Evergine.Components.Graphics3D;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Graphics.Effects;
using Evergine.Framework.Graphics.Materials;
using Evergine.Framework.Services;
using EvergineImGUITest.Components;
using EvergineImGUITest.Managers;

namespace EvergineImGUITest
{
    public class MyScene : Scene
    {
        public override void RegisterManagers()
        {
            this.Managers.AddManager(new ImGuiManager());
            base.RegisterManagers();
            this.Managers.AddManager(new Evergine.Bullet.BulletPhysicManager3D());
        }

        protected override void CreateScene()
        {
            // Imgui window
            Entity e = new Entity()
                    .AddComponent(new Transform3D())
                    .AddComponent(new ImguiDemo());
                    ////.AddComponent(new ImnodesDemo());

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
    }
}