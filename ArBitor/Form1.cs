using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArBitor
{
    public partial class ArBitor : Form
    {
        public ArBitor()
        {
            InitializeComponent();

            SystemDump exz = SystemDump.getInstance();
            label1.Text = Convert.ToString(exz.a.Second);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(DateTime.Now.Second);
            SystemDump ez = SystemDump.getInstance();
            label1.Text = Convert.ToString(ez.a.Second);
        }
    }
}
