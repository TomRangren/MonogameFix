using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Texture2D Hunter2;
        Texture2D FiendeTexture1;
        Texture2D swamp2;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle gunPos;
        Vector2 enemyPos;
        Fiende fiende;
        Random random = new Random();



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            gunPos = new Rectangle(new Point(0, 300), new Point(200, 60));
            gunPos.Y = graphics.PreferredBackBufferHeight - gunPos.Height;
            gunPos.X = graphics.PreferredBackBufferWidth / 100 - gunPos.Width / 100;
            FiendeTexture1 = Content.Load<Texture2D>("FiendeTexture1");
            fiende = new Fiende(FiendeTexture1);


            enemyPos.Y = random.Next(graphics.PreferredBackBufferHeight - 100);
            enemyPos.X = graphics.PreferredBackBufferWidth + 3000;

            fiende.FiendePos = enemyPos;

 

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            Hunter2 = Content.Load<Texture2D>("Hunter2");
            FiendeTexture1 = Content.Load<Texture2D>("FiendeTexture1");
            swamp2 = Content.Load<Texture2D>("swamp2");


            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Down) && gunPos.Y < graphics.PreferredBackBufferHeight - gunPos.Height)
                gunPos.Y += 10;
            if (kstate.IsKeyDown(Keys.Up) && gunPos.Y > 0)
                gunPos.Y -= 10;


            fiende.Update();



            // TODO: Add your update logic here

            base.Update(gameTime);
        }


        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {


            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(swamp2, Vector2.Zero, Color.White);
            spriteBatch.Draw(Hunter2, gunPos, Color.White);
            fiende.Draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}