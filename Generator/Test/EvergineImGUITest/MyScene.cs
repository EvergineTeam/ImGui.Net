using Evergine.Framework;
using Evergine.Framework.Graphics;
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
            Entity e = new Entity()
                    .AddComponent(new Transform3D())
                    .AddComponent(new ImguiDemo());

            this.Managers.EntityManager.Add(e);
        }
    }
}