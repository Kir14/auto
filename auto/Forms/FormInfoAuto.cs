using auto.DataBase;
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
    public partial class FormInfoAuto : Form
    {
        Automobiles auto;

        public FormInfoAuto()
        {
            InitializeComponent();
        }

        public FormInfoAuto(Automobiles autoIn)
        {
            InitializeComponent();

            auto = autoIn;
        }
    }
}
