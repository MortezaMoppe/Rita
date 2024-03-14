using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;


namespace Rita.ShapeTypes
{
    public static class CircleShape
    {
        public static void DrawCircle(this SpriteBatch spriteBatch, Vector2 position, float radius, Color color, int segments = 30)
        {
            Vector2[] circleEdges = new Vector2[segments + 1];

            float angleIncrement = MathHelper.TwoPi / segments;
            float currentAngle = 0;

            for (int i = 0; i < segments; i++)
            {
                circleEdges[i] = position + radius * new Vector2((float)Math.Cos(currentAngle), (float)Math.Sin(currentAngle));
                currentAngle += angleIncrement;
            }

            // Connect the last point to the first point to close the circle
            circleEdges[segments] = circleEdges[0];

            // Draw the circle using lines
            for (int i = 0; i < segments; i++)
            {
                spriteBatch.DrawLine(circleEdges[i], circleEdges[i + 1], color);
            }
        }

    }
}

