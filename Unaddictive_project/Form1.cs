using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unaddictive_project
{
    public partial class Form1 : Form
    {
        private Protection protection = new Protection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            protection.generate = true;
            protection.Reference();
            Clipboard.SetText(protection.shuffled);
        }
    }
}
