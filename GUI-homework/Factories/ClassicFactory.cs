using GUI_homework.Button;
using GUI_homework.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework.Factories
{
    class ClassicFactory : IThemeFactory
    {
        public IButton createButton()
        {
            return new ClassicButton();
        }

        public IWindow createWindow()
        {
            return new ClassicWindow();
        }
    }
}
