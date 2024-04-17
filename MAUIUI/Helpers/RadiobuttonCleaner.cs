using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIUI.Helpers
{
    public class RadiobuttonCleaner
    {
        static public void cleanRadiobuttons(params RadioButton[] buttons)
        {
            foreach (var item in buttons)
            {
                item.IsChecked = false;
            }
        }

        static public void cleanCheckBoxes(params CheckBox[] buttons)
        {
            foreach (var item in buttons)
            {
                item.IsChecked = false;
            }
        }
        
    }
}
