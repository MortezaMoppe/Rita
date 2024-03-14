using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rita.ShapeTypes;
using System.Collections.Generic;


namespace Rita;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private List<Shapes> shapes = new List<Shapes>();
    private MouseState prevMouseState;
    private ShapeType currentShapeType = ShapeType.Circle;
    private Color currentColor = Color.Black;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
       
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        MouseState mouseState = Mouse.GetState();
        if (mouseState.LeftButton == ButtonState.Pressed && prevMouseState.LeftButton == ButtonState.Released) 
        {
            shapes.Add(new Shapes { Type = currentShapeType, Color = currentColor, StartPoint = new Vector2(mouseState.X, mouseState.Y) });
        }

        prevMouseState = mouseState;

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    //protected override Shape GetShape()
    //{
    //    return Shape;
    //}

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        foreach (var shape in shapes)
        {
            shape.Draw(_spriteBatch);
        }

        _spriteBatch.End();


        base.Draw(gameTime);
    }
}

public enum ShapeType
{
    Circle,
    Square,
    Triangle
}