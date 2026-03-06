namespace WinFormsApp1_h
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.스크린샷_2026_03_05_120527;
            pictureBox1.Location = new Point(33, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("휴먼편지체", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(555, 378);
            button1.Name = "button1";
            button1.Size = new Size(215, 60);
            button1.TabIndex = 1;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("휴먼편지체", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(347, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 51);
            textBox1.TabIndex = 2;
            textBox1.Text = "하다현";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("문체부 쓰기 정체", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox2.Location = new Point(347, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 32);
            textBox2.TabIndex = 3;
            textBox2.Text = "수원대학교 정보보호학과";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("바탕체", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox3.Location = new Point(347, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 37);
            textBox3.TabIndex = 4;
            textBox3.Text = "010-1234-5678";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.Font = new Font("문체부 쓰기 정체", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(800, 32);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "나의 첫 GUI 프로그램";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
    }
}
