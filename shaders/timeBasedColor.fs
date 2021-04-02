#version 330 core

out vec4 FragColor;

in vec3 ourColor;

uniform float timeValue;

void main()
{
    FragColor = vec4((ourColor + timeValue) % 1, 1.0f);
}