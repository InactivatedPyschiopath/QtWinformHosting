using System;
using System.Windows.Forms;

namespace Winform
{
    static class Program
    {
        static Window window;

        [DllExport]
        static IntPtr CreateForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new Window();
            window.Size = new System.Drawing.Size(1,1);
            window.StartPosition = FormStartPosition.Manual;
            window.Location = new System.Drawing.Point(-60, -60);
            window.Show();
            return window.Handle;
        }
    }
}
