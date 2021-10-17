using GUI_homework.Button;
using GUI_homework.Factories;
using GUI_homework.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_homework
{
    class Application
    {
        private IButton button;
        private IWindow window;

        public Application(IThemeFactory factory)
        {
            button = factory.createButton();
            window = factory.createWindow();

        }
        public void draw()
        {
            button.draw();
            window.draw();
        }
    }
}
