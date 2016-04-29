using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsMain.Models
{
    public class Button : Interfaces.IDrawable
    {
        private bool isPressed;
        private Texture2D texture;
        private Vector2 size;
        private Vector2 position;
        private Rectangle rectangle;
        private Color color;

        public Button(Texture2D texture, Vector2 size, Vector2 position)
        {
            this.Texture = texture;
            this.Size = size;
            this.Position = position;
            this.Color = new Color(255, 255, 255, 100);
        }

        public Color Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return this.rectangle;
            }
            set
            {
                this.rectangle = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public Vector2 Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public bool IsPressed
        {
            get
            {
                return this.isPressed;
            }
            set
            {
                this.isPressed = value;
            }
        }

        public Texture2D Texture
        {
            get
            {
                return this.texture;
            }
            set
            {
                this.texture = value;
            }
        }

        public void Update(MouseState mouse)
        {
            this.Rectangle = new Rectangle((int)this.Position.X, (int)this.Position.Y, (int)this.Size.X, (int)this.Size.Y);
            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);

            this.IsPressed = false;
            if (mouseRectangle.Intersects(this.Rectangle))
            {
                if (color.A > 200)
                {
                    color.A -= 3;
                }

                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    this.IsPressed = true;
                }
                else
                {
                    this.IsPressed = false;
                }
            }

            else if (Color.A < 250)
            {
                color.A += 3;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Rectangle, this.Color);
        }
    }
}
