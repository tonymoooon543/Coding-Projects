using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TestingForms
{
    partial class AboutBox1 : Form
    {
        private Bitmap img1 = null;
        public AboutBox1()
        {
            InitializeComponent();
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("C:/Users/wayne/Desktop/Jakob2/Programing/C++ and C#/Shit/TestingForms/TestingForms/jb-software.png");
        }
    }
}
