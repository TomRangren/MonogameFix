using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Fiende
    {
        Vector2 position;
        Texture2D texture;



        public Fiende(Texture2D texture)
        {
            this.texture = texture;
        }

        public Vector2 FiendePos { get { return position; } set { position = value; } }
        public void Update()
        {

            position.X -= 10;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(), new Point(200, 200)), Color.White);
        }
    }
}

