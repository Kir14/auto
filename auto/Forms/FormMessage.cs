using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto.Forms
{
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();


        }

        public FormMessage(string message)
        {
            InitializeComponent();

            textBox1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
