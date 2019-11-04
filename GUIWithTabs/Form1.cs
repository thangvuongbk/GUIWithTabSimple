using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIWithTabs
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void tabControl_Changed(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang chọn Tab0" + (tabControl.SelectedIndex + 1));
            
        }
   
    }
}
