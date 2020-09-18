using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Xml.Xsl;

namespace CourseWork
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D texture;
        Texture2D Background;
        Vector2 position = new Vector2(200, 200);
        float speed = 2f;
        float rotation;
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
            texture = Content.Load<Texture2D>("Planet");
            Background = Content.Load<Texture2D>("Background");

        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (keyboardState.IsKeyDown(Keys.Left))
                position.X += speed;
            if (keyboardState.IsKeyDown(Keys.Right))
                position.X -= speed;
            if (keyboardState.IsKeyDown(Keys.Up))
                position.Y -= speed;
            if (keyboardState.IsKeyDown(Keys.Down))
                position.Y += speed;
            if (keyboardState.IsKeyDown(Keys.E))
                rotation += 0.1f;
            if (keyboardState.IsKeyDown(Keys.Q))
                rotation -= 0.1f;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin(SpriteSortMode.BackToFront);
            _spriteBatch.Draw(texture,
                position,
                null,
                Color.White,
                rotation,
                new Vector2(50, 50),
                1f,
                SpriteEffects.None,
                0);

            _spriteBatch.Draw(Background,
                new Vector2((Window.ClientBounds.Width / 2) - (Background.Width / 2),
                (Window.ClientBounds.Height / 2) - (Background.Height / 2)),
                null,
                Color.White,
                0,
                new Vector2(0, 0),
                1f,
                SpriteEffects.None,
                1);


            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
