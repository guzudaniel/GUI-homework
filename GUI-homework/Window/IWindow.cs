using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Window
{
    interface IWindow
    {
        public void setBorderRadius(double Radius);
        public void setTextStyle(TextStyle TextStyle);
        public void setOpacity(double Opacity);
        public void draw();
    }
}
