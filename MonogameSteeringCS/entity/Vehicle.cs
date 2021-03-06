﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

namespace SteeringCS.entity
{
    class Vehicle : MovingEntity
    {
        public Microsoft.Xna.Framework.Color VColor { get; set; }

        public Vehicle(Vector2 pos, World w) : base(pos, w)
        {
            Velocity = new Vector2(0, 0);
            Scale = 5;

            VColor = Color.Black;
        }

        public override void Render(SpriteBatch spriteBatch)
        {
            double leftCorner = Pos.X  - Scale;
            double rightCorner = Pos.Y - Scale;
            double size = Scale * 2;

            Vector2 position = new Vector2((float) Pos.X, (float) Pos.Y);
            Vector2 radius = new Vector2(this.Scale);
            Vector2 velocity = new Vector2((float) this.Velocity.X, (float) this.Velocity.Y);

            spriteBatch.DrawEllipse(position, radius, 0, VColor);

            spriteBatch.DrawLine(position, velocity * 2 + position, Color.Aqua);
        }
    }
}