using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFace.Forms;

namespace WindowsFormsFace
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void createDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SetSettings form = new Form_SetSettings();
            form.ShowDialog();
        }
    }
}
