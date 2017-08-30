using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_Build1
{
    
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            GlobalVars g = new GlobalVars();
            World w = new World();
            tb_hello.Text = w.GetHello;
            g.SetCnt();
        }
    }
}
