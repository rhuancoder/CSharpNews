using System;
using System.Drawing;

namespace CSharpNewVersion
{
    enum MyColor
    {
        Yellow,
        Blue,
        Black,
        Red
    }

    class Switch
    {
        Color GetColor(MyColor myColor) 
        {
            switch (myColor)
            {
                case MyColor.Yellow:
                    return Color.Yellow;
                case MyColor.Blue:
                    return Color.Blue;
                default:
                    throw new Exception("this color is not yet implemented!");
            }

        }
    }
}