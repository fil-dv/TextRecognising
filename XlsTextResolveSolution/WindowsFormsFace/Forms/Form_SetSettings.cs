using DataSetCreater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFace.Forms
{
    public partial class Form_SetSettings : Form
    {
        string _path = "";

        

        public Form_SetSettings()
        {
            InitializeComponent();
        }

        private void checkBox_path_CheckedChanged(object sender, EventArgs e)
        {
            button_ok.Enabled = true;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _path = fbd.SelectedPath;
                    checkBox_path.Checked = true;
                }
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            DataSetManager.SetSettings(_path, numericUpDown_sells_number.Value, numericUpDown_max.Value);
            if (DataSetManager.IsSettingInit())
            {
                Form_Create_DataSet form = new Form_Create_DataSet();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Settings is not valid...");
            }
        }
    }
}
