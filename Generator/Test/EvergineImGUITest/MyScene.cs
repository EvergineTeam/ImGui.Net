using Evergine.Framework;
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
        }
    }
}