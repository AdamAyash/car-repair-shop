namespace CarRepairShop
{
    partial class RepairsForm
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(70, 95);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(70, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(70, 232);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 289);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Платено";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(231, 289);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Върнато";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(196, 351);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Apply_Click;
            // 
            // button4
            // 
            button4.Location = new Point(277, 351);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 8;
            label1.Text = "Client Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 77);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 9;
            label2.Text = "Plate Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 143);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 10;
            label3.Text = "Date From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 214);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "Date To";
            // 
            // RepairsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 385);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "RepairsForm";
            Text = "RepairsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}