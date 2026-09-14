using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AngularDynamicsExercise;

public class AngularDynamicsExampleGame : Game
{
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;
    private ShipSprite ship;

    /// <summary>
    /// Creates a new game
    /// </summary>
    public AngularDynamicsExampleGame()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    /// <summary>
    /// Initializes the game
    /// </summary>
    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        ship = new ShipSprite(this);

        base.Initialize();
    }

    /// <summary>
    /// Loads the game content
    /// </summary>
    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        ship.LoadContent(Content);
    }

    /// <summary>
    /// Updates the game
    /// </summary>
    /// <param name="gameTime">An object representing time in the game</param>
    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        ship.Update(gameTime);

        base.Update(gameTime);
    }

    /// <summary>
    /// Draws the game
    /// </summary>
    /// <param name="gameTime">An object representing time in the game</param>
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        // TODO: Add your drawing code here
        spriteBatch.Begin();
        ship.Draw(gameTime, spriteBatch);
        spriteBatch.End();

        base.Draw(gameTime);
    }
}