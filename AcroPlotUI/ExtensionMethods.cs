using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroPlotUI
{
    public static class ExtensionMethods
    {
        public static void InvokeIfRequired(this Control ctl, Action<Control> action)
        {
            if (ctl.InvokeRequired)
            {
                ctl.Invoke(new Action(() => action(ctl)));
            }
            else
            {
                action(ctl);
            }
        }
    }
}
