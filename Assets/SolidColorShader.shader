//UNITY_SHADER_NO_UPGRADE

Shader "Unlit/SolidColorShader"
{
	SubShader
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			uniform float4 _Color;

			struct vertIn
			{
				float4 vertex : POSITION;
				float4 vertexColor : COLOR;
			};

			struct vertOut
			{
				float4 vertex : SV_POSITION;
				float4 vertexColor : COLOR;
			};

			// Implementation of the vertex shader
			vertOut vert(vertIn v)
			{
				vertOut o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.vertexColor = v.vertexColor;
				return o;
			}
			
			// Implementation of the fragment (pixel) shader
			fixed4 frag(vertOut v) : SV_Target
			{
				//return float4(1.0f, 1.0f, 0.0f, 1.0f);
				return v.vertexColor;
			}
			ENDCG
		}
	}
}
