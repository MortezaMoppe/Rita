using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace Rita.ShapeTypes
{
    public class Shapes
    {
        public ShapeType Type { get; set; }
        public Color Color { get; set; }
        public Vector2 StartPoint { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    spriteBatch.DrawCircle(StartPoint, 50, Color, 2);
                    break;

                case ShapeType.Square:
                    spriteBatch.DrawRectangle(new Rectangle((int)StartPoint.X, (int)StartPoint.Y, 100, 100), Color, 2);
                    break;

               
                case ShapeType.Triangle:
                    
                    Vector2[] triangleVertices = new Vector2[]
                    {
                new Vector2(StartPoint.X, StartPoint.Y - 50),  // Top
                new Vector2(StartPoint.X - 50, StartPoint.Y + 50),  // Bottom left
                new Vector2(StartPoint.X + 50, StartPoint.Y + 50)   // Bottom right
                    };

                    // Draw the triangle
                    TriangleShape.DrawTriangle(spriteBatch, triangleVertices, Color, 2);
                    break;


                default: break;
            }
        }

    }
}