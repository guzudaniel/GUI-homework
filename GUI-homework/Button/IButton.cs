using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Button
{
    interface IButton
    {
        public void setBorderRadius(double Radius);
        public void setTextStyle(TextStyle TextStyle);
        public void draw();

    }
}
