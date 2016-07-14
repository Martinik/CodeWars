using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CodeWarsMain.Enums;
using CodeWarsMain.Levels;
using System.Collections.Generic;
using System.Threading;
using CodeWarsMain.Models;

namespace CodeWarsMain
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class CodeWarsGame : Game
    {
        public static GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameState currentGameState = GameState.MainMenu;
        List<Level> gameLevels;

        int screenWidth = Constants.ScreenWidth;
        int screenHeight = Constants.ScreenHeight;
        private bool isPaused = false;

        //Buttons
        Button startGameButton;


        //MainMenu mainMenu = new MainMenu();

        public CodeWarsGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            

            gameLevels = new List<Level>()
            {
                new MainMenu()
            };


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Screen
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();

            IsMouseVisible = true;

            //Buttons
            startGameButton = new Button(Content.Load<Texture2D>("Images//Backgrounds//play_button"), 
                Constants.StartButtonSize, Constants.StartButtonLocation);

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                    Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                isPaused = !isPaused;
            }
            if (!isPaused)
            {

                MouseState mouse = Mouse.GetState();

                // TODO: Add your update logic here

                switch (currentGameState)
                {
                    case GameState.MainMenu:
                        startGameButton.Update(mouse);
                        break;
                    case GameState.LevelOne:
                        break;

                }



                base.Update(gameTime);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            Texture2D background = Content.Load<Texture2D>((gameLevels.Find(x => x.GameState == currentGameState).BackgroundFilePath));
            spriteBatch.Draw(background, new Rectangle(0, 0, screenWidth, screenHeight), Color.White);

            int tempWidth = background.Width;

           

  
            startGameButton.Draw(spriteBatch);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
