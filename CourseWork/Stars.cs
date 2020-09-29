using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace CourseWork
{
    public class Stars
    {
        //private Color cl;
        public Texture2D[] texture;
        private Vector2[] pos;
        Random rnd;

        public void Initialize(GraphicsDeviceManager _graphics)
        {
            rnd = new Random();
            pos = new Vector2[100];
            texture = new Texture2D[100];
            for (int i = 0; i < 100; i++)
            {
                pos[i] = new Vector2(rnd.Next(25, _graphics.PreferredBackBufferWidth - 25), rnd.Next(25, _graphics.PreferredBackBufferHeight - 25));
            }

        }

        public void Update(GraphicsDeviceManager _graphics)
        {

            for (int i = 0; i < 25; i++)
            {
                float speed = 0.1f;
                pos[i] += new Vector2(speed, 0);
                if (pos[i].X > _graphics.PreferredBackBufferWidth)
                {
                    pos[i].X = 0;
                }
                if (pos[i].Y > _graphics.PreferredBackBufferHeight)
                {
                    pos[i].Y = 0;
                }
            }
            for (int j = 0; j < 50; j++)
            {
                float speed = 0.5f;
                pos[j] += new Vector2(speed, 0);
                if (pos[j].X > _graphics.PreferredBackBufferWidth)
                {
                    pos[j].X = 0;
                }
                if (pos[j].Y > _graphics.PreferredBackBufferHeight)
                {
                    pos[j].Y = 0;
                }
            }
            for (int k = 0; k < 100; k++)
            {
                float speed = 1f;
                pos[k] += new Vector2(speed, 0);
                if (pos[k].X > _graphics.PreferredBackBufferWidth)
                {
                    pos[k].X = 0;
                }
                if (pos[k].Y > _graphics.PreferredBackBufferHeight)
                {
                    pos[k].Y = 0;
                }
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch _spriteBatch)
        {
            _spriteBatch.Begin();
            for (int i = 0; i < 100; i++)
            {
                _spriteBatch.Draw(texture[i], pos[i], Color.White);
            }
            _spriteBatch.End();

        }
    }
}

