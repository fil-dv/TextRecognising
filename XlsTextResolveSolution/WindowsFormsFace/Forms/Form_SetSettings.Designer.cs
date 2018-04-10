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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.numericUpDown_sells_number = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_max = new System.Windows.Forms.NumericUpDown();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_path = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sells_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set sells number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max entity count:";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(139, 19);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Select folder";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // numericUpDown_sells_number
            // 
            this.numericUpDown_sells_number.Location = new System.Drawing.Point(139, 55);
            this.numericUpDown_sells_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sells_number.Name = "numericUpDown_sells_number";
            this.numericUpDown_sells_number.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_sells_number.TabIndex = 4;
            this.numericUpDown_sells_number.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_max
            // 
            this.numericUpDown_max.Location = new System.Drawing.Point(139, 97);
            this.numericUpDown_max.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_max.Name = "numericUpDown_max";
            this.numericUpDown_max.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_max.TabIndex = 5;
            this.numericUpDown_max.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(26, 153);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(220, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_path
            // 
            this.checkBox_path.AutoSize = true;
            this.checkBox_path.Enabled = false;
            this.checkBox_path.Location = new System.Drawing.Point(231, 23);
            this.checkBox_path.Name = "checkBox_path";
            this.checkBox_path.Size = new System.Drawing.Size(15, 14);
            this.checkBox_path.TabIndex = 7;
            this.checkBox_path.UseVisualStyleBackColor = true;
            this.checkBox_path.CheckedChanged += new System.EventHandler(this.checkBox_path_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(231, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(231, 103);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form_SetSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 197);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox_path);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.numericUpDown_max);
            this.Controls.Add(this.numericUpDown_sells_number);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SetSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataSet settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sells_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.NumericUpDown numericUpDown_sells_number;
        private System.Windows.Forms.NumericUpDown numericUpDown_max;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckBox checkBox_path;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}