namespace CarRepairShop
{
    partial class CarsForm
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Apply = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Registration Number";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(10, 157);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(317, 157);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(236, 23);
            comboBox3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(23, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 82);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Number of Doors";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(349, 12);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Price";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 6;
            // 
            // Apply
            // 
            Apply.Location = new Point(395, 349);
            Apply.Name = "Apply";
            Apply.Size = new Size(75, 23);
            Apply.TabIndex = 7;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = true;
            Apply.Click += Apply_Click;
            // 
            // button2
            // 
            button2.Location = new Point(476, 349);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 64);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Car Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 139);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "Car Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "Car Color";
            // 
            // CarsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 384);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(Apply);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "CarsForm";
            Text = "CarsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Apply;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}