using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSharpNewVersion
{
    enum MyColor
    {
        Yellow,
        Blue,
        Black,
        Red
    }

    class Class2
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