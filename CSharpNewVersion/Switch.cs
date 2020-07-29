using NUnit.Framework;
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

    class Switch
    {
        Color GetColor(MyColor myColor) =>
            myColor switch 
            {
                MyColor.Yellow => Color.Yellow,
                MyColor.Blue => Color.Blue,
                _ => throw new Exception("this color is not yet implemented!")
            };

        [Test]
        public void SwitchTest()
        {
            var selectedColor = GetColor(MyColor.Blue);

            Assert.That(Color.Blue, Is.EqualTo(selectedColor));
        }

    }
}
