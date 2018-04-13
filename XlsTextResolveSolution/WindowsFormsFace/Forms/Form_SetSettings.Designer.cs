namespace WindowsFormsFace.Forms
{
    partial class Form_SetSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_path = new System.Windows.Forms.CheckBox();
            this.comboBox_tables = new System.Windows.Forms.ComboBox();
            this.checkBox_table = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select path to file:";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(135, 19);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(246, 23);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Select folder";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(26, 128);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(398, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_path
            // 
            this.checkBox_path.AutoSize = true;
            this.checkBox_path.Enabled = false;
            this.checkBox_path.Location = new System.Drawing.Point(409, 26);
            this.checkBox_path.Name = "checkBox_path";
            this.checkBox_path.Size = new System.Drawing.Size(15, 14);
            this.checkBox_path.TabIndex = 7;
            this.checkBox_path.UseVisualStyleBackColor = true;
            this.checkBox_path.CheckedChanged += new System.EventHandler(this.checkBox_path_CheckedChanged);
            // 
            // comboBox_tables
            // 
            this.comboBox_tables.FormattingEnabled = true;
            this.comboBox_tables.Location = new System.Drawing.Point(135, 70);
            this.comboBox_tables.Name = "comboBox_tables";
            this.comboBox_tables.Size = new System.Drawing.Size(246, 21);
            this.comboBox_tables.TabIndex = 8;
            this.comboBox_tables.SelectedIndexChanged += new System.EventHandler(this.comboBox_tables_SelectedIndexChanged);
            // 
            // checkBox_table
            // 
            this.checkBox_table.AutoSize = true;
            this.checkBox_table.Location = new System.Drawing.Point(409, 77);
            this.checkBox_table.Name = "checkBox_table";
            this.checkBox_table.Size = new System.Drawing.Size(15, 14);
            this.checkBox_table.TabIndex = 9;
            this.checkBox_table.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Table name:";
            // 
            // Form_SetSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_table);
            this.Controls.Add(this.comboBox_tables);
            this.Controls.Add(this.checkBox_path);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SetSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataSet settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckBox checkBox_path;
        private System.Windows.Forms.ComboBox comboBox_tables;
        private System.Windows.Forms.CheckBox checkBox_table;
        private System.Windows.Forms.Label label2;
    }
}