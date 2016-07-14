using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsMain
{
    public static class Constants
    {

        

        public static string MainMenuBackgroudImageFilePath = "Images\\Backgrounds\\MainMenuBackground";
        public static string LevelOneBackgroudImageFilePath = "Images\\Backgrounds\\minimal-class";

        public static int ScreenWidth = 800;
        public static int ScreenHeight = 600;

        public static int StartButtonLocationX = (int)(ScreenWidth / 2.675585284280936);    // 299
        public static int StartButtonLocationY = (int)(ScreenHeight / 1.690140845070423);   // 355
        public static Vector2 StartButtonLocation = new Vector2(StartButtonLocationX, StartButtonLocationY);

        public static Vector2 StartButtonSize = new Vector2(ScreenWidth / 4, ScreenHeight / 12);
    }
}
