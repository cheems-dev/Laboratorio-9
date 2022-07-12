#version 330 core
out vec4 FragColor;

in vec2 TexCoord;


//uniform
uniform vec4 pixel_color;

void main()
{
	// linearly interpolate between both textures (80% container, 20% awesomeface)
	FragColor = pixel_color;
}