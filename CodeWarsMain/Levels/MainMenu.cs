using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CodeWarsMain.Enums;


namespace CodeWarsMain.Levels
{
    public class MainMenu:Level
    {


        public MainMenu()
            : base(Constants.MainMenuBackgroudImageFilePath, GameState.MainMenu)
        {      
        }






        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }
    }
}
