﻿using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using Color = Microsoft.Xna.Framework.Color;

namespace SteeringCS
{
    abstract class BaseGameEntity
    {
        public Vector2 Pos { get; set; }
        public float Scale { get; set; }
        public World MyWorld { get; set; }

        public BaseGameEntity(Vector2 pos, World w)
        {
            Pos = pos;
            MyWorld = w;
        }

        public abstract void Update(float delta);

        public virtual void Render(SpriteBatch spriteBatch)
        {
            Vector2 position = new Vector2((float) Pos.X, (float) Pos.Y);

            //Brushes.Blue, new Rectangle((int) Pos.X,(int) Pos.Y, 10, 10)
            spriteBatch.DrawCircle(position, 10f, 0, Color.Blue);
        }
    }
}