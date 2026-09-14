using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AngularDynamicsExercise;

/// <summary>
/// A class representing the players' ship
/// </summary>
public class ShipSprite
{
    public Game game;
    public Texture2D texture;
    public Vector2 position;
    public Vector2 velocity;

    /// <summary>
    /// Creates the ship sprite
    /// </summary>
    public ShipSprite(Game game)
    {
        this.game = game;
        this.position = new Vector2(375, 250);
    }

    /// <summary>
    /// Loads the sprite texture
    /// </summary>
    /// <param name="content">The content manager to load with</param>
    public void LoadContent(ContentManager content)
    {
        texture = content.Load<Texture2D>("ship");
    }

    /// <summary>
    /// Updates the ship sprite
    /// </summary>
    /// <param name="gameTime">An object representing time in the game</param>
    public void Update(GameTime gameTime)
    {
        KeyboardState keyboardState = Keyboard.GetState();
        float t = (float)gameTime.ElapsedGameTime.TotalSeconds;

        // Wrap the ship to keep it on-screen
        var viewport = game.GraphicsDevice.Viewport;
        if (position.Y < 0) position.Y = viewport.Height;
        if (position.Y > viewport.Height) position.Y = 0;
        if (position.X < 0) position.X = viewport.Width;
        if (position.X > viewport.Width) position.X = 0;
    }

    /// <summary>
    /// Draws the sprite
    /// </summary>
    /// <param name="gameTime">An object representing time in the game</param>
    /// <param name="spriteBatch">The SpriteBatch to draw with</param>
    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture, position, Color.White);
    }
}

