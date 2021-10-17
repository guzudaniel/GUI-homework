using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Button
{
    class RoundedButton : IButton
    {
        private double BorderRadius;
        private TextStyle TextStyle;

        public RoundedButton()
        {
            this.setBorderRadius(0.5);
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
            Console.WriteLine("Rounded button was generated.");
        }
    }
}
