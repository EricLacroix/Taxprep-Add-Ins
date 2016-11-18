using System.Windows.Forms;

namespace WKCA.Sample
{
    public class OpenFileSimple
    {
        public static string Execute()
        {
            var od = new OpenFileDialog();
            od.DefaultExt = ".114";
            if (od.ShowDialog() == DialogResult.OK)
            {
                return od.FileName;
            }
            return "";
        }
    }
}