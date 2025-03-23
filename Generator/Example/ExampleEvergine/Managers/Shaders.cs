using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleEvergine.Managers
{
    public static class Shaders
    {
        internal static string HLSLVertexShader = @"
            cbuffer Matrices : register(b0)
            {
                float4x4 ProjectionMatrix;
            };

            struct VS_IN
            {
                float2 pos : POSITION0;
                float2 uv  : TEXCOORD0;
                float4 col : COLOR0;
            };

            struct PS_IN
            {
                float4 pos : SV_POSITION;
                float4 col : COLOR0;
                float2 uv  : TEXCOORD0;
            };

            PS_IN VS(VS_IN input)
            {
                PS_IN output = (PS_IN)0;

                output.pos = mul(float4(input.pos.xy, 0.0, 1.0), ProjectionMatrix);
                output.col = input.col;
                output.uv = input.uv;
                return output;
            }";

        internal static string HLSLPixelShader = @"
            Texture2D FontTexture : register(t0);
            sampler FontSampler : register(s0);

            struct PS_IN
            {
                float4 pos : SV_POSITION;
                float4 col : COLOR0;
                float2 uv  : TEXCOORD0;
            };

            float4 PS(PS_IN input) : SV_Target
            {
                float4 out_col = input.col * FontTexture.Sample(FontSampler, input.uv);
                return out_col;
            }";

        internal static string GLSLVertexShader = @"
            #version 450

            out gl_PerVertex
            {
                vec4 gl_Position;
            };

            layout(binding = 0, std140) uniform type_Matrices
            {
                mat4 ProjectionMatrix;
            } Matrices;

            layout(location = 0) in vec2 in_var_POSITION0;
            layout(location = 1) in vec2 in_var_TEXCOORD0;
            layout(location = 2) in vec4 in_var_COLOR0;
            layout(location = 0) out vec4 out_var_COLOR0;
            layout(location = 1) out vec2 out_var_TEXCOORD0;

            void main()
            {
                gl_Position = Matrices.ProjectionMatrix * vec4(in_var_POSITION0, 0.0, 1.0);
                out_var_COLOR0 = in_var_COLOR0;
                out_var_TEXCOORD0 = in_var_TEXCOORD0;
            }";

        internal static string GLSLPixelShader = @"
            #version 450

            layout(binding = 0) uniform sampler2D SPIRV_Cross_CombinedFontTextureFontSampler;

            layout(location = 0) in vec4 in_var_COLOR0;
            layout(location = 1) in vec2 in_var_TEXCOORD0;
            layout(location = 0) out vec4 out_var_SV_Target;

            void main()
            {
                out_var_SV_Target = in_var_COLOR0 * texture(SPIRV_Cross_CombinedFontTextureFontSampler, in_var_TEXCOORD0);
            }";

        internal static string MSLVertexShader = @"
            #include <metal_stdlib>
            #include <simd/simd.h>

            using namespace metal;

            struct type_Matrices
            {
                float4x4 ProjectionMatrix;
            };

            struct VS_out
            {
                float4 out_var_COLOR0 [[user(locn0)]];
                float2 out_var_TEXCOORD0 [[user(locn1)]];
                float4 gl_Position [[position]];
            };

            struct VS_in
            {
                float2 in_var_POSITION0 [[attribute(0)]];
                float2 in_var_TEXCOORD0 [[attribute(1)]];
                float4 in_var_COLOR0 [[attribute(2)]];
            };

            vertex VS_out VS(VS_in in [[stage_in]], constant type_Matrices& Matrices [[buffer(0)]])
            {
                VS_out out = {};
                out.gl_Position = Matrices.ProjectionMatrix * float4(in.in_var_POSITION0, 0.0, 1.0);
                out.out_var_COLOR0 = in.in_var_COLOR0;
                out.out_var_TEXCOORD0 = in.in_var_TEXCOORD0;
                return out;
            }";

        internal static string MSLPixelShader = @"
            #include <metal_stdlib>
            #include <simd/simd.h>

            using namespace metal;

            struct PS_out
            {
                float4 out_var_SV_Target [[color(0)]];
            };

            struct PS_in
            {
                float4 in_var_COLOR0 [[user(locn0)]];
                float2 in_var_TEXCOORD0 [[user(locn1)]];
            };

            fragment PS_out PS(PS_in in [[stage_in]], texture2d<float> FontTexture [[texture(0)]], sampler FontSampler [[sampler(0)]])
            {
                PS_out out = {};
                out.out_var_SV_Target = in.in_var_COLOR0 * FontTexture.sample(FontSampler, in.in_var_TEXCOORD0);
                return out;
            }";

        internal static string SPIRVVertexShader = @"AwIjBwAAAQAAAA4AJAAAAAAAAAARAAIAAQAAAA4AAwAAAAAAAQAAAA8ACgAAAAAAAQAAAFZTAAACAAAAAwAAAAQAAAAFAAAABgAAAAcAAAADAAMABQAAAGICAAAFAAYACAAAAHR5cGUuTWF0cmljZXMAAAAGAAgACAAAAAAAAABQcm9qZWN0aW9uTWF0cml4AAAAAAUABQAJAAAATWF0cmljZXMAAAAABQAHAAIAAABpbi52YXIuUE9TSVRJT04wAAAAAAUABwADAAAAaW4udmFyLlRFWENPT1JEMAAAAAAFAAYABAAAAGluLnZhci5DT0xPUjAAAAAFAAYABgAAAG91dC52YXIuQ09MT1IwAAAFAAcABwAAAG91dC52YXIuVEVYQ09PUkQwAAAABQADAAEAAABWUwAARwAEAAUAAAALAAAAAAAAAEcABAACAAAAHgAAAAAAAABHAAQAAwAAAB4AAAABAAAARwAEAAQAAAAeAAAAAgAAAEcABAAGAAAAHgAAAAAAAABHAAQABwAAAB4AAAABAAAARwAEAAkAAAAiAAAAAAAAAEcABAAJAAAAIQAAAAAAAABIAAUACAAAAAAAAAAjAAAAAAAAAEgABQAIAAAAAAAAAAcAAAAQAAAASAAEAAgAAAAAAAAABQAAAEcAAwAIAAAAAgAAABYAAwAKAAAAIAAAABcABAALAAAACgAAAAQAAAAXAAQADAAAAAoAAAACAAAAFQAEAA0AAAAgAAAAAQAAACsABAANAAAADgAAAAAAAAArAAQACgAAAA8AAAAAAAAAKwAEAAoAAAAQAAAAAACAPxgABAARAAAACwAAAAQAAAAeAAMACAAAABEAAAAgAAQAEgAAAAIAAAAIAAAAIAAEABMAAAABAAAADAAAACAABAAUAAAAAQAAAAsAAAAgAAQAFQAAAAMAAAALAAAAIAAEABYAAAADAAAADAAAABMAAgAXAAAAIQADABgAAAAXAAAAIAAEABkAAAACAAAAEQAAADsABAASAAAACQAAAAIAAAA7AAQAEwAAAAIAAAABAAAAOwAEABMAAAADAAAAAQAAADsABAAUAAAABAAAAAEAAAA7AAQAFQAAAAUAAAADAAAAOwAEABUAAAAGAAAAAwAAADsABAAWAAAABwAAAAMAAAA2AAUAFwAAAAEAAAAAAAAAGAAAAPgAAgAaAAAAPQAEAAwAAAAbAAAAAgAAAD0ABAAMAAAAHAAAAAMAAAA9AAQACwAAAB0AAAAEAAAAUQAFAAoAAAAeAAAAGwAAAAAAAABRAAUACgAAAB8AAAAbAAAAAQAAAFAABwALAAAAIAAAAB4AAAAfAAAADwAAABAAAABBAAUAGQAAACEAAAAJAAAADgAAAD0ABAARAAAAIgAAACEAAACRAAUACwAAACMAAAAiAAAAIAAAAD4AAwAFAAAAIwAAAD4AAwAGAAAAHQAAAD4AAwAHAAAAHAAAAP0AAQA4AAEA";
        internal static string SPIRVPixelShader = @"AwIjBwAAAQAAAA4AHQAAAAAAAAARAAIAAQAAAA4AAwAAAAAAAQAAAA8ACAAEAAAAAQAAAFBTAAACAAAAAwAAAAQAAAAFAAAAEAADAAEAAAAHAAAAAwADAAUAAABiAgAABQAGAAYAAAB0eXBlLjJkLmltYWdlAAAABQAFAAcAAABGb250VGV4dHVyZQAFAAYACAAAAHR5cGUuc2FtcGxlcgAAAAAFAAUACQAAAEZvbnRTYW1wbGVyAAUABgADAAAAaW4udmFyLkNPTE9SMAAAAAUABwAEAAAAaW4udmFyLlRFWENPT1JEMAAAAAAFAAcABQAAAG91dC52YXIuU1ZfVGFyZ2V0AAAABQADAAEAAABQUwAABQAHAAoAAAB0eXBlLnNhbXBsZWQuaW1hZ2UAAEcABAACAAAACwAAAA8AAABHAAQAAwAAAB4AAAAAAAAARwAEAAQAAAAeAAAAAQAAAEcABAAFAAAAHgAAAAAAAABHAAQABwAAACIAAAAAAAAARwAEAAcAAAAhAAAAPAAAAEcABAAJAAAAIgAAAAAAAABHAAQACQAAACEAAAAoAAAAFgADAAsAAAAgAAAAGQAJAAYAAAALAAAAAQAAAAIAAAAAAAAAAAAAAAEAAAAAAAAAIAAEAAwAAAAAAAAABgAAABoAAgAIAAAAIAAEAA0AAAAAAAAACAAAABcABAAOAAAACwAAAAQAAAAgAAQADwAAAAEAAAAOAAAAFwAEABAAAAALAAAAAgAAACAABAARAAAAAQAAABAAAAAgAAQAEgAAAAMAAAAOAAAAEwACABMAAAAhAAMAFAAAABMAAAAbAAMACgAAAAYAAAA7AAQADAAAAAcAAAAAAAAAOwAEAA0AAAAJAAAAAAAAADsABAAPAAAAAgAAAAEAAAA7AAQADwAAAAMAAAABAAAAOwAEABEAAAAEAAAAAQAAADsABAASAAAABQAAAAMAAAA2AAUAEwAAAAEAAAAAAAAAFAAAAPgAAgAVAAAAPQAEAA4AAAAWAAAAAwAAAD0ABAAQAAAAFwAAAAQAAAA9AAQABgAAABgAAAAHAAAAPQAEAAgAAAAZAAAACQAAAFYABQAKAAAAGgAAABgAAAAZAAAAVwAGAA4AAAAbAAAAGgAAABcAAAAAAAAAhQAFAA4AAAAcAAAAFgAAABsAAAA+AAMABQAAABwAAAD9AAEAOAABAA==";
    }
}
