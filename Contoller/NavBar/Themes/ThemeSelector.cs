using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMAS.Controller.NavBar.Themes
{
    /// <summary>
    /// Navigation control theme selector
    /// </summary>
    public class ThemeSelector
    {

        public ITheme CurrentTheme;

        public ThemeSelector(Theme theme)
        {
            // Note: If you implement more themes or your own themes, just add CurrentTheme here

            switch (theme)
            {
                case Theme.Dark:
                    CurrentTheme = new DarkTheme();
                    break;
                case Theme.Transparency:
                    CurrentTheme = new TransparencyTheme();
                    break;
            }
        }

    }
}
