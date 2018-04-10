namespace WindowsFormsFace.Forms
{
    partial class Form_Create_DataSet
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
            this.label_path = new System.Windows.Forms.Label();
            this.label_cells_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_count_of_string = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to parsing folder:";
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(128, 18);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(0, 13);
            this.label_path.TabIndex = 1;
            // 
            // label_cells_count
            // 
            this.label_cells_count.AutoSize = true;
            this.label_cells_count.Location = new System.Drawing.Point(44, 42);
            this.label_cells_count.Name = "label_cells_count";
            this.label_cells_count.Size = new System.Drawing.Size(78, 13);
            this.label_cells_count.TabIndex = 2;
            this.label_cells_count.Text = "Count of string:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max count of entitys:";
            // 
            // label_count_of_string
            // 
            this.label_count_of_string.AutoSize = true;
            this.label_count_of_string.Location = new System.Drawing.Point(128, 42);
            this.label_count_of_string.Name = "label_count_of_string";
            this.label_count_of_string.Size = new System.Drawing.Size(0, 13);
            this.label_count_of_string.TabIndex = 4;
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(128, 67);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(0, 13);
            this.label_max.TabIndex = 5;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(270, 109);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form_Create_DataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 291);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_count_of_string);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_cells_count);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.label1);
            this.Name = "Form_Create_DataSet";
            this.Text = "Create DataSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Label label_cells_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_count_of_string;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Button button_start;
    }
}