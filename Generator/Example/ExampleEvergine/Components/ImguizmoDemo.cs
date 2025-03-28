using Evergine.Bindings.Imgui;
using Evergine.Bindings.Imguizmo;
using Evergine.Common.Input;
using Evergine.Common.Input.Keyboard;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Services;
using Evergine.Mathematics;
using ExampleEvergine.Managers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ExampleEvergine.Components
{
    public unsafe class ImguizmoDemo : Behavior
    {
        [BindService]
        protected GraphicsPresenter graphicsPresenter;

        protected ImGuiManager imguiManager;

        [BindComponent]
        public Transform3D transform;

        private Camera3D camera;

        private Matrix4x4 WorldTransform;

        private bool enableGuizmo = true;

        private float[] bounds;

        protected override bool OnAttached()
        {
            var result = base.OnAttached();

            this.camera = this.Managers.EntityManager.FindFirstComponentOfType<Camera3D>();

            this.WorldTransform = Matrix4x4.Identity;

            this.bounds = new[] { -0.5f, -0.5f, -0.5f, 0.5f, 0.5f, 0.5f };

            return result;
        }

        protected override void Update(TimeSpan gameTime)
        {
            var io = ImguiNative.igGetIO_Nil();
            ImguizmoNative.ImGuizmo_SetRect(0, 0, io->DisplaySize.X, io->DisplaySize.Y);

            Matrix4x4 view = this.camera.View;
            Matrix4x4 projection = this.camera.Projection;
            Matrix4x4 world = this.transform.WorldTransform;

            ImguizmoNative.ImGuizmo_Enable(true);
            ImguizmoNative.ImGuizmo_SetGizmoSizeClipSpace(0.15f);
            ImguizmoNative.ImGuizmo_DrawGrid(view.Ptr(), projection.Ptr(), world.Ptr(), 1.0f);

            float* f = (float*)Unsafe.AsPointer(ref bounds[0]);
            ImguizmoNative.ImGuizmo_Manipulate(view.Ptr(), projection.Ptr(), OPERATION.UNIVERSAL, MODE.WORLD, world.Ptr(), null, null, f, null);

            this.transform.WorldTransform = world;

            var iview = Matrix4x4.Invert(view);
            this.camera.Transform.LocalRotation = iview.Rotation;
            this.camera.Transform.LocalPosition = iview.Translation;
        }
    }
}