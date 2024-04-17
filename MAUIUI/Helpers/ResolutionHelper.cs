using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIUI.Helpers
{
    public class ResolutionHelper
    {
       /* public static void ResizeForm(Form form)
        {
            Size screenSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            if (screenSize.Height < 650)
            {
                form.WindowState = FormWindowState.Maximized;
                form.MaximizeBox = true;
                form.Size = screenSize;
            }
            else if (screenSize.Height is >= 650 and < 1000)
            {
                form.WindowState = FormWindowState.Normal;
                if(form.Name is "visits" or "addnewvisit")
                {
                    form.WindowState = FormWindowState.Maximized;

                }
                form.MaximizeBox = true;
                form.Height = 640;
                if (screenSize.Width < 1024)
                {
                    form.Width = screenSize.Width;
                }
                else
                {
                    form.Width = 1000;
                }

            }
            else
            {
                if (form.Name is "visits" or "addnewvisit")
                {
                    return;
                }
                form.WindowState = FormWindowState.Normal;
                form.MaximizeBox = true;
                form.Height = (int)(screenSize.Height * 0.8);
                if (screenSize.Width < 1280)
                {
                    form.Width = screenSize.Width;
                }
                else
                {
                    form.Width = 1280;
                }
            }
        }*/
    }
}
