namespace WinFormsLogin
{
    partial class Registration
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(342, 158);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Введите электронную почту";
            textBox2.Size = new Size(250, 29);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(342, 113);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Придумайте логин";
            textBox1.Size = new Size(250, 29);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(263, 51);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 5;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LightGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(263, 337);
            button1.Name = "button1";
            button1.Size = new Size(249, 35);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.AllowDrop = true;
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(342, 203);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Придумайте пароль";
            textBox3.Size = new Size(250, 29);
            textBox3.TabIndex = 8;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.AllowDrop = true;
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(342, 248);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Повторно введите пароль";
            textBox4.Size = new Size(250, 29);
            textBox4.TabIndex = 9;
            textBox4.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(172, 248);
            button3.Name = "button3";
            button3.Size = new Size(148, 29);
            button3.TabIndex = 11;
            button3.Text = "Удалить фото";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(332, 302);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Есть аккаунт? Войти";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.BackgroundImage = Properties.Resources.add_photo_alternate_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(172, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 119);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}