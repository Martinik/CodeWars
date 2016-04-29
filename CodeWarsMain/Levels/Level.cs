using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CodeWarsMain.Enums;
using CodeWarsMain.Levels;
using CodeWarsMain;
using System.Collections;
using System;
using System.Collections.Generic;

namespace CodeWarsMain.Levels
{
    public abstract class Level
    {
        private GameState gameState;
        private string backgroundFilePath;

        public Level(string backgroundFilePath, GameState gameState)
        {
            this.BackgroundFilePath = backgroundFilePath;
            this.GameState = gameState;
        }
        public GameState GameState
        {
            get
            {
                return this.gameState;
            }
            set
            {
                this.gameState = value;
            }
        }

        public string BackgroundFilePath
        {
            get
            {
                return this.backgroundFilePath;
            }
            private set
            {
                this.backgroundFilePath = value;
            }
        }

        public int backgroundImageWidth { get; set; }

        public abstract void Update();
        public abstract void Load();
    }
}
