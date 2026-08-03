using Evergine.Mathematics;
using Evergine.Bindings.Imgui;
using System;

namespace Evergine.Bindings.Imguizmo
{
	public enum COLOR
	{
		DIRECTION_X = 0,
		DIRECTION_Y = 1,
		DIRECTION_Z = 2,
		PLANE_X = 3,
		PLANE_Y = 4,
		PLANE_Z = 5,
		SELECTION = 6,
		INACTIVE = 7,
		TRANSLATION_LINE = 8,
		SCALE_LINE = 9,
		ROTATION_USING_BORDER = 10,
		ROTATION_USING_FILL = 11,
		HATCHED_AXIS_LINES = 12,
		TEXT = 13,
		TEXT_SHADOW = 14,
		COUNT = 15,
	}

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
