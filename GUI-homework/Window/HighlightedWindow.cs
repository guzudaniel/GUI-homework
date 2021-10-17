using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Window
{
    class HighlightedWindow : IWindow
    {
        private double BorderRadius;
        private TextStyle TextStyle;
        private double Opacity;

        public HighlightedWindow()
        {
            setBorderRadius(0);
            setTextStyle(TextStyle.Bold);
            setOpacity(1);
        }

        public void setBorderRadius(double Radius)
        {
            this.BorderRadius = Radius;
        }

        public void setTextStyle(TextStyle TextStyle)
        {
            this.TextStyle = TextStyle;
        }
        public void setOpacity(double Opacity)
        {
            this.Opacity = Opacity;
        }
        public void draw()
        {
            Console.WriteLine("Highlighted window was generated.");
        }
    }
}
