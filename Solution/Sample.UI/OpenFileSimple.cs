using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WKCA.Sample
{
    public class OpenFileSimple
    {
        public static string Execute()
        {
            var od = new System.Windows.Forms.OpenFileDialog();
            od.DefaultExt = ".114";
            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return od.FileName;
            }
            else
            {
                return "";
            }
        }
    }
}
