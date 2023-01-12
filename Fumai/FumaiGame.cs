using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fumai;

public class FumaiGame : Game
{
    private GraphicsDeviceManager graphics;
    private SpriteBatch spritebatch;

    public FumaiGame()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        graphics.PreferredBackBufferWidth = 1366;  
        graphics.PreferredBackBufferHeight = 768;   
        graphics.ApplyChanges();
        Window.AllowUserResizing = true;
    }

    protected override void LoadContent()
    {
        base.LoadContent();
        spritebatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Draw(GameTime gameTime)
    {
        base.Draw(gameTime);
        GraphicsDevice.Clear(Color.Black);
    }
}