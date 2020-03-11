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
    class SpawnFiende
    {

        private List<Fiende> Spawner = new List<Fiende>();
        Random random = new Random();

        private Vector2 position;
        private Texture2D texture;
        GraphicsDeviceManager graphics;




        public void Update()
        {

            Fiende fiende = new Fiende(texture);
            fiende.FiendePos = new Vector2(graphics.PreferredBackBufferWidth, random.Next(graphics.PreferredBackBufferHeight - 50));
        }

        public SpawnFiende(GraphicsDeviceManager graphics, Texture2D fiendeTex)
        {
            this.graphics = graphics;
            texture = fiendeTex;
        }

        //Fixa Draw!!!!!!!!!!!!!!!!

    }
}