namespace WinFormsApp1
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Names = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Specialization = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            textBox7 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Names, Surname, Age, Phone, City, Specialization });
            dataGridView1.Location = new Point(16, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 428);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            // 
            // Names
            // 
            Names.HeaderText = "Имя";
            Names.Name = "Names";
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            // 
            // Age
            // 
            Age.HeaderText = "Возраст";
            Age.Name = "Age";
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.Name = "Phone";
            // 
            // City
            // 
            City.HeaderText = "Город";
            City.Name = "City";
            // 
            // Specialization
            // 
            Specialization.HeaderText = "Специальность";
            Specialization.Name = "Specialization";
            // 
            // button1
            // 
            button1.Location = new Point(808, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 22);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(781, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(781, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(781, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(781, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(170, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(781, 315);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(781, 379);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(170, 23);
            textBox6.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(999, 61);
            button2.Name = "button2";
            button2.Size = new Size(91, 22);
            button2.TabIndex = 8;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(982, 109);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(121, 23);
            textBox7.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(1083, 8);
            button3.Name = "button3";
            button3.Size = new Size(26, 24);
            button3.TabIndex = 10;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1021, 419);
            button4.Name = "button4";
            button4.Size = new Size(89, 23);
            button4.TabIndex = 11;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(781, 43);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 12;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(781, 105);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 13;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(781, 169);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 14;
            label3.Text = "Возраст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(781, 235);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(781, 297);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 16;
            label5.Text = "Город";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(781, 361);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 17;
            label6.Text = "Специальность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(982, 91);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 18;
            label7.Text = "ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Specialization;
        private Button button2;
        private TextBox textBox7;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}