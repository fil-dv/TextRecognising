using DataSetCreater;
using Infrastructure.DataSetCreater;
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
        TableName _tableName;

        public Form_SetSettings()
        {
            InitializeComponent();
            InitCombo();
        }

        private void InitCombo()
        {
            comboBox_tables.DataSource = Enum.GetValues(typeof(TableName));
        }

        private void checkBox_path_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox_tables.Text.Length > 0)
            {
                button_ok.Enabled = true;
            }
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
            DataSetManager.SetSettings(_path, _tableName);
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

        private void comboBox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<TableName>(comboBox_tables.SelectedValue.ToString(), out _tableName);
        }


    }
}
