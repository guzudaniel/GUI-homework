using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Button
{
    class ClassicButton : IButton
    {
        private double BorderRadius;
        private TextStyle TextStyle;

        public ClassicButton()
        {
            this.setBorderRadius(0);
            this.setTextStyle(TextStyle.Normal);
        }


        public void setBorderRadius(double Radius)
        {
            this.BorderRadius = Radius;
        }

        public void setTextStyle(TextStyle TextStyle)
        {
            this.TextStyle = TextStyle;
        }
        public void draw()
        {
            Console.WriteLine("Classic button was generated.");
        }
    }
}
