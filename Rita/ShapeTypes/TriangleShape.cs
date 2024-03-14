using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;



namespace Rita.ShapeTypes
{
    public static class TriangleShape
    {
        public static void DrawTriangle(SpriteBatch spriteBatch, Vector2[] vertices, Color color, float thickness) 
        {
            if (vertices.Length != 3) 
            {
                throw new ArgumentException("A triangle must have exactly 3 vertices.");
            }

            Vector2 center = vertices[0] + vertices[1] + vertices[2] /3;

            float[] distance = new float[3];
            for (int i = 0; i < 3; i++)
            {
                distance[i] =Vector2.Distance(center, vertices[i]);

            }

            for (int i = 0; i < 3; i++)
            {
                int j = (i + 1) % 3;
                spriteBatch.DrawLine(vertices[i], vertices[j], color, thickness);
            }
        }
    }
}
