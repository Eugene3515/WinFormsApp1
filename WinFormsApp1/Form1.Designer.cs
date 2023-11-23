namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginbox = new TextBox();
            passbox = new TextBox();
            registr = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            autorize = new Button();
            passaut = new TextBox();
            loginaut = new TextBox();
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginbox
            // 
            loginbox.Location = new Point(28, 114);
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(289, 23);
            loginbox.TabIndex = 0;
            // 
            // passbox
            // 
            passbox.Location = new Point(28, 213);
            passbox.Name = "passbox";
            passbox.Size = new Size(291, 23);
            passbox.TabIndex = 1;
            passbox.TextChanged += passbox_TextChanged;
            // 
            // registr
            // 
            registr.Location = new Point(91, 269);
            registr.Name = "registr";
            registr.Size = new Size(165, 25);
            registr.TabIndex = 2;
            registr.Text = "Регистрация";
            registr.UseVisualStyleBackColor = true;
            registr.Click += registr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(28, 79);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(28, 178);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(28, 9);
            label3.Name = "label3";
            label3.Size = new Size(234, 50);
            label3.TabIndex = 5;
            label3.Text = "Регистрация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(539, 9);
            label4.Name = "label4";
            label4.Size = new Size(246, 50);
            label4.TabIndex = 11;
            label4.Text = "Авторизация";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(539, 178);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 10;
            label5.Text = "Пароль";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(539, 79);
            label6.Name = "label6";
            label6.Size = new Size(81, 32);
            label6.TabIndex = 9;
            label6.Text = "Логин";
            // 
            // autorize
            // 
            autorize.Location = new Point(602, 269);
            autorize.Name = "autorize";
            autorize.Size = new Size(165, 25);
            autorize.TabIndex = 8;
            autorize.Text = "Авторизация";
            autorize.UseVisualStyleBackColor = true;
            autorize.Click += autorize_Click;
            // 
            // passaut
            // 
            passaut.Location = new Point(539, 213);
            passaut.Name = "passaut";
            passaut.Size = new Size(291, 23);
            passaut.TabIndex = 7;
            // 
            // loginaut
            // 
            loginaut.Location = new Point(539, 114);
            loginaut.Name = "loginaut";
            loginaut.Size = new Size(289, 23);
            loginaut.TabIndex = 6;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 331);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(421, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 331);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(879, 9);
            button1.Name = "button1";
            button1.Size = new Size(28, 24);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 331);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(autorize);
            Controls.Add(passaut);
            Controls.Add(loginaut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registr);
            Controls.Add(passbox);
            Controls.Add(loginbox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginbox;
        private TextBox passbox;
        private Button registr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button autorize;
        private TextBox passaut;
        private TextBox loginaut;
        private Splitter splitter1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
