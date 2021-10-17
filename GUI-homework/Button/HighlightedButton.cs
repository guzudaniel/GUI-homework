using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Button
{
    class HighlightedButton : IButton
    {
        private double BorderRadius;
        private TextStyle TextStyle;

        public HighlightedButton()
        {
            this.setBorderRadius(0);
            this.setTextStyle(TextStyle.Bold);
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
            Console.WriteLine("Highlighted button was generated.");
        }
    }
}
