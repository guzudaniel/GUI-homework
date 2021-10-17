using GUI_homework.Factories;
using GUI_homework.Window;
using System;

namespace GUI_homework
{
    class Program
    {
        private static Application config()
        {
            Application application;
            IThemeFactory factory;
            Theme theme = Theme.Rounded;

            if (theme == Theme.Rounded)
                factory = new RoundedFactory();
            else
            if (theme == Theme.Highlighted)
                factory = new HighlightedFactory();
            else
                factory = new ClassicFactory();

            application = new Application(factory);
            return application;
        }
        static void Main(string[] args)
        {
            Application application = config();
            application.draw();
        }
    }
}
