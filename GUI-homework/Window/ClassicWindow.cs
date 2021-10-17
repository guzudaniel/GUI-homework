using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Window
{
    class ClassicWindow : IWindow
    {

        private double BorderRadius;
        private TextStyle TextStyle;
        private double Opacity;

        public ClassicWindow()
        {
            setBorderRadius(0);
            setTextStyle(TextStyle.Normal);
            setOpacity(0.5);
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
            Console.WriteLine("Classic window was generated.");
        }
    }
}
