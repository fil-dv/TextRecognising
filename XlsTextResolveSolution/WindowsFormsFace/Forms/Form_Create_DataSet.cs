using DataSetCreater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFace.Forms
{
    public partial class Form_Create_DataSet : Form
    {
        public Form_Create_DataSet()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            string path = "";
            decimal depth = -1;
            decimal max = -1;
            DataSetManager.GetSettings(ref path, ref depth, ref max);
            if (path != "" && depth != -1 && max != -1)
            {
                toolStrip_depth.Text = depth.ToString(); 
                toolStrip_path.Text = path;
                toolStrip_max_count.Text = max.ToString();
                toolStrip_count.Text = "0";
            }
            else
            {
                MessageBox.Show("Settings not valid");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            DataSetManager.ParseFS(toolStrip_path.Text);
            MessageBox.Show("Готово!");
        }
    }
}
