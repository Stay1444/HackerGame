using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using System.Timers;

namespace Client
{
    public class HackClient : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public Timer fpsCounter = new Timer();
        public HackClient()
        {

            fpsCounter = new Timer(1000);
            fpsCounter.AutoReset = true;
            fpsCounter.Enabled = true;
            fpsCounter.Elapsed += FpsCounter_Elapsed;
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.Title = "Unnamed Hacker Game";
            //_graphics.IsFullScreen = true;
            Window.IsBorderless = true;
            _graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            _graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            Window.Position = new Point(0, 0);
            _graphics.ApplyChanges();
        }

        int FPSCOUNT = 0;

        private void FpsCounter_Elapsed(object sender, ElapsedEventArgs e)
        {
            Debug.WriteLine(FPSCOUNT.ToString());
            FPSCOUNT = 0;
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
            FPSCOUNT++;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
