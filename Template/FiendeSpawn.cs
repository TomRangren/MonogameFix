using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class FiendeSpawn
    {

        private List<Fiende> Spawner = new List<Fiende>();
        Random random = new Random();

        private Vector2 position;
        private Texture2D texture;
        GraphicsDeviceManager graphics;
        float timer = 1;




        public void Update()
        {
            if (timer <=0 && Spawner.Count < 4)
            {
                Fiende fiende = new Fiende(texture);
                fiende.FiendePos = new Vector2(graphics.PreferredBackBufferWidth, random.Next(graphics.PreferredBackBufferHeight - 50));
                Spawner.Add(fiende);
                timer += 2;
            }
            for (int i = 0; i < Spawner.Count; i++)
            {
                Spawner[i].Update();
            }
            timer -= 1f / 60;

        }

        public FiendeSpawn(GraphicsDeviceManager graphics, Texture2D fiendeTex)
        {
            this.graphics = graphics;
            texture = fiendeTex;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for(int i=0; i<Spawner.Count;i++)
            {
                Spawner[i].Draw(spriteBatch);
            }
        }

    }
}