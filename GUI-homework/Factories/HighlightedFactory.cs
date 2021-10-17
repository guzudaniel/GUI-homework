using GUI_homework.Button;
using GUI_homework.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Factories
{
    class HighlightedFactory : IThemeFactory
    {
        public IButton createButton()
        {
            return new HighlightedButton();
        }
        public IWindow createWindow()
        {
            return new HighlightedWindow();
        }
    }
}
