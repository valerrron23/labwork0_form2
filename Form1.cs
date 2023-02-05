using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork0_form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");
              
                    switch (e.KeyChar)
                    {
                        case (char)49:
                        case (char)52:
                        case (char)55:
                            MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
                            e.Handled = true; 
                            break;
                    }
                
            }    
        }
    }
}
