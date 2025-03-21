using Evergine.Bindings.Imgui;
using Evergine.Bindings.Imguizmo;
using Evergine.Common.Input;
using Evergine.Common.Input.Keyboard;
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Framework.Services;
using Evergine.Mathematics;
using EvergineImGUITest.Managers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EvergineImGUITest.Components
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

        private OPERATION currentOperation;

        private bool enableGuizmo = true;

        private float[] bounds;
        private ImGuiIO* io;

        protected override bool OnAttached()
        {
            var result = base.OnAttached();

            this.camera = this.Managers.EntityManager.FindFirstComponentOfType<Camera3D>();

            this.WorldTransform = Matrix4x4.Identity;

            this.currentOperation = OPERATION.TRANSLATE;

            this.bounds = new[] { -0.5f, -0.5f, -0.5f, 0.5f, 0.5f, 0.5f };

            this.io = ImguiNative.igGetIO();

            return result;
        }

        protected override void Update(TimeSpan gameTime)
        {
            KeyboardDispatcher keyboardDispatcher = this.graphicsPresenter.FocusedDisplay?.KeyboardDispatcher;

            if (keyboardDispatcher?.ReadKeyState(Keys.Z) == ButtonState.Pressing)
            {
                this.currentOperation = OPERATION.TRANSLATE;
            }
            else if (keyboardDispatcher?.ReadKeyState(Keys.X) == ButtonState.Pressing)
            {
                this.currentOperation = OPERATION.ROTATE;
            }
            else if (keyboardDispatcher?.ReadKeyState(Keys.C) == ButtonState.Pressing)
            {
                this.currentOperation = OPERATION.SCALE;
            }
            else if (keyboardDispatcher?.ReadKeyState(Keys.V) == ButtonState.Pressing)
            {
                this.currentOperation = OPERATION.BOUNDS;
            }

            if (keyboardDispatcher?.ReadKeyState(Keys.P) == ButtonState.Pressing)
            {
                this.enableGuizmo = !this.enableGuizmo;
            }

            this.ImGuizmoDemo();
        }

        private void ImGuizmoDemo()
        {
            ImguizmoNative.ImGuizmo_SetRect(0, 0, this.io->DisplaySize.X, this.io->DisplaySize.Y);

            Matrix4x4 view = this.camera.View;
            Matrix4x4 projection = this.camera.Projection;
            Matrix4x4 world = this.transform.WorldTransform;

            ImguizmoNative.ImGuizmo_Enable(true);
            ImguizmoNative.ImGuizmo_SetGizmoSizeClipSpace(0.15f);

            ////ImguizmoNative.ImGuizmo_ViewManipulate(view.Ptr(), 2, Vector2.Zero, new Vector2(128, 128), 0x10101010);

            float* f = (float*)Unsafe.AsPointer(ref bounds[0]);
            ImguizmoNative.ImGuizmo_Manipulate(view.Ptr(), projection.Ptr(), this.currentOperation, MODE.WORLD, world.Ptr(), null, null, f, null);

            this.transform.WorldTransform = world;

            var iview = Matrix4x4.Invert(view);
            this.camera.Transform.LocalRotation = iview.Rotation;
            this.camera.Transform.LocalPosition = iview.Translation;
        }
    }
}