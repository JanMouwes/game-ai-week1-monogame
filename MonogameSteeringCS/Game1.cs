using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SteeringCS;

namespace MonogameSteeringCS
{
    public class Game1 : Game
    {
        private World world;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private const int WORLD_WIDTH = 600;
        private const int WORLD_HEIGHT = 400;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            this.world = new World(WORLD_WIDTH, WORLD_HEIGHT);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            this.world.Update((float) gameTime.ElapsedGameTime.TotalMilliseconds);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();

            this.world.Render(this.spriteBatch);

            base.Draw(gameTime);

            this.spriteBatch.End();
        }
    }
}