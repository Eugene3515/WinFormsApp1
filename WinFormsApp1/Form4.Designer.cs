namespace WinFormsApp1
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            back = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Specialization = new DataGridViewTextBoxColumn();
            init3BindingSource = new BindingSource(components);
            exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)init3BindingSource).BeginInit();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(679, 412);
            back.Name = "back";
            back.Size = new Size(109, 26);
            back.TabIndex = 0;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(525, 39);
            button1.Name = "button1";
            button1.Size = new Size(209, 41);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(526, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(525, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(526, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 23);
            textBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Company, Phone, Specialization });
            dataGridView1.Location = new Point(27, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 412);
            dataGridView1.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            // 
            // Company
            // 
            Company.HeaderText = "Компания";
            Company.Name = "Company";
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.Name = "Phone";
            // 
            // Specialization
            // 
            Specialization.HeaderText = "Специальность";
            Specialization.Name = "Specialization";
            // 
            // init3BindingSource
            // 
            init3BindingSource.DataSource = typeof(Migrations.Init3);
            // 
            // exit
            // 
            exit.Location = new Point(765, 4);
            exit.Name = "exit";
            exit.Size = new Size(34, 26);
            exit.TabIndex = 8;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 94);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 9;
            label1.Text = "Название компании";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 149);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 10;
            label2.Text = "Номер телефона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 208);
            label3.Name = "label3";
            label3.Size = new Size(170, 15);
            label3.TabIndex = 11;
            label3.Text = "Требующаяся специальность";
            // 
            // button2
            // 
            button2.Location = new Point(525, 277);
            button2.Name = "button2";
            button2.Size = new Size(208, 41);
            button2.TabIndex = 12;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(527, 336);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(527, 321);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(back);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)init3BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private BindingSource init3BindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Specialization;
        private Button exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private TextBox textBox4;
        private Label label4;
    }
}