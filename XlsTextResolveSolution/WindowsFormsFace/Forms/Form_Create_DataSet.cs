using DataSetCreater;
using DataSetCreater.Infrstr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            DataSetManager.GetSettings(ref path);
            if (path != "" )
            {
                toolStrip_path.Text = path;
                toolStrip_count.Text = "0";
            }
            else
            {
                MessageBox.Show("Settings not valid");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Logger.ClearLog();
            DateTime start = DateTime.Now;
            DataSetManager.ParseFS(toolStrip_path.Text);            
            DateTime stop = DateTime.Now;
            Logger.AddRecordToLog("Старт: " + start + Environment.NewLine +
                                  "Стоп: " + stop + Environment.NewLine +
                                  "Минуты: " + (stop - start).TotalMinutes + Environment.NewLine +
                                  "Секунды: " + (stop - start).TotalSeconds);
            MessageBox.Show("Готово!");
            Process.Start("notepad.exe", "log.txt");
        }
    }
}
