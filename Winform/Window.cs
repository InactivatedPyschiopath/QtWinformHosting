using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Winform
{
    public partial class Window : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        
        IntPtr parent;
        public Window(IntPtr _parent)
        {
            parent = _parent;
            InitializeComponent();
            Console.WriteLine($"Parent Handle : {_parent.ToInt32():X8}");
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            // Console.WriteLine($"ProcessKeyPreview Called.");
            SendMessage(parent, m.Msg, m.WParam, m.LParam);
            return base.ProcessKeyPreview(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }
    }
}
