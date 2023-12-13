namespace CarRepairShop
{
    partial class ClientsForm
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 33);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 109);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 270);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 194);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 344);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 23);
            textBox4.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(56, 411);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 5;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Apply_Click;
            // 
            // button2
            // 
            button2.Location = new Point(144, 411);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Client Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 92);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 8;
            label2.Text = "EGN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 253);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 327);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 10;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 165);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 11;
            label5.Text = "City";
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 457);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientsForm";
            Text = "ClientsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}