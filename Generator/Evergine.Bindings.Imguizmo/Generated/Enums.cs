using System;

namespace Evergine.Bindings.Imguizmo
{
	public enum MODE
	{
		LOCAL = 0,
		WORLD = 1,
	}

	public enum OPERATION
	{
		None = 0,
		TRANSLATE_X = 1,
		TRANSLATE_Y = 2,
		TRANSLATE_Z = 4,
		ROTATE_X = 8,
		ROTATE_Y = 16,
		ROTATE_Z = 32,
		ROTATE_SCREEN = 64,
		SCALE_X = 128,
		SCALE_Y = 256,
		SCALE_Z = 512,
		BOUNDS = 1024,
		SCALE_XU = 2048,
		SCALE_YU = 4096,
		SCALE_ZU = 8192,
		TRANSLATE = 7,
		ROTATE = 120,
		SCALE = 896,
		SCALEU = 14336,
		UNIVERSAL = 14463,
	}

}
